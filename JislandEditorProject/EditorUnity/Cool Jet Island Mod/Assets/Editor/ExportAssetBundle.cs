using System.IO;
using UnityEditor;
using UnityEngine;
public class ExportAssetBundle
{
    [MenuItem("Jisland Editor/Build AssetBundle")]
    static void ExportResource()
    {
        string folderName = "AssetBundles";
        string filePath = Path.Combine(Application.streamingAssetsPath, folderName);
        BuildPipeline.BuildAssetBundles(filePath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        AssetDatabase.Refresh();
        string newPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Jet Island\\JetIsland_Data\\StreamingAssets\\jislandeditor.unity3d";
        if (File.Exists(newPath)) File.Delete(newPath);
        File.Copy("C:\\git\\CoolJetIslandMod\\CoolModUnity\\Cool Jet Island Mod\\Assets\\StreamingAssets\\AssetBundles\\jislandeditor.unity3d", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Jet Island\\JetIsland_Data\\StreamingAssets\\jislandeditor.unity3d");
    }
}