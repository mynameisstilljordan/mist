using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using VoxelBusters.EssentialKit;

public class StaticVariableScript : MonoBehaviour
{
    public static int isRainEnabled;
    public static int isMistEnabled;
    public static int isSFXEnabled;
    public static int isVibrationEnabled;
    public static int rainValue;
    public static int mistValue;
    public static string previousScene;
    public static bool isIngameMenuActive;
    public static GameObject instance;

    AudioSource _audioSrc; //the audio source

    private void Awake() {
        DontDestroyOnLoad(this.gameObject); //dont destroy the gameobject on load
        if (instance == null) instance = this.gameObject; //if there isnt an existing instance of the gameobject
        else Destroy(this.gameObject); //destroy the gameobject
    }

    // Start is called before the first frame update
    void Start()
    {
        _audioSrc = GetComponent<AudioSource>(); //get the audio source component from the gameobject

        isRainEnabled = PlayerPrefs.GetInt("RainToggle", 1);
        isMistEnabled = PlayerPrefs.GetInt("MistToggle", 1);
        isSFXEnabled = PlayerPrefs.GetInt("SFXToggle", 1);
        isVibrationEnabled = PlayerPrefs.GetInt("VibrationToggle", 1);
        rainValue = PlayerPrefs.GetInt("RainValue", 500);
        mistValue = PlayerPrefs.GetInt("MistValue", 100);

        if (isSFXEnabled == 1) _audioSrc.volume = 1f; //if the volume is enabled, set it to max volume
        else _audioSrc.volume = 0f; //otherwise, set volume to 0
        _audioSrc.Play(); //play the audio
    }

    //method that saves all playerprefs
    public static void SaveVariables()
    {
        PlayerPrefs.SetInt("RainToggle", isRainEnabled);
        PlayerPrefs.SetInt("MistToggle", isMistEnabled);
        PlayerPrefs.SetInt("SFXToggle", isSFXEnabled);
        PlayerPrefs.SetInt("VibrationToggle", isVibrationEnabled);
        PlayerPrefs.SetInt("RainValue", rainValue);
        PlayerPrefs.SetInt("MistValue", mistValue);
    }

    public void UpdateVolume(float value) {
        _audioSrc.volume = value; //set the volume to the value
    }
}
