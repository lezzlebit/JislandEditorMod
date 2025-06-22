using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CopyFiles : MonoBehaviour
{
    [MenuItem("Jisland Editor/Copy Files")]
    static void CopyAllFiles()
    {
        string sourcePath = "C:\\git\\JislandEditor\\JislandEditorGame\\JislandEditor\\Assets\\!Assets\\3D";
        string targetPath = "C:\\git\\CoolJetIslandMod\\CoolModUnity\\Cool Jet Island Mod\\Assets\\!Assets\\Editor\\Copied";
        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
        {
            string fileName = Path.GetFileName(newPath);
            if (!fileName.Contains(".blend") && !fileName.Contains(".obj"))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
    }
}
