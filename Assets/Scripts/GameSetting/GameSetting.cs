using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Setting{
    public string SettingName = "Default Setting";
    public int WeakEyeMode = 0; // 0 : left eye ; 1 : right eye
    public float fadingTime = 25;
    

}

[CreateAssetMenu(fileName = "New Game Setting", menuName = "GameSetting/Create new GameSetting", order = 1)]
public class GameSetting : ScriptableObject
{
    public Setting settingData;
    public AnimationCurve curve = AnimationCurve.Linear(0,0,1,1);
    
}
