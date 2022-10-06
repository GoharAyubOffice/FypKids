using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizmanager : MonoBehaviour
{
    public GameObject QuestionPanelAlphabet;
    public GameObject[] QuestionsAlphabets;

    public GameObject QuestionPanelShapes;
    public GameObject[] QuestionsShapes;

    public GameObject QuestionPanelColor;
    public GameObject[] QuestionsColor;

    public GameObject QuestionPanelFruit;
    public GameObject[] QuestionsFruit;

    int currentLevelAlphabets;

    int currentLevelShapes;

    int currentLevelColor;

    int currentLevelFruit;


    private void Start()
    {
        PlaySound.quizPanel = (PlayerPrefs.GetInt("EnableAlphabetsQuiz") != 0);

        PlayShapesSound.quizPanelShapes = (PlayerPrefs.GetInt("EnableShapesQuiz") != 0);

        PlayColorSound.quizPanelColor = (PlayerPrefs.GetInt("EnableColorQuiz") != 0);

        PlayFruitsounds.quizPanelFruit = (PlayerPrefs.GetInt("EnableFruitQuiz") != 0);


        if (PlaySound.quizPanel == true)
        {
            QuestionPanelAlphabet.SetActive(true);
        }

        if(PlayShapesSound.quizPanelShapes == true)
        {
            QuestionPanelShapes.SetActive(true);
        }

        if (PlayColorSound.quizPanelColor == true)
        {
            QuestionPanelColor.SetActive(true);
        }

        if (PlayFruitsounds.quizPanelFruit == true)
        {
            QuestionPanelFruit.SetActive(true);
        }
    }
    public void FalseQuizPanel()
    {
        PlaySound.quizPanel = false;
        PlayerPrefs.SetInt("EnableAlphabetsQuiz", (PlaySound.quizPanel ? 1 : 0));
        QuestionPanelAlphabet.SetActive(false);

        PlayShapesSound.quizPanelShapes = false;
        PlayerPrefs.SetInt("EnableShapesQuiz", (PlayShapesSound.quizPanelShapes ? 1 : 0));
        QuestionPanelShapes.SetActive(false);

        PlayColorSound.quizPanelColor = false;
        PlayerPrefs.SetInt("EnableColorQuiz", (PlayColorSound.quizPanelColor ? 1 : 0));
        QuestionPanelColor.SetActive(false);

        PlayFruitsounds.quizPanelFruit = false;
        PlayerPrefs.SetInt("EnableFruitQuiz", (PlayFruitsounds.quizPanelFruit ? 1 : 0));
        QuestionPanelFruit.SetActive(false);
    }
    public void CorrectanswerAlphabets()
    {
        if (currentLevelAlphabets + 1 != QuestionsAlphabets.Length)

        {
            QuestionsAlphabets[currentLevelAlphabets].SetActive(false);

            currentLevelAlphabets++;
            QuestionsAlphabets[currentLevelAlphabets].SetActive(true);
        }
    }
    public void CorrectanswerShapes()
    {
        if (currentLevelShapes + 1 != QuestionsShapes.Length)

        {
            QuestionsShapes[currentLevelShapes].SetActive(false);

            currentLevelShapes++;
            QuestionsShapes[currentLevelShapes].SetActive(true);
        }
    }
    public void CorrectanswerColor()
    {
        if (currentLevelColor + 1 != QuestionsColor.Length)

        {
            QuestionsColor[currentLevelColor].SetActive(false);

            currentLevelColor++;
            QuestionsColor[currentLevelColor].SetActive(true);
        }
    }
    public void CorrectanswerFruit()
    {
        if (currentLevelFruit + 1 != QuestionsFruit.Length)

        {
            QuestionsFruit[currentLevelFruit].SetActive(false);

            currentLevelFruit++;
            QuestionsFruit[currentLevelFruit].SetActive(true);
        }
    }
}
