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
    public class LevelLoadButton : MonoBehaviour
    {
        GameObject playerPos;
        public string myPath;
        AssetBundle bundle;
        bool Loaded = false;
        float UnloadTime;
        private void Start()
        {
            playerPos = Camera.main.gameObject;
        }
        public void Update()
        {
            if (Vector3.Distance(transform.position, playerPos.transform.position) < 5 && !Loaded)
            {
                CreateLevel(myPath);
            }
            if (Loaded == true)
            {
                UnloadTime += Time.deltaTime;
                if (UnloadTime > 2)
                {
                    UnloadBundle();
                }
            }
        }

        public void CreateLevel(string path)
        {
            Debug.Log("Began creating level...");
            UnloadTime = 0;
            Loaded = true;
            LoadedLevel[] level = GameObject.FindObjectsOfType<LoadedLevel>();
            foreach (LoadedLevel l in level) GameObject.Destroy(l.gameObject);

            bundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "jislandeditor.unity3d"));

            LayerMask groundLayer = LayerMask.NameToLayer("Ground");
            GameObject levelParent = new GameObject("Level");
            levelParent.AddComponent<LoadedLevel>();
            levelParent.transform.localScale = Vector3.one * 10;
            levelParent.transform.position = new Vector3(1902.4f, 88.16f, 9566.2f);

            string levelData = File.ReadAllText(path);
            string[] lines = levelData.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                string[] currentLine = lines[i].Split(',');
                if (currentLine.Length == 10)
                {
                    GameObject loaded = bundle.LoadAsset<GameObject>(currentLine[0]);
                    GameObject prefab = GameObject.Instantiate(loaded, levelParent.transform);
                    Vector3 position = ParseVector(currentLine, 1, 2, 3);
                    Vector3 eulerAngles = ParseVector(currentLine, 4, 5, 6);
                    Vector3 scale = ParseVector(currentLine, 7, 8, 9);
                    prefab.transform.localPosition = position;
                    prefab.transform.localEulerAngles = eulerAngles;
                    prefab.transform.localScale = scale;
                    prefab.layer = groundLayer;
                    MeshCollider col = prefab.AddComponent<MeshCollider>();
                    col.sharedMesh = prefab.GetComponent<MeshFilter>().sharedMesh;

                    bool GetMaterialAfter = false;
                    MeshRenderer render = prefab.GetComponent<MeshRenderer>();
                    if (loaded.name == "SpeedBoost")
                    {
                        prefab.tag = "SpeedBoost";
                        prefab.layer = LayerMask.NameToLayer("Boosts");
                        GetMaterialAfter = true;
                    } else if (loaded.name == "Spike")
                    {
                        prefab.tag = "Spikes";
                        prefab.layer = LayerMask.NameToLayer("Spikes");
                        GetMaterialAfter = true;
                    } else if (loaded.name == "WaterCircle")
                    {
                        prefab.tag = "Water";
                        prefab.layer = LayerMask.NameToLayer("Water");
                        GetMaterialAfter = true;
                    } else
                    {
                        Texture splat = render.material.GetTexture("_MainTex");
                        Texture occ = render.material.GetTexture("_OcclusionMap");
                        render.material = GameObject.Find(prefab.GetComponentInChildren<CapsuleCollider>(true).name).GetComponent<MeshRenderer>().material;
                        render.material.SetTexture("_Splatmap", splat);
                        render.material.SetTexture("_AOMap", occ);
                    }
                    if (GetMaterialAfter) render.material = GameObject.Find(prefab.GetComponentInChildren<CapsuleCollider>(true).name).GetComponent<MeshRenderer>().material;
                }
            }
            Debug.Log("Yay we did it!");
            RemoveAll();
            GameObject particles = Instantiate(PlayerBody.localPlayer.stats.gotUpgradeParticlePrefab, levelParent.transform);
            particles.transform.position = this.transform.position;
            particles.transform.localScale = Vector3.one * 0.1f;

            Debug.Log("Yay we did it again!");

            LevelLoadButton[] buttons = FindObjectsOfType<LevelLoadButton>();
            foreach (LevelLoadButton button in buttons)
            {
                if (button != this) button.gameObject.SetActive(false);
            }

            Debug.Log("WE MADE IT TO THE END!!!");
        }

        public void UnloadBundle()
        {
            bundle.Unload(false);
            this.gameObject.SetActive(false);
        }


        public void RemoveIndividual(string objname)
        {
            if (GameObject.Find(objname)) GameObject.Find(objname).SetActive(false);
        }
        public void RemoveAll()
        {
            FindObjectOfType<OptionsController>().meshLightRays.GetComponent<MeshRenderer>().enabled = false;
            RemoveIndividual("tutorial parent");


            for (int i = 0; i < PlayerBody.localPlayer.respawning.respawnPoints.Length; i++) PlayerBody.localPlayer.respawning.respawnPoints[i] = new Vector3(0, 5000, 0);
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
            foreach (MovingPlatformScript m in movingPlatforms) m.gameObject.SetActive(false);

            MinibossActivater[] minibosses = GameObject.FindObjectsOfType<MinibossActivater>();
            foreach (MinibossActivater m in minibosses) m.gameObject.SetActive(false);

            GameObject[] tag = GameObject.FindGameObjectsWithTag("LaunchPad");
            foreach (GameObject tagged in tag) tagged.SetActive(false);

            ParticleSystem[] particless = GameObject.FindObjectsOfType<ParticleSystem>();
            foreach (ParticleSystem p in particless) if (p.transform.parent == null) p.gameObject.SetActive(false);

            MoveOverTime[] mov = GameObject.FindObjectsOfType<MoveOverTime>();
            foreach (MoveOverTime m in mov) if (m.transform.parent == null) m.gameObject.SetActive(false);

            SphereCollider[] spheres = GameObject.FindObjectsOfType<SphereCollider>();
            foreach (SphereCollider s in spheres) if (s.transform.parent == null && s.name.Contains("miniboss")) s.gameObject.SetActive(false);


        }

        public Vector3 ParseVector(string[] get, int a, int b, int c)
        {
            return new Vector3(parseFloat(get[a]), parseFloat(get[b]), parseFloat(get[c]));
        }

        public float parseFloat(string f)
        {
            return float.Parse(f, System.Globalization.NumberStyles.Float);
        }
    }
}
