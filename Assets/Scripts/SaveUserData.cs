using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveUserData : MonoBehaviour
{
	[Header("Show Names in Profile")]
	public Text showinGuestProfile;

	[Header("Show in Welcome")]
	public Text showinWelcome;
	[Header("Show in Setting")]
	public Text showinSetting;

	[Header("Guest Name")]
	public string guestText = "Guest";

	[Header("UnlockProfileStates")]

	public static bool guestUnlocked = false;

	private void Start()
	{
		int state = PlayerPrefs.GetInt("guest", 0);

		if (state == 0)
		{
			guestUnlocked = false;
			showinWelcome.text = guestText.ToString();
			showinGuestProfile.text = guestText.ToString();
		}
		else
		{
			showinGuestProfile.text = guestText.ToString();
			showinWelcome.text = PlayerPrefs.GetString("recentSave");
		}
	}
	public void LoadGuest()
	{
		showinWelcome.text = guestText.ToString();
		showinSetting.text = guestText.ToString();
	}
}

