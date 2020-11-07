using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class JSONFileManager 
{
    public static void SaveToJSON(object target, string path){
        // deal with object to JSON
        string savingContent = JsonUtility.ToJson(target);

        // save JSON format content to File
        StreamWriter file = new StreamWriter(path);
        file.Write(savingContent);
        file.Close();

        Debug.Log("Save data to path : " + path);
        Debug.Log("Content" + savingContent);
    }

    //chose your own custom class to replace the setting
    public static Setting ReadFromJsonToSetting(string path){
        Setting content = new Setting();

        StreamReader file = File.OpenText(path);
        string file_content = file.ReadToEnd();
        content = JsonUtility.FromJson<Setting>(file_content);
        file.Close();

        Debug.Log("Read data from path : " + path);
        Debug.Log("Content" + file_content);
        return content;
    }
}
