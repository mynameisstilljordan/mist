using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Lofelt.NiceVibrations;

public class SettingsHandler : MonoBehaviour
{
    [SerializeField] Button sfxToggleButton;
    [SerializeField] Button vibrationToggleButton;
    [SerializeField] Button rainToggleButton;
    [SerializeField] Button mistToggleButton;
    [SerializeField] Sprite[] toggleImages;
    [SerializeField] Slider rainSlider; //the slider to control the rain
    [SerializeField] Slider mistSlider; //the slider to control the mist
    StaticVariableScript _sVC; //the static variable script reference

    // Start is called before the first frame update
    void Start()
    {
        _sVC = GameObject.FindGameObjectWithTag("GameController").GetComponent<StaticVariableScript>(); //get the instance of the script

        rainSlider.value = StaticVariableScript.rainValue;
        mistSlider.value = StaticVariableScript.mistValue;

        //Adds a listener to the main slider and invokes a method when the value changes.
        rainSlider.onValueChanged.AddListener(delegate { rainValueChanged(); });

        //Adds a listener to the main slider and invokes a method when the value changes.
        mistSlider.onValueChanged.AddListener(delegate { mistValueChanged(); });

        UpdateButtonOrientation(); //update orientation when scene starts
    }

    //when the back button is pressed
    public void OnBackButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        if (StaticVariableScript.previousScene != " ") SceneManager.LoadScene(sceneName: StaticVariableScript.previousScene); //if there was a previous scene, go to it
        else SceneManager.LoadScene(sceneName: "menu"); //if previous scene is empty, go to main menu
    }

    //when the sound effects button is pressed
    public void OnSFXButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        if (StaticVariableScript.isSFXEnabled == 0) StaticVariableScript.isSFXEnabled = 1;
        else StaticVariableScript.isSFXEnabled = 0;
        UpdateButtonOrientation();

        _sVC.UpdateVolume(StaticVariableScript.isSFXEnabled);
    }

    //when the music button is pressed
    public void OnVibrationButtonPressed()
    {
        if (!HapticController.hapticsEnabled) HapticController.hapticsEnabled = true;
        else HapticController.hapticsEnabled = false;
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        UpdateButtonOrientation();
    }

    //when the rain button is pressed
    public void OnRainToggleButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        if (StaticVariableScript.isRainEnabled == 0) StaticVariableScript.isRainEnabled = 1;
        else StaticVariableScript.isRainEnabled = 0;
        UpdateButtonOrientation();
    }

    //when the mist toggle is pressed
    public void OnMistToggleButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        if (StaticVariableScript.isMistEnabled == 0) StaticVariableScript.isMistEnabled = 1;
        else StaticVariableScript.isMistEnabled = 0;
        UpdateButtonOrientation();
    }

    //change orientation of buttons when pressed
    public void UpdateButtonOrientation()
    {
        //if the rain toggle button is enabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        if (StaticVariableScript.isRainEnabled == 1) {
            rainToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[1];
            rainSlider.interactable = true;
        }
        //if the rain toggle button is disabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        else {
            rainToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[0];
            rainSlider.interactable = false;
        }

        //if the mist toggle button is enabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        if (StaticVariableScript.isMistEnabled == 1) {
            mistToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[1];
            mistSlider.interactable = true;
        }
        //if the mist toggle button is disabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        else {
            mistToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[0];
            mistSlider.interactable = false;
        }

        //if the sfx toggle button is enabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        if (StaticVariableScript.isSFXEnabled == 1)
            sfxToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[1];
        //if the sfx toggle button is disabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        else 
            sfxToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[0];

        //if the music toggle button is enabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        if (HapticController.hapticsEnabled)
            vibrationToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[1];
        //if the music toggle button is disabled and the button's orientation isn't already reflecting this, multiply the x scale of the image by -1
        else 
            vibrationToggleButton.gameObject.GetComponent<Image>().sprite = toggleImages[0];

        StaticVariableScript.SaveVariables();
    }

    //this method is called everytime the slider value for rain is changed
    void rainValueChanged()
    {
        //update the saved value of the rain to current
        StaticVariableScript.rainValue = (int)rainSlider.value;
        PlayerPrefs.SetInt("RainValue", (int)rainSlider.value);
        StaticVariableScript.SaveVariables();
    }

    //this method is called everytime the slider value for rain is changed
    void mistValueChanged()
    {
        //update the saved value of the mist to current
        StaticVariableScript.mistValue = (int)mistSlider.value;
        PlayerPrefs.SetInt("MistValue", (int)mistSlider.value);
        StaticVariableScript.SaveVariables();
    }
}
