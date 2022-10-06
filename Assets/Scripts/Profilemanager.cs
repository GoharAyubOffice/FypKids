using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Profilemanager : MonoBehaviour
{
    public Text ShowProfileInSetting;
    public Text showinWelcome;

    public Text addUser;

    public Button addButton;

    public Text userText;

    public List<GameObject> MyProfiles = new List<GameObject>();

    public int counter = 0;

    [Header("ProfilesText")]
    public Text profile1Text;
    public GameObject profile1;
    public bool profile1state = false;

    public Text profile2Text;
    public GameObject profile2;
    public bool profile2state = false;

    public Text profile3Text;
    public GameObject profile3;
    public bool profile3state = false;

    public Text profile4Text;
    public GameObject profile4;
    public bool profile4state = false;

    public Text profile5Text;
    public GameObject profile5;
    public bool profile5state = false;

    public Text profile6Text;
    public GameObject profile6;
    public bool profile6state = false;

    public Text profile7Text;
    public GameObject profile7;
    public bool profile7state = false;

    public Text profile8Text;
    public GameObject profile8;
    public bool profile8state = false;

    public Text profile9Text;
    public GameObject profile9;
    public bool profile9state = false;

    public Text profile10Text;
    public GameObject profile10;
    public bool profile10state = false;


    private void Start()
    {
        profile1state = (PlayerPrefs.GetInt("EnableProfile1") != 0);
        profile2state = (PlayerPrefs.GetInt("EnableProfile2") != 0);
        profile3state = (PlayerPrefs.GetInt("EnableProfile3") != 0);
        profile4state = (PlayerPrefs.GetInt("EnableProfile4") != 0);
        profile5state = (PlayerPrefs.GetInt("EnableProfile5") != 0);
        profile6state = (PlayerPrefs.GetInt("EnableProfile6") != 0);
        profile7state = (PlayerPrefs.GetInt("EnableProfile7") != 0);
        profile8state = (PlayerPrefs.GetInt("EnableProfile8") != 0);
        profile9state = (PlayerPrefs.GetInt("EnableProfile9") != 0);
        profile10state = (PlayerPrefs.GetInt("EnableProfile10") != 0);

        if (profile1state == true)
        {
            profile1.SetActive(true);
            profile1Text.text = PlayerPrefs.GetString("Profile1Text");
        }
        else
        {
            profile1.SetActive(false);
        }

        if (profile2state == true)
        {
            profile2.SetActive(true);
            profile2Text.text = PlayerPrefs.GetString("Profile2Text");
        }
        else
        {
            profile2.SetActive(false);
        }

        if (profile3state == true)
        {
            profile3.SetActive(true);
            profile3Text.text = PlayerPrefs.GetString("Profile3Text");
        }
        else
        {
            profile3.SetActive(false);
        }

        if (profile4state == true)
        {
            profile4.SetActive(true);
            profile4Text.text = PlayerPrefs.GetString("Profile4Text");
        }
        else
        {
            profile4.SetActive(false);
        }

        if (profile5state == true)
        {
            profile5.SetActive(true);
            profile5Text.text = PlayerPrefs.GetString("Profile5Text");
        }
        else
        {
            profile5.SetActive(false);
        }

        if (profile6state == true)
        {
            profile6.SetActive(true);
            profile6Text.text = PlayerPrefs.GetString("Profile6Text");
        }
        else
        {
            profile6.SetActive(false);
        }

        if (profile7state == true)
        {
            profile7.SetActive(true);
            profile7Text.text = PlayerPrefs.GetString("Profile7Text");
        }
        else
        {
            profile7.SetActive(false);
        }

        if (profile8state == true)
        {
            profile8.SetActive(true);
            profile8Text.text = PlayerPrefs.GetString("Profile8Text");
        }
        else
        {
            profile8.SetActive(false);
        }

        if (profile9state == true)
        {
            profile9.SetActive(true);
            profile9Text.text = PlayerPrefs.GetString("Profile9Text");
        }
        else
        {
            profile9.SetActive(false);
        }

        if (profile10state == true)
        {
            profile10.SetActive(true);
            profile10Text.text = PlayerPrefs.GetString("Profile10Text");
        }
        else
        {
            profile10.SetActive(false);
        }
    }
    private void Update()
    {
        if (string.IsNullOrEmpty(userText.text))
        {
            Debug.Log("Field is Empty");
            addButton.interactable = false;
        }
        else
        {
            addButton.interactable = true;
        }

        profile1Text.text = GetComponent<Text>().text;
        profile2Text.text = GetComponent<Text>().text;
        profile3Text.text = GetComponent<Text>().text;
        profile4Text.text = GetComponent<Text>().text;
        profile5Text.text = GetComponent<Text>().text;
        profile6Text.text = GetComponent<Text>().text;
        profile7Text.text = GetComponent<Text>().text;
        profile8Text.text = GetComponent<Text>().text;
        profile9Text.text = GetComponent<Text>().text;
        profile10Text.text = GetComponent<Text>().text;
    }
    public void AddProfile()
    {
            MyProfiles[counter].GetComponent<ButtonInstanciate>().buttonText.text = addUser.text;
            MyProfiles[counter].SetActive(true);
            counter++;

            SaveUserData.guestUnlocked = true;
            PlayerPrefs.SetInt("guest", 1);
            PlayerPrefs.Save();
    }
    public void DeleteProfile1()
    {
        PlayerPrefs.DeleteKey("Profile1Text");

        profile1state = false;
        PlayerPrefs.SetInt("EnableProfile1", (profile1state ? 1 : 0));

        profile1.SetActive(false);
        counter--;
    }
    public void DeleteProfile2()
    {
        PlayerPrefs.DeleteKey("Profile2Text");

        profile2state = false;
        PlayerPrefs.SetInt("EnableProfile2", (profile2state ? 1 : 0));

        profile2.SetActive(false);
        counter--;
    }
    public void DeleteProfile3()
    {
        PlayerPrefs.DeleteKey("Profile3Text");

        profile3state = false;
        PlayerPrefs.SetInt("EnableProfile3", (profile3state ? 1 : 0));

        profile3.SetActive(false);
        counter--;
    }
    public void DeleteProfile4()
    {
        PlayerPrefs.DeleteKey("Profile4Text");

        profile4state = false;
        PlayerPrefs.SetInt("EnableProfile4", (profile4state ? 1 : 0));

        profile4.SetActive(false);
        counter--;
    }
    public void DeleteProfile5()
    {
        PlayerPrefs.DeleteKey("Profile5Text");

        profile5state = false;
        PlayerPrefs.SetInt("EnableProfile5", (profile5state ? 1 : 0));

        profile5.SetActive(false);
        counter--;
    }
    public void DeleteProfile6()
    {
        PlayerPrefs.DeleteKey("Profile6Text");

        profile6state = false;
        PlayerPrefs.SetInt("EnableProfile6", (profile6state ? 1 : 0));

        profile6.SetActive(false);
        counter--;
    }
    public void DeleteProfile7()
    {
        PlayerPrefs.DeleteKey("Profile7Text");

        profile7state = false;
        PlayerPrefs.SetInt("EnableProfile7", (profile7state ? 1 : 0));

        profile7.SetActive(false);
        counter--;
    }
    public void DeleteProfile8()
    {
        PlayerPrefs.DeleteKey("Profile8Text");

        profile8state = false;
        PlayerPrefs.SetInt("EnableProfile8", (profile8state ? 1 : 0));

        profile8.SetActive(false);
        counter--;
    }
    public void DeleteProfile9()
    {
        PlayerPrefs.DeleteKey("Profile9Text");

        profile9state = false;
        PlayerPrefs.SetInt("EnableProfile9", (profile9state ? 1 : 0));

        profile9.SetActive(false);
        counter--;
    }
    public void DeleteProfile10()
    {
        PlayerPrefs.DeleteKey("Profile10Text");

        profile10state = false;
        PlayerPrefs.SetInt("EnableProfile10", (profile10state ? 1 : 0));

        profile10.SetActive(false);
        counter--;
    }
    public void ShowProfile1()
    {
        ShowProfileInSetting.text = profile1Text.text;
        showinWelcome.text = profile1Text.text;

        profile1state = true;
        PlayerPrefs.SetInt("EnableProfile1", (profile1state ? 1 : 0));
        PlayerPrefs.SetString("Profile1Text",profile1Text.text);
    }
    public void ShowProfile2()
    {
        ShowProfileInSetting.text = profile2Text.text;
        showinWelcome.text = profile2Text.text;

        profile2state = true;
        PlayerPrefs.SetInt("EnableProfile2", (profile2state ? 1 : 0));
        PlayerPrefs.SetString("Profile2Text", profile2Text.text);
    }
    public void ShowProfile3()
    {
        ShowProfileInSetting.text = profile3Text.text;
        showinWelcome.text = profile3Text.text;

        profile3state = true;
        PlayerPrefs.SetInt("EnableProfile3", (profile3state ? 1 : 0));
        PlayerPrefs.SetString("Profile3Text", profile3Text.text);
    }
    public void ShowProfile4()
    {
        ShowProfileInSetting.text = profile4Text.text;
        showinWelcome.text = profile4Text.text;

        profile4state = true;
        PlayerPrefs.SetInt("EnableProfile4", (profile4state ? 1 : 0));
        PlayerPrefs.SetString("Profile4Text", profile4Text.text);
    }
    public void ShowProfile5()
    {
        ShowProfileInSetting.text = profile5Text.text;
        showinWelcome.text = profile5Text.text;

        profile5state = true;
        PlayerPrefs.SetInt("EnableProfile5", (profile5state ? 1 : 0));
        PlayerPrefs.SetString("Profile5Text", profile5Text.text);
    }
    public void ShowProfile6()
    {
        ShowProfileInSetting.text = profile6Text.text;
        showinWelcome.text = profile6Text.text;

        profile6state = true;
        PlayerPrefs.SetInt("EnableProfile6", (profile6state ? 1 : 0));
        PlayerPrefs.SetString("Profile6Text", profile6Text.text);
    }
    public void ShowProfile7()
    {
        ShowProfileInSetting.text = profile7Text.text;
        showinWelcome.text = profile7Text.text;

        profile7state = true;
        PlayerPrefs.SetInt("EnableProfile7", (profile7state ? 1 : 0));
        PlayerPrefs.SetString("Profile7Text", profile7Text.text);
    }
    public void ShowProfile8()
    {
        ShowProfileInSetting.text = profile8Text.text;
        showinWelcome.text = profile8Text.text;

        profile8state = true;
        PlayerPrefs.SetInt("EnableProfile8", (profile8state ? 1 : 0));
        PlayerPrefs.SetString("Profile8Text", profile8Text.text);
    }
    public void ShowProfile9()
    {
        ShowProfileInSetting.text = profile9Text.text;
        showinWelcome.text = profile9Text.text;

        profile9state = true;
        PlayerPrefs.SetInt("EnableProfile9", (profile9state ? 1 : 0));
        PlayerPrefs.SetString("Profile9Text", profile9Text.text);
    }
    public void ShowProfile10()
    {
        ShowProfileInSetting.text = profile10Text.text;
        showinWelcome.text = profile10Text.text;

        profile10state = true;
        PlayerPrefs.SetInt("EnableProfile10", (profile10state ? 1 : 0));
        PlayerPrefs.SetString("Profile10Text", profile10Text.text);
    }
}
