using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleScript : MonoBehaviour
{
    //the amount of rain particles allowed at once (10-1000)
    public static float rainValue;
    //the speed of the mist (0.1-10)
    public static float mistValue;
    public ParticleSystem rainParticles;
    public ParticleSystem mistParticles;
    public Color32 myColor;

    // Start is called before the first frame update
    void Start()
    {
        if (StaticVariableScript.isRainEnabled == 1) rainValue = StaticVariableScript.rainValue;
        if (StaticVariableScript.isMistEnabled == 1) mistValue = StaticVariableScript.mistValue;
        myColor = new Color32(90, 90, 90, (byte)mistValue);
    }

    // Update is called once per frame
    void Update()
    {
        //myColor.a = (byte)mistValue;
        myColor = new Color32(90, 90, 90, (byte)StaticVariableScript.mistValue);

        if (StaticVariableScript.isRainEnabled == 1) rainParticles.maxParticles = (int)StaticVariableScript.rainValue; //if the rain button is enabled, go to slider value
        else rainParticles.maxParticles = 0; //if the rain button is disabled

        if (StaticVariableScript.isMistEnabled == 1) //if the mist button is enabled, go to slider value
        {
            if (mistParticles.emission.enabled == false) mistParticles.enableEmission = true;
            mistParticles.startColor = myColor;
        }
        else //if the mist is disabled
        {
            if (mistParticles.emission.enabled == true) mistParticles.enableEmission = false;
        }
    }
}
