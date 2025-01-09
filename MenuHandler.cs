using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Lofelt.NiceVibrations;

public class MenuHandler : MonoBehaviour
{
    //when the start button is pressed
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(sceneName: "ingame");
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
    }
     
    //when the settings button is pressed
    public void OnSettingsButtonPressed()
    {
        SceneManager.LoadScene(sceneName: "settings");
        StaticVariableScript.previousScene = "menu";
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
    }

    //when the remove ads button is pressed
    public void OnRemoveAdsButtonPressed() {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
    }
}
