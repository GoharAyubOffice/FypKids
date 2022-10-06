using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingManager : MonoBehaviour
{
    public static bool drawingAlphabet = false;
    [SerializeField] GameObject DrawingAlphabetGameObject;

    public static bool drawingNumbers = false;
    [SerializeField] GameObject DrawingNumbersGameObject;
    private void Start()
    {
        drawingAlphabet = (PlayerPrefs.GetInt("DrawingAlphabet") != 0);
        drawingNumbers = (PlayerPrefs.GetInt("DrawingNumbers") != 0);

        if (drawingAlphabet == true)
        {
            DrawingAlphabetGameObject.SetActive(true);
        }

        if (drawingNumbers == true)
        {
            DrawingNumbersGameObject.SetActive(true);
        }
    }
    public void FalseDrawing()
    {
        drawingAlphabet = false;
        PlayerPrefs.SetInt("DrawingAlphabet", (drawingAlphabet ? 1 : 0));

        drawingNumbers = false;
        PlayerPrefs.SetInt("DrawingNumbers", (drawingNumbers ? 1 : 0));
    }
    public void EnableAlphabetDrawing()
    {
        drawingAlphabet = true;
        PlayerPrefs.SetInt("DrawingAlphabet", (drawingAlphabet ? 1 : 0));
    }

    public void EnableNumbersDrawing()
    {
        drawingNumbers = true;
        PlayerPrefs.SetInt("DrawingNumbers", (drawingNumbers ? 1 : 0));
    }
}
