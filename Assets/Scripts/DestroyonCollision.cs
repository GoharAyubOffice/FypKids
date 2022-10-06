using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonCollision : MonoBehaviour
{
	[SerializeField] private int coinPoints;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Player")
		{
			CharacterSelection.numberOfCoins += coinPoints;
			PlayerPrefs.SetInt("Coins", CharacterSelection.numberOfCoins);
			Destroy(gameObject);
		}
	}
}
