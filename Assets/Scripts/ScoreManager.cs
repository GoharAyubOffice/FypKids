using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public Text ScoreTextABC;
    public Text ScoreTextShapes;

    void Awake() => instance = this;

    public void AddScore()
    {
        score++;
        ScoreTextABC.text = score.ToString();
        ScoreTextShapes.text = score.ToString();
    }

    public void ReduceScore()
    {
        score--;
        ScoreTextABC.text = score.ToString();
        ScoreTextShapes.text = score.ToString();
    }
}
