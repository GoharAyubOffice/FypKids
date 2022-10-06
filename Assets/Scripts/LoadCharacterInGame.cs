using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadCharacterInGame : MonoBehaviour
{
	public GameObject[] characterPrefabs;
	public Transform spawnPoint;

	public TextMeshProUGUI coinsText;

	private void Update()
	{
		coinsText.text = CharacterSelection.numberOfCoins.ToString();
	}
	private void Start()
	{
		int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
		GameObject prefab = characterPrefabs[selectedCharacter];
		GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
	}
}
