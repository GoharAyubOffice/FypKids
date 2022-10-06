using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizController : MonoBehaviour
{
	public GameObject[] alphabets;
    public int selectedAlphabet = 0;

	public GameObject[] numbers;
	public int selectedNumbers = 0;

	public void NextAlphabet()
	{
		alphabets[selectedAlphabet].SetActive(false);
		selectedAlphabet = (selectedAlphabet + 1) % alphabets.Length;
		alphabets[selectedAlphabet].SetActive(true);
	}

	public void PreviousAlphabet()
	{
		alphabets[selectedAlphabet].SetActive(false);
		selectedAlphabet--;
		if (selectedAlphabet < 0)
		{
			selectedAlphabet += alphabets.Length;
		}
		alphabets[selectedAlphabet].SetActive(true);
	}

	public void NextNumbers()
	{
		numbers[selectedNumbers].SetActive(false);
		selectedNumbers = (selectedNumbers + 1) % numbers.Length;
		numbers[selectedNumbers].SetActive(true);
	}

	public void PreviousNumber()
	{
		numbers[selectedNumbers].SetActive(false);
		selectedNumbers--;
		if (selectedNumbers < 0)
		{
			selectedNumbers += numbers.Length;
		}
		numbers[selectedNumbers].SetActive(true);
	}
}
