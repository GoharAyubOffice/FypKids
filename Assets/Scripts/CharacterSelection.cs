using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
	public GameObject[] characters;
	public int selectedCharacter = 0;

	public PlayersBlueprints[] player;
	public Button buyButton;
	public Button selectButton;

	public static int numberOfCoins;
	public TextMeshProUGUI coinsText;

	private void Start()
	{
		foreach (PlayersBlueprints players in player)
		{
			if (players.price == 0)
				players.isUnlocked = true;
			else
				players.isUnlocked = PlayerPrefs.GetInt(players.name, 0) == 0 ? false : true;
		}
	}
	private void Update()
	{
		coinsText.text = numberOfCoins.ToString();
		UpdatedUI();
	}
	public void NextCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter = (selectedCharacter + 1) % characters.Length;
		characters[selectedCharacter].SetActive(true);

		PlayersBlueprints p = player[selectedCharacter];
		if (!p.isUnlocked)
			return;
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
	}

	public void PreviousCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
		}
		characters[selectedCharacter].SetActive(true);

		PlayersBlueprints p = player[selectedCharacter];
		if (!p.isUnlocked)
			return;
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);

	}
	private void UpdatedUI()
	{
		PlayersBlueprints p = player[selectedCharacter];
		if (p.isUnlocked)
		{
			buyButton.gameObject.SetActive(false);
			selectButton.gameObject.SetActive(true);
		}
		else
		{
			selectButton.gameObject.SetActive(false);
			buyButton.gameObject.SetActive(true);
			buyButton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy :" + p.price;
			if (numberOfCoins >= p.price)
			{
				buyButton.interactable = true;
			}
			else
			{
				buyButton.interactable = false;
			}
		}
	}
	public void UnlockCharacter()
	{
		PlayersBlueprints p = player[selectedCharacter];
		PlayerPrefs.SetInt(p.name, 1);
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		p.isUnlocked = true;
		PlayerPrefs.SetInt("Coins", numberOfCoins - p.price);

	}
	

	public void SelectCharacterInLobby()
	{
	PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
	Destroy(GameObject.Find("DefaultCharacter"));
	}
}
