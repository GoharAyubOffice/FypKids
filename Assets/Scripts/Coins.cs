using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
	[SerializeField] private int coinPoints;
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.tag == "Player")
		{
			CharacterSelection.numberOfCoins += coinPoints;
			PlayerPrefs.SetInt("Coins", CharacterSelection.numberOfCoins);
			Destroy(gameObject);
		}
	}
}
