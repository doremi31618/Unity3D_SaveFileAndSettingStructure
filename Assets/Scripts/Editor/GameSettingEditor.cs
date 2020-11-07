using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(GameSettingManager)), CanEditMultipleObjects]
public class GameSettingEditor : Editor{
    public override void OnInspectorGUI(){
        base.OnInspectorGUI();
        GameSettingManager settingManager = (GameSettingManager)target;

        GUILayout.BeginVertical("Function");

        if(GUILayout.Button("Generate Game Setting")){
            settingManager.CreateGameSettingAsset();
        }

        if(GUILayout.Button("Export Game Setting")){
            settingManager.ExportCurrentGameSetting();
        }

        if(GUILayout.Button("Read Game Setting")){
            settingManager.ReadJsonFormatFile();
        }
        GUILayout.EndVertical(); 
    }
}