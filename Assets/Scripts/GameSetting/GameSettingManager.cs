using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameSettingManager : MonoBehaviour
{
    public string fileName="GameSetting.json";
    public string json_file_read_path;
    public string json_file_export_path;
    public GameSetting SettingData;
    
    //create a new one
    public void CreateGameSettingAsset(){

        if(SettingData ==null){
            SettingData = new GameSetting();
            AssetDatabase.CreateAsset(SettingData, "Assets/NewGameSetting.asset");
            Debug.Log("Create Game Setting (Path : " + AssetDatabase.GetAssetPath(SettingData));
        }
        else {
            Debug.Log("Already have one");
        }

    }

    //export current setting data to json file format 
    public void ExportCurrentGameSetting(){
        //check if file exist json_file_export_path
        string FilePath;
        if(json_file_export_path == ""){
            json_file_export_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FilePath = json_file_export_path+"/"+fileName;
        }else{
            FilePath = json_file_export_path+"/"+fileName;
        }

        //save to file
        JSONFileManager.SaveToJSON(SettingData.settingData, FilePath);
    }

    public void ReadJsonFormatFile(){
        string FilePath;
        if(json_file_read_path == ""){
            json_file_read_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FilePath = json_file_read_path+"/"+fileName;
        }else{
            FilePath = json_file_read_path+"/"+fileName;
        }

        //read file 
        if(SettingData == null)SettingData = new GameSetting();
        SettingData.settingData = JSONFileManager.ReadFromJsonToSetting(FilePath);
    }

}
