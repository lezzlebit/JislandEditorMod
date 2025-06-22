using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RenamePrefabs
{
    [MenuItem("Jisland Editor/Rename Prefabs")]
    static void RenameAll()
    {
        MeshFilter[] filters = GameObject.FindObjectsOfType<MeshFilter>();
        foreach(MeshFilter filter in filters)
        {
            filter.gameObject.name = filter.sharedMesh.name;
        }
    }
}
