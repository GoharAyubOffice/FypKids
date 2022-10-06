using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayShapesSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip CircleSound;
    [SerializeField] AudioClip SquareSound;
    [SerializeField] AudioClip TriangleSound;
    [SerializeField] AudioClip RectangleSound;
    [SerializeField] AudioClip ConeeSound;
    [SerializeField] AudioClip DiomandSound;
    [SerializeField] AudioClip PentagonalSound;
    [SerializeField] AudioClip HexagonalSound;
    [SerializeField] AudioClip OvalSound;
    [SerializeField] AudioClip FinishSound;

    public static bool quizPanelShapes;


    [SerializeField] float endTimeofLevel;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (ShapesManager.circle == true && audioSource.isPlaying == false)
        {
            Invoke("StartcircleSound", 2f);
        }
        else if (ShapesManager.sqaure == true && audioSource.isPlaying == false)
        {
            Invoke("StartsqaureSound", 2f);
        }
        else if (ShapesManager.triangle == true && audioSource.isPlaying == false)
        {
            Invoke("StarttriangleSound", 2f);
        }
        else if (ShapesManager.rectangle == true && audioSource.isPlaying == false)
        {
            Invoke("StartrectangleSound", 2f);
        }
        else if (ShapesManager.conee == true && audioSource.isPlaying == false)
        {
            Invoke("StartconeeSound", 2f);
        }
        else if (ShapesManager.diomand == true && audioSource.isPlaying == false)
        {
            Invoke("StartdiomandSound", 2f);
        }
        else if (ShapesManager.pentagonal == true && audioSource.isPlaying == false)
        {
            Invoke("StartpentagonalSound", 2f);
        }
        else if (ShapesManager.hexagonal == true && audioSource.isPlaying == false)
        {
            Invoke("StarthexagonalSound", 2f);
        }
        else if (ShapesManager.oval == true && audioSource.isPlaying == false)
        {
            Invoke("StartovalSound", 2f);
        }
    }
    private void Update()
    {
        if (ShapesManager.circle == false && ShapesManager.sqaure == false && ShapesManager.triangle == false && ShapesManager.rectangle == false &&
            ShapesManager.conee == false && ShapesManager.diomand == false && ShapesManager.pentagonal == false && ShapesManager.hexagonal == false &&
            ShapesManager.oval == false && audioSource.isPlaying == false)
        {
            quizPanelShapes = true;
            PlayerPrefs.SetInt("EnableShapesQuiz", (quizPanelShapes ? 1 : 0));
            audioSource.clip = FinishSound;
            audioSource.Play();
            Invoke("FinishLevel", 5f);
        }
    }
    void FinishLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void StartcircleSound()
    {
        audioSource.clip = CircleSound;
        audioSource.Play();
    }
    void StartsqaureSound()
    {
        audioSource.clip = SquareSound;
        audioSource.Play();
    }
    void StarttriangleSound()
    {
        audioSource.clip = TriangleSound;
        audioSource.Play();
    }
    void StartrectangleSound()
    {
        audioSource.clip = RectangleSound;
        audioSource.Play();
    }
    void StartconeeSound()
    {
        audioSource.clip = ConeeSound;
        audioSource.Play();
    }
    void StartdiomandSound()
    {
        audioSource.clip = DiomandSound;
        audioSource.Play();
    }
    void StartpentagonalSound()
    {
        audioSource.clip = PentagonalSound;
        audioSource.Play();
    }
    void StarthexagonalSound()
    {
        audioSource.clip = HexagonalSound;
        audioSource.Play();
    }
    void StartovalSound()
    {
        audioSource.clip = OvalSound;
        audioSource.Play();
    }
}
