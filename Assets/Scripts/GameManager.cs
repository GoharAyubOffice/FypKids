using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
	[Header("Text of MainMenu Selected Profile")]
	public Text mainMenuSelectedProfile;

	[Header("Text of Recent Selected Profile")]
	public Text recentSelectedProfile;

	[Header("Show in Settings")]
	public Text showInSetting;

	[Header("Coins")]
	public TextMeshProUGUI coinsText;

	[Header("Alphabet To Enable")]
	public static bool alphabetGameOject;

	[Header("Numbers To Enable")]
	public static bool numbersGameOject;

	[Header("Shapes To Enable")]
	public static bool shapesGameOject;

	[Header("Color To Enable")]
	public static bool colorGameOject;

	[Header("Fruit To Enable")]
	public static bool fruitGameOject;

	[Header("Animals To Enable")]
	public static bool animalGameOject;

	[Header("Birds To Enable")]
	public static bool birdsGameOject;

	private void Start()
    {
		showInSetting.text = recentSelectedProfile.text;

		alphabetGameOject = false;
		PlayerPrefs.SetInt("EnableAlphabets", (alphabetGameOject ? 1 : 0));

		numbersGameOject = false;
		PlayerPrefs.SetInt("EnableNumbers", (numbersGameOject ? 1 : 0));

		shapesGameOject = false;
		PlayerPrefs.SetInt("EnableShapes", (shapesGameOject ? 1 : 0));

		colorGameOject = false;
		PlayerPrefs.SetInt("EnableColor", (colorGameOject ? 1 : 0));

		fruitGameOject = false;
		PlayerPrefs.SetInt("EnableFruit", (fruitGameOject ? 1 : 0));

		animalGameOject = false;
		PlayerPrefs.SetInt("EnableAnimals", (animalGameOject ? 1 : 0));

		birdsGameOject = false;
		PlayerPrefs.SetInt("EnableBirds", (birdsGameOject ? 1 : 0));

		DrawingManager.drawingAlphabet = false;
		PlayerPrefs.SetInt("DrawingAlphabet", (DrawingManager.drawingAlphabet ? 1 : 0));

		DrawingManager.drawingNumbers = false;
		PlayerPrefs.SetInt("DrawingNumbers", (DrawingManager.drawingNumbers ? 1 : 0));
	}
	private void Update()
	{
		CharacterSelection.numberOfCoins = PlayerPrefs.GetInt("Coins", 0);
		coinsText.text = CharacterSelection.numberOfCoins.ToString();
	}
	public void StartGame()
	{
		PlayerPrefs.SetString("mainMenuSelectedprofile", mainMenuSelectedProfile.text);
		PlayerPrefs.SetString("recentSave", recentSelectedProfile.text);
		SceneManager.LoadScene("Game");
	}
	public void StartQuiz()
	{
		SceneManager.LoadScene("Quiz");
	}
	public void EnableAlphabets()
	{
		alphabetGameOject = true;
		PlayerPrefs.SetInt("EnableAlphabets", (alphabetGameOject ? 1 : 0));
	}
	public void EnableNumbers()
	{
		numbersGameOject = true;
		PlayerPrefs.SetInt("EnableNumbers", (numbersGameOject ? 1 : 0));
	}
	public void EnableShapes()
	{
		shapesGameOject = true;
		PlayerPrefs.SetInt("EnableShapes", (shapesGameOject ? 1 : 0));
	}
	public void EnableColors()
	{
		colorGameOject = true;
		PlayerPrefs.SetInt("EnableColor", (colorGameOject ? 1 : 0));
	}
	public void EnableFruit()
	{
		fruitGameOject = true;
		PlayerPrefs.SetInt("EnableFruit", (fruitGameOject ? 1 : 0));
	}
	public void EnableAnimals()
	{
		animalGameOject = true;
		PlayerPrefs.SetInt("EnableAnimals", (animalGameOject ? 1 : 0));
	}
	public void EnableBirds()
	{
		birdsGameOject = true;
		PlayerPrefs.SetInt("EnableBirds", (birdsGameOject ? 1 : 0));
	}
	public void QuitGame()
	{
		PlayerPrefs.SetString("recentSave", recentSelectedProfile.text);
		PlayerPrefs.Save();
		Debug.Log("Saved user Name is " + PlayerPrefs.GetString("recentSave"));

		PlaySound.quizPanel = false;
		PlayerPrefs.SetInt("EnableAlphabetsQuiz", (PlaySound.quizPanel ? 1 : 0));

		PlayShapesSound.quizPanelShapes = false;
		PlayerPrefs.SetInt("EnableShapesQuiz", (PlayShapesSound.quizPanelShapes ? 1 : 0));

		AlphabetsManager.DeleteAlphabetBool();
		NumbersManager.DeleteNumbersBool();
		ShapesManager.DeleteShapesBool();
		ColorManager.DeleteColorBool();
		FruitsManager.DeleteFruitBool();
		AnimalsManager.DeleteAnimalBool();
		BirdsManager.DeleteBirdsBool();

		Application.Quit();
	}
    private void OnApplicationQuit()
    {
		AlphabetsManager.DeleteAlphabetBool();
		NumbersManager.DeleteNumbersBool();
		ShapesManager.DeleteShapesBool();
		ColorManager.DeleteColorBool();
		FruitsManager.DeleteFruitBool();
		AnimalsManager.DeleteAnimalBool();
		BirdsManager.DeleteBirdsBool();

		PlaySound.quizPanel = false;
		PlayerPrefs.SetInt("EnableAlphabetsQuiz", (PlaySound.quizPanel ? 1 : 0));

		PlayShapesSound.quizPanelShapes = false;
		PlayerPrefs.SetInt("EnableShapesQuiz", (PlayShapesSound.quizPanelShapes ? 1 : 0));

		PlayerPrefs.SetString("recentSave", recentSelectedProfile.text);
		PlayerPrefs.Save();
		Debug.Log("Saved user Name is " + PlayerPrefs.GetString("recentSave"));
	}
}
