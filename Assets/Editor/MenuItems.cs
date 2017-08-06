using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

public class MenuItems : Editor
{
    //Creates a "Create quest" button that calls CreateAsset function
    [MenuItem("QuestSystem/Create Quest")]
    public static void CreateQuestObject()
    {
        CreateAsset(typeof(Quest));
    }

    //Creates a "Create quest stage" button that calls CreateAsset function
    [MenuItem("QuestSystem/Create Quest Stage")]
    public static void CreateQuestStageObject()
    {
        CreateAsset(typeof(QuestStage));
    }

    //Creates the asset files
    private static void CreateAsset(System.Type type)
    {
        var asset = ScriptableObject.CreateInstance(type);
        string path = string.Empty;

        if(asset.GetType() == typeof(Quest))
        {
            path = AssetDatabase.GenerateUniqueAssetPath("Assets/Quest System/Quest" + "/New Quest" + ".asset");
        }
        else if(asset.GetType() == typeof(QuestStage))
        {
            path = AssetDatabase.GenerateUniqueAssetPath("Assets/Quest System/Quest Stage" + "/New Quest Stage" + ".asset");
        }
        
        if(path != string.Empty)
        {
            ProjectWindowUtil.CreateAsset(asset, path);
            Selection.activeObject = asset;
        }
        else
        {
            Debug.LogError("#Could not determine the type of asset class - @MenuItem");
        }
    }
}



//######### NOTES #############

//var asset = ScriptableObject.CreateInstance(type);
//string path = Application.dataPath + "/_Quests";
////string path = AssetDatabase.GetAssetPath(Selection.activeObject);
////if (path == "")
////{
////    path = "Assets";
////}
////else if (Path.GetExtension(path) != "")
////{
////    path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
////}
//string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/New " + type.ToString() + ".asset");
//AssetDatabase.CreateAsset(asset, assetPathAndName);
//AssetDatabase.SaveAssets();
//EditorUtility.FocusProjectWindow();
//Selection.activeObject = asset;