using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IllusionPlugin;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using TMPro;

namespace JislandEditor
{
    public class Plugin : IPlugin
    {
        public string Name
        {
            get { return "Cool Mod Plugin"; }
        }
        public string Version
        {
            get { return "1.0"; }
        }

        int LevelsCreated;
        int _currentLevelId;
        HologramButtonScript hologramBasis;
        GameObject newIsland;
        GameObject shaders;
        Material islandMaterial;
        bool LoadedLevel = false;
        Vector3 currentHologramPlacement;
        float GameTime;
        bool MessagesShown = false;
        bool LoadedMenu;


        public void Init()
        {


        }

        public void OnLevelWasInitialized(int level)
        {
            int _currentLevelId = level;

            if (level == 0) LoadedLevel = false;

            Init();
        }

        void IPlugin.OnApplicationStart()
        {
        }

        void IPlugin.OnApplicationQuit()
        {
        }

        void IPlugin.OnLevelWasLoaded(int level)
        {
        }

        void IPlugin.OnLevelWasInitialized(int level)
        {
            GameTime = 0;
            _currentLevelId = level;

            if (_currentLevelId == 1)
            {
                InitializeEditor();
                LoadedMenu = false;
            }
            else
            {
                LoadedLevel = false;
                MessagesShown = false;
            }
        }

        void InitializeEditor()
        {
            GameObject.Find("kill fall off map").transform.localScale = new Vector3(4, 4, 1);
            if (GameObject.Find("Start button"))
            {
                hologramBasis = GameObject.Find("Start button").GetComponent<HologramButtonScript>();
            }
            else
            {
                hologramBasis = PlayerBody.localPlayer.pauseMenu.hologramMenuController.GetComponentInChildren<TextMeshPro>(true).transform.parent.GetComponent<HologramButtonScript>();
            }
            LoadedLevel = true;

            ReloadHolograms(false);
        }

        public void ShowMessages()
        {
            if (LevelsCreated != 0)
            {
                PlayerBody.localPlayer.DisplayMessageInFrontOfPlayer($"{LevelsCreated} levels loaded; Visit the ship");
            }
            else
            {
                PlayerBody.localPlayer.DisplayMessageInFrontOfPlayer("No levels loaded, see desktop; Reload with F5");
                Application.OpenURL("file://" + Application.streamingAssetsPath);
            }
        }

        public void ReloadHolograms(bool ShowMessage)
        {
            if (GameObject.FindObjectOfType<LoadedLevel>()) return;

            currentHologramPlacement = new Vector3(1963.073f, 100.1058f, 9602.432f);
            LevelLoadButton[] buttonsActive = LevelLoadButton.FindObjectsOfType<LevelLoadButton>();
            foreach (LevelLoadButton button in buttonsActive) GameObject.Destroy(button.gameObject);

            LevelsCreated = 0;
            string[] files = Directory.GetFiles(Application.streamingAssetsPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (fileName.Contains(".txt") && fileName != "build_info.txt")
                {
                    if (File.ReadAllLines(file)[0].Split(',').Length == 10)
                    {
                        LevelsCreated++;
                        string normalName = Path.GetFileNameWithoutExtension(file);
                        CreateHologram(normalName, file);
                    }
                }
            }
            if (ShowMessage) ShowMessages();
        }

        public bool CanFindLevel(string Name)
        {
            bool found = false;
            LevelLoadButton[] buttons = GameObject.FindObjectsOfType<LevelLoadButton>();
            foreach (LevelLoadButton b in buttons) if (b.name == Name) found = true;
            return found;
        }

        public void LoadMenu()
        {
            
            TextMeshPro titleText = GameObject.Instantiate(GameObject.Find("by Eric Tereshinski")).GetComponent<TextMeshPro>();
            titleText.transform.position = new Vector3(0, 2.4556f, 3.3461f);
            titleText.text = "Jisland Editor!\r\nPress F1 to open levels folder";
            titleText.fontSize = 30;
            titleText.transform.gameObject.name = "Jisland Editor";
        }

        void IPlugin.OnUpdate()
        {
            GameTime += Time.deltaTime;
            if (_currentLevelId == 1)
            {
                if (GameTime > 1f && !LoadedLevel)
                {
                    LoadedLevel = true;
                    InitializeEditor();
                }
                if (GameTime > 3f && !MessagesShown)
                {
                    ShowMessages();
                    MessagesShown = true;
                }
                if (Input.GetKeyDown(KeyCode.F5) && _currentLevelId == 1)
                {
                    ReloadHolograms(true);
                }
            } else
            {
                if (!LoadedMenu && GameTime > 1)
                {
                    LoadMenu();
                    LoadedMenu = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.F1)) Application.OpenURL("file://" + Application.streamingAssetsPath);
        }

        public void CreateHologram(string Text, string path)
        {

            GameObject newHologram = new GameObject(Text);
            HologramButtonScript he = hologramBasis;
            newHologram.transform.localScale = new Vector3(10f, 10f, 5f);
            newHologram.AddComponent<MeshFilter>().sharedMesh = he.GetComponent<MeshFilter>().sharedMesh;
            newHologram.AddComponent<MeshRenderer>().sharedMaterial = he.GetComponent<MeshRenderer>().sharedMaterial;
            Transform originalText = he.GetComponentInChildren<TextMeshPro>(true).transform;
            TextMeshPro textChild = GameObject.Instantiate(originalText.gameObject).GetComponent<TextMeshPro>();
            textChild.transform.gameObject.SetActive(true);
            textChild.transform.parent = newHologram.transform;
            textChild.transform.localPosition = originalText.localPosition;
            textChild.transform.localScale = Vector3.one * 0.015f;
            textChild.transform.localEulerAngles = new Vector3(0, 0, 0);
            textChild.text = Text + "\nEnter to load";
            newHologram.AddComponent<BoxCollider>();
            MeshRenderer render = newHologram.GetComponent<MeshRenderer>();
            render.material.SetColor("_Color", Color.blue);
            render.material.SetFloat("_Brightness", 2f);
            newHologram.transform.position = currentHologramPlacement;
            newHologram.transform.eulerAngles = new Vector3(0, 90, 0);
            currentHologramPlacement += Vector3.back * 12;
            LevelLoadButton b = newHologram.AddComponent<LevelLoadButton>();
            b.myPath = path;

        }

        public Vector3 ParseVector(string[] get, int a, int b, int c)
        {
            return new Vector3(float.Parse(get[a]), float.Parse(get[b]), float.Parse(get[c]));
        }

        public void SetupNewIsland()
        {
            AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "newisland.unity3d"));
            GameObject prefab = assetBundle.LoadAsset<GameObject>("New Island");
            assetBundle.Unload(false);




            newIsland = GameObject.Instantiate(prefab);
            newIsland.transform.position = new Vector3(-85.8f, 121.0f, 9561.8f);
            SetupLayer();

            GameObject terrain = getChildByName("IslandBase");
            TextureIsland(terrain, "first_island");


            string sm = "Tutorial_island_buildings_round2";
            TextureIsland(getChildByName("Floaters"), sm);
            TextureIsland(getChildByName("Grounded"), sm);
            TextureIsland(getChildByName("Mechanisms"), sm);
            TextureIsland(getChildByName("Spiral"), sm);
            TextureIsland(getChildByName("Torus"), sm);


            RemoveAll();

            PlayerBody.localPlayer.DisplayMessageInFrontOfPlayer("Welcome to the new island!");
        }

        public void SetupLayer()
        {
            LayerMask ground = LayerMask.NameToLayer("Ground");
            Transform[] children = newIsland.GetComponentsInChildren<Transform>();
            foreach (Transform t in children) t.gameObject.layer = ground;
            //getChildByName("Boosts").layer = LayerMask.NameToLayer("Boosts");
            //getChildByName("Boosts").tag = "SpeedBoost";
        }

        public void TextureIsland(GameObject obj, string Copy)
        {
            MeshRenderer render = obj.GetComponent<MeshRenderer>();
            Texture splat = render.material.GetTexture("_MainTex");
            Texture occ = render.material.GetTexture("_OcclusionMap");

            render.material = GameObject.Find(Copy).GetComponent<MeshRenderer>().material;
            render.material.SetTexture("_Splatmap", splat);
            render.material.SetTexture("_AOMap", occ);
        }

        public void RemoveAll()
        {
            PlayerBody.localPlayer.respawning.respawnPoints[0] = new Vector3(1902.4f, 200.16f, 9566.2f);
            PlayerBody.localPlayer.respawning.lastGottenCheckpoint = 0;
            for (int i = 0; i < PlayerBody.upgradeBotSpawnVectors.Length; i++) PlayerBody.upgradeBotSpawnVectors[i] = new Vector3(0, 999999, 0);
            for (int i = 0; i < PlayerBody.localPlayer.modifiers.modifierOrbVectors.Length; i++) PlayerBody.localPlayer.modifiers.modifierOrbVectors[i] = new Vector3(0, 999999, 0);

            GameObject.Find("island model4 AO test").SetActive(false);
            GameObject[] wormyParts = GameObject.FindObjectOfType<MonsterScript>().bodyPartsGameObjects;
            foreach (GameObject w in wormyParts) w.SetActive(false);

            GameObject.FindObjectOfType<MonsterScript>().gameObject.SetActive(false);

            // doing all this the worst way possible but i dont know how to pass a type as a parameter properly apparently YIPPIEE!!!!!!!!!!!!!!

            MovingPlatformScript[] movingPlatforms = GameObject.FindObjectsOfType<MovingPlatformScript>();
            foreach(MovingPlatformScript m in movingPlatforms) m.gameObject.SetActive(false);

            MinibossActivater[] minibosses = GameObject.FindObjectsOfType<MinibossActivater>();
            foreach (MinibossActivater m in minibosses) m.gameObject.SetActive(false);

            GameObject[] tag = GameObject.FindGameObjectsWithTag("LaunchPad");
            foreach (GameObject tagged in tag) tagged.SetActive(false);

            ParticleSystem[] particles = GameObject.FindObjectsOfType<ParticleSystem>();
            foreach(ParticleSystem p in particles) if (p.transform.parent == null) p.gameObject.SetActive(false);

            MoveOverTime[] mov = GameObject.FindObjectsOfType<MoveOverTime>();
            foreach (MoveOverTime m in mov) if (m.transform.parent == null) m.gameObject.SetActive(false);

            SphereCollider[] spheres = GameObject.FindObjectsOfType<SphereCollider>();
            foreach (SphereCollider s in spheres) if (s.transform.parent == null && s.name.Contains("miniboss")) s.gameObject.SetActive(false);

            GameObject.Find("upgrade bot indicator particles").SetActive(false);


        }

        public void RemoveAllOfType(Type type)
        {
            GameObject[] all = (GameObject[])GameObject.FindObjectsOfType(type);
            foreach (GameObject t in all) t.SetActive(false);
        }

        public void Reshader()
        {
            islandMaterial = getChildByName("Terrain").GetComponent<MeshRenderer>().material;

            GameObject island = GameObject.Find("island model4 AO test");
            MeshRenderer[] children = island.GetComponentsInChildren<MeshRenderer>();
            foreach(MeshRenderer r in children)
            {
                if (r.material.shader.name == "EricsSplatmap")
                {
                    r.material = islandMaterial;
                }
            }
        }

        GameObject getChildByName(string name)
        {
            GameObject child = null;
            Transform[] children = newIsland.GetComponentsInChildren<Transform>();
            foreach(Transform c in children)
            {
                if (c.name == name) child = c.gameObject;
            }
            return child;
        } 

        void IPlugin.OnFixedUpdate()
        {
        }
    }
}
