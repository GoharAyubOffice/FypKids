using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayFruitsounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip AppleSound;
    [SerializeField] AudioClip MangoSound;
    [SerializeField] AudioClip BananaSound;
    [SerializeField] AudioClip GrapesSound;
    [SerializeField] AudioClip OrangeSound;
    [SerializeField] AudioClip WaterMelonSound;
    [SerializeField] AudioClip PineAppleSound;
    [SerializeField] AudioClip FinishSound;

    [SerializeField] float endTimeofLevel;

    public static bool quizPanelFruit;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (FruitsManager.apple == true && audioSource.isPlaying == false)
        {
            Invoke("StartappleSound", 2f);
        }
        else if (FruitsManager.mango == true && audioSource.isPlaying == false)
        {
            Invoke("StartmangoSound", 2f);
        }
        else if (FruitsManager.banana == true && audioSource.isPlaying == false)
        {
            Invoke("StartbananaSound", 2f);
        }
        else if (FruitsManager.grapes == true && audioSource.isPlaying == false)
        {
            Invoke("StartgrapesSound", 2f);
        }
        else if (FruitsManager.orangefruit == true && audioSource.isPlaying == false)
        {
            Invoke("StartorangefruitSound", 2f);
        }
        else if (FruitsManager.waterMelon == true && audioSource.isPlaying == false)
        {
            Invoke("StartwaterMelonSound", 2f);
        }
        else if (FruitsManager.pineApple == true && audioSource.isPlaying == false)
        {
            Invoke("StartpineAppleSound", 2f);
        }
    }
    private void Update()
    {
        if (FruitsManager.apple == false && FruitsManager.mango == false && FruitsManager.banana == false && FruitsManager.grapes == false &&
            FruitsManager.orangefruit == false && FruitsManager.waterMelon == false && FruitsManager.pineApple == false && audioSource.isPlaying == false)
        {
            quizPanelFruit = true;
            PlayerPrefs.SetInt("EnableFruitQuiz", (quizPanelFruit ? 1 : 0));

            audioSource.clip = FinishSound;
            audioSource.Play();
            Invoke("FinishLevel", 5f);
        }
    }
    void FinishLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void StartappleSound()
    {
        audioSource.clip = AppleSound;
        audioSource.Play();
    }
    void StartmangoSound()
    {
        audioSource.clip = MangoSound;
        audioSource.Play();
    }
    void StartbananaSound()
    {
        audioSource.clip = BananaSound;
        audioSource.Play();
    }
    void StartgrapesSound()
    {
        audioSource.clip = GrapesSound;
        audioSource.Play();
    }
    void StartorangefruitSound()
    {
        audioSource.clip = OrangeSound;
        audioSource.Play();
    }
    void StartwaterMelonSound()
    {
        audioSource.clip = WaterMelonSound;
        audioSource.Play();
    }
    void StartpineAppleSound()
    {
        audioSource.clip = PineAppleSound;
        audioSource.Play();
    }
}
