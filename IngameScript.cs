using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Lofelt.NiceVibrations;
//using MoreMountains.Feedbacks;

public class IngameScript : MonoBehaviour
{
    int currentThought = 0; //current thought
    int currentFavoriteThought = 1;
    int numberOfThoughts = 0; //the total number of thoughts
    [SerializeField] TMP_Text thoughtHeader;
    [SerializeField] TMP_Text thoughtBody;
    [SerializeField] TMP_Text favoriteThoughtSubheader;
    [SerializeField] Canvas menuCanvas;
    [SerializeField] Button favoriteButton, randomButton;
    [SerializeField] Sprite[] images;
    [SerializeField] TMP_Text favoritesButtonLabel;
    [SerializeField] Button favoritesToggleButton;
    [SerializeField] Sprite[] favoritesToggleButtonImages;
    bool isFavoritesMenuEnabled;
    ThoughtHolderScript tH; //thought holder
    TextEditor tE;

    private void Awake() {
        isFavoritesMenuEnabled = PlayerPrefsX.GetBool("FavoritesEnabled", false); //favorites menu playerpref
        currentThought = PlayerPrefs.GetInt("currentThought", 0);
        currentFavoriteThought = PlayerPrefs.GetInt("currentFavoriteThought", 1); //save the playerpref 
    }

    // Start is called before the first frame update
    void Start()
    {
        tE = new TextEditor(); //text editor
        tH = GameObject.FindGameObjectWithTag("ThoughtHolder").GetComponent<ThoughtHolderScript>();
        StaticVariableScript.isIngameMenuActive = false;
        if (isFavoritesMenuEnabled) {
            favoritesButtonLabel.text = "SAVED";
            favoritesToggleButton.image.sprite = favoritesToggleButtonImages[1];
        }
        else {
            favoritesButtonLabel.text = "ALL";
            favoritesToggleButton.image.sprite = favoritesToggleButtonImages[0];
        }
        Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM,BannerType.Adaptive); //show banner
    } 

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A)) Debug.Log(tH.FindFavoriteThoughtIndexNumber(currentFavoriteThought)+" "+ tH.NumberOfFavoriteThoughts());

        if (Input.GetKeyDown(KeyCode.A)) Debug.Log("currentThought: " + currentThought + " currentFavoriteThought: " + currentFavoriteThought + "THcurrentFavoriteThought: "+ tH.FindFavoriteThoughtIndexNumber(currentFavoriteThought));

        if (!isFavoritesMenuEnabled)
        {
            if (currentThought != 0)
            {
                //save variable to the total number of thoughts 
                numberOfThoughts = tH.NumberOfThoughts() - 1;
                //displayer when favorites mode is off
                thoughtHeader.text = "THOUGHT #" + currentThought; //display the current thought number
                thoughtBody.text = tH.GetThought(currentThought);
                favoriteThoughtSubheader.text = "";
                //changing the favorite button depending on if the thought is favorited
                if (tH.IsThoughtAlreadyFavorited(currentThought))
                    favoriteButton.image.sprite = images[1];
                else favoriteButton.image.sprite = images[0];
            }
            //if the current thought is 0, display the introduction screen
            else
            {
                //save variable to the total number of thoughts 
                numberOfThoughts = tH.NumberOfThoughts() - 1;
                thoughtHeader.text = "INTRODUCTION";
                thoughtBody.text = tH.GetThought(currentThought);
                favoriteThoughtSubheader.text = "";
                //changing the favorite button depending on if the thought is favorited
                if (tH.IsThoughtAlreadyFavorited(currentThought))
                    favoriteButton.image.sprite = images[1];
                else favoriteButton.image.sprite = images[0];
            }
        }

        else
        {
            
            //if there is atleast 1 saved thought
            if (tH.favoriteThought[0] != 0)
            {
                //displayer when favorites mode is on
                thoughtHeader.text = "FAVORITE #" + tH.FindFavoriteThoughtIndexNumber(currentFavoriteThought); //display the current thought number
                thoughtBody.text = tH.GetThought(currentFavoriteThought);
                favoriteThoughtSubheader.text = "THOUGHT #" + currentFavoriteThought;
                //changing the favorite button depending on if the thought is favorited
                if (tH.IsThoughtAlreadyFavorited(currentFavoriteThought))
                    favoriteButton.image.sprite = images[1];
                else favoriteButton.image.sprite = images[0];
            }
            else
            {
                //if there are no saved thoughts, display message for user
                thoughtHeader.text = "NO SAVED\nTHOUGHTS";
                thoughtBody.text = "Please add a thought to favorites by pressing the star in the bottom right";
                favoriteThoughtSubheader.text = "";
            }
        }
        
        if (StaticVariableScript.isIngameMenuActive) menuCanvas.enabled = true; //if the menu is enabled, display it
        else menuCanvas.enabled = false; //if the menu is disabled, dont display it
    }
    
    //this method activates favorites mode
    public void ActivateFavoritesMode()
    {
        favoritesButtonLabel.text = "SAVED";
        favoritesToggleButton.image.sprite = favoritesToggleButtonImages[1];
        isFavoritesMenuEnabled = true;
        PlayerPrefsX.SetBool("FavoritesEnabled", isFavoritesMenuEnabled); //favorites menu playerpref
    }
    //this method deactivates favorites mode
    public void DeactivateFavoritesMode()
    {
        favoritesButtonLabel.text = "ALL";
        favoritesToggleButton.image.sprite = favoritesToggleButtonImages[0];
        isFavoritesMenuEnabled = false;
        PlayerPrefsX.SetBool("FavoritesEnabled", isFavoritesMenuEnabled); //favorites menu playerpref
    }
    //when the favorite button is pressed
    public void OnFavoriteButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        //if not in saved thoughts mode
        if (!isFavoritesMenuEnabled)
        {
            if (!tH.IsThoughtAlreadyFavorited(currentThought))
            {
                tH.AddThoughtToFavorites(currentThought);
            }
            else
            {
                tH.RemoveThoughtFromFavorites(currentThought);
            }
        }
        //if in saved thoughts mode
        else
        {
            //this should always be true if favorites mode is on
            if (tH.IsThoughtAlreadyFavorited(currentFavoriteThought))
            {
                int tempThoughtNum = currentFavoriteThought; //save thought in variable to remember it after stepping forward
                currentFavoriteThought = tH.StepForward(tempThoughtNum); //step forward to next thought 
                tH.RemoveThoughtFromFavorites(tempThoughtNum); //delete saved thought
            }
        }
        tH.UpdateFavoritesList();
    }
    //when the enable favorite thought button is pressed
    public void OnFavoritesButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        
        if (!isFavoritesMenuEnabled)
            ActivateFavoritesMode();
        else DeactivateFavoritesMode();
        
        StaticVariableScript.isIngameMenuActive = false;

        if (tH.NumberOfFavoriteThoughts() == 1) currentFavoriteThought = tH.favoriteThought[0];
    }
    //when the right button is pressed
    public void OnRightButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        if (!isFavoritesMenuEnabled)
        {
            //if the current thought is less than the total number of thoughts
            if (currentThought < numberOfThoughts) currentThought++; //increment thought
            else if (currentThought == numberOfThoughts) currentThought = 1; //loop thoughts if going forwards
            PlayerPrefs.SetInt("currentThought", currentThought); //save the playerpref 
        }
        else
        {
            //if the current favorite thought is less than the total number of favorite thoughts
            currentFavoriteThought = tH.StepForward(currentFavoriteThought);
            PlayerPrefs.SetInt("currentFavoriteThought", currentFavoriteThought); //save the playerpref 
        }
    }
    //when the left button is pressed
    public void OnLeftButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        if (!isFavoritesMenuEnabled)
        {
            if (currentThought > 1) currentThought--; //decrement thought 
            else if (currentThought == 1) currentThought = numberOfThoughts; //loop thoughts if going backwards
            PlayerPrefs.SetInt("currentThought", currentThought); //saave the playerpref 
        }
        else
        {
            //if the current thought isnt the first index on the list
            currentFavoriteThought = tH.StepBack(currentFavoriteThought);
            PlayerPrefs.SetInt("currentFavoriteThought", currentFavoriteThought); //save the playerpref 
        }
    }
    //when the random button is pressed
    public void OnRandomButtonPressed()
    {
        if (!isFavoritesMenuEnabled) {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
            int newThought = currentThought;
            while (newThought == currentThought) { //while the new thought is equal to the current, switch
                newThought = Random.Range(1, (numberOfThoughts + 1));
                if (newThought != currentThought) break; //if a new number is found, break
            }
            currentThought = newThought; //go to the new found thought
            PlayerPrefs.SetInt("currentThought", newThought); //save the playerpref of the current thought
        }
        //if in favorites mode
        else {
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
            if (tH.NumberOfFavoriteThoughts() > 1) { //if there are atleast two favorite thoughts
                int newThought = tH.favoriteThought[Random.Range(0, tH.NumberOfFavoriteThoughts())]; //set the new thought to a random thought in the favorites array
                while (newThought == currentFavoriteThought) { //while the new thought is equal to the current, switch
                    newThought = tH.favoriteThought[Random.Range(0, tH.NumberOfFavoriteThoughts())]; //set the new thought to a random thought in the favorites array
                    if (newThought != currentFavoriteThought) {
                        break; //if a new number is found, break
                    }
                }
                currentFavoriteThought = newThought; //go to the new found thought
                PlayerPrefs.SetInt("currentFavoriteThought", currentFavoriteThought); //save the playerpref 
            }
        }
    }

    //when the menu button is pressed
    public void OnMenuButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        StaticVariableScript.isIngameMenuActive = true;
    }
    //when the back button (on menu) is pressed
    public void OnBackButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        StaticVariableScript.isIngameMenuActive = false;
    }
    //when the settings button is pressed
    public void OnSettingsButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        SceneManager.LoadScene(sceneName: "settings");
        StaticVariableScript.previousScene = "ingame";
        Advertisements.Instance.HideBanner(); //hide banner
    }
    //when the home button is pressed
    public void OnHomeButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        //go to the main menu scene
        SceneManager.LoadScene(sceneName: "menu");
        StaticVariableScript.isIngameMenuActive = false;
        Advertisements.Instance.HideBanner(); //hide banner
    }
    //when the share button is pressed
    public void OnCopyButtonPressed()
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact); //light haptic effect
        tE.text = thoughtBody.text; //set the text to be copied
        tE.SelectAll(); //select the text
        tE.Copy(); //copy the text
    }
}
