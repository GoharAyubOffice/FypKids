using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountAmount : MonoBehaviour
{
    public Text count;
    public int countAmount = 0;
    public bool AlreadyClicked = false;

    public void ButtonClick()
    {
        if (AlreadyClicked == true)
        {
            ScoreManager.instance.ReduceScore(); // reduce score!!
        }
        else
        {
            ScoreManager.instance.AddScore(); // add score
        }
        AlreadyClicked = !AlreadyClicked;
    }
}
