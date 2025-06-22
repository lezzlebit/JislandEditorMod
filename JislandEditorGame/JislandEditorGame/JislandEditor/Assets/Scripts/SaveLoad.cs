using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;
using UnityEngine.Events;

public class SaveLoad : MonoBehaviour
{
    public UnityEvent onSaveLevel;
    public UnityEvent onStartEditor;
    public UnityEvent onEndEditor;
    public GameObject[] prefabs;
    public RectTransform buttonParent;
    public RectTransform createParent;
    public TextMeshProUGUI levelEditing;
    public GameObject button;
    public GameObject createButton;
    public string LevelData = "";
    public string LevelName = "";
    public string CurrentLevel = "";
    public List<string> objects = new List<string>();
    int NewLevelID;
    public bool SavedLevel = true;

    private void Start()
    {
        LoadAll();
        foreach (GameObject o in prefabs)
        {
            MovableObject m = o.GetComponent<MovableObject>();
            objects.Add(m.GameName);
            CreateObjectButton b = Instantiate(createButton, createParent).GetComponent<CreateObjectButton>();
            b.text.text = m.GameName;
            b.prefab = o;
        }
    }

    public void SaveUi()
    {
        Application.OpenURL("file://" + Application.persistentDataPath);
        SaveAll();
    }
    public void SaveAll()
    {
        if (!SavedLevel) onSaveLevel.Invoke();
        LevelData = "";
        MovableObject[] objs = FindObjectsOfType<MovableObject>();
        for(int i = 0; i < objs.Length; i++)
        {
            MovableObject m = objs[i];
            Transform t = m.transform;
            string thisLine = $"{m.GameName},{VectorToString(t.position)},{VectorToString(t.eulerAngles)},{VectorToString(t.localScale)}";
            LevelData = LevelData + thisLine + "\n";
        }
        SavedLevel = true;
        File.WriteAllText(CurrentLevel, LevelData);
    }

    public void GoToSelection()
    {
        onEndEditor.Invoke();
        LoadAll();
    }

    public void LoadAll()
    {
        buttonParent.gameObject.SetActive(true);
        LoadLevelButton[] buttons = FindObjectsOfType<LoadLevelButton>();
        foreach(LoadLevelButton button in buttons) Destroy(button.gameObject);
        string[] files = Directory.GetFiles(Application.persistentDataPath);
        for (int i = 0; i < files.Length; i++)
        {
            if (Path.GetFileName(files[i]).Contains(".txt"))
            {
                LoadLevelButton b = Instantiate(button, buttonParent).GetComponent<LoadLevelButton>();
                b.name = files[i];
                b.text.text = Path.GetFileName(files[i]).Replace(".txt", "");
            }
        }
    }

    public void ClearAll()
    {
        MovableObject[] objects = FindObjectsOfType<MovableObject>();
        foreach (MovableObject o in objects) Destroy(o.gameObject);
    }

    public void LoadLevel()
    {
        ClearAll();
        string levelData = File.ReadAllText(CurrentLevel);
        string[] lines = levelData.Split('\n');

        
        for (int i = 0; i < lines.Length; i++)
        {
            string[] currentLine = lines[i].Split(',');
            if (currentLine.Length == 10)
            {
                GameObject prefab = Instantiate(prefabs[objects.IndexOf(currentLine[0])]);
                prefab.AddComponent<MeshCollider>().sharedMesh = prefab.GetComponent<MeshFilter>().sharedMesh;
                Vector3 position = ParseVector(currentLine, 1, 2, 3);
                Vector3 eulerAngles = ParseVector(currentLine, 4, 5, 6);
                Vector3 scale = ParseVector(currentLine, 7, 8, 9);
                prefab.transform.position = position;
                prefab.transform.eulerAngles = eulerAngles;
                prefab.transform.localScale = scale;
            }
        }
    }

    public Vector3 ParseVector(string[] get, int a, int b, int c)
    {
        return new Vector3(float.Parse(get[a]), float.Parse(get[b]), float.Parse(get[c]));
    }

    public string VectorToString(Vector3 v)
    {
        return $"{v.x},{v.y},{v.z}";
    }

    public void OpenDirectory()
    {
        Application.OpenURL("file://" + Application.persistentDataPath);
    }
    void Update()
    {
        string savedMarker = "";
        if (!SavedLevel) savedMarker = " *";
        levelEditing.text = LevelName + savedMarker;
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        {
            if (Input.GetKeyDown("s")) SaveAll();
            if (Input.GetKeyDown("l")) GoToSelection();
        }
    }

    public void NewLevel()
    {
        SavedLevel = false;
        ClearAll();
        onStartEditor.Invoke();
        buttonParent.gameObject.SetActive(false);
        for (int i = 0; i < 999; i++)
        {
            NewLevelID = i;
            if (!File.Exists(Application.persistentDataPath + $"/New Level ({NewLevelID}).txt")) i = 10000;
        }
        CurrentLevel = Application.persistentDataPath + $"/New Level ({NewLevelID}).txt";
        LevelName = $"New Level ({NewLevelID}).txt";
    }

    public void SetLevel(LoadLevelButton button)
    {
        SavedLevel = true;
        onStartEditor.Invoke();
        buttonParent.gameObject.SetActive(false);
        CurrentLevel = button.name;
        LoadLevel();
        LevelName = Path.GetFileName(CurrentLevel);
    }
}
