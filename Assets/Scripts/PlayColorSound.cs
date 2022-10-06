using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayColorSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip GreenSound;
    [SerializeField] AudioClip PinkSound;
    [SerializeField] AudioClip OrangeSound;
    [SerializeField] AudioClip RedSound;
    [SerializeField] AudioClip YellowSound;
    [SerializeField] AudioClip BlueSound;
    [SerializeField] AudioClip PurpleSound;
    [SerializeField] AudioClip FinishSound;

    [SerializeField] float endTimeofLevel;

    public static bool quizPanelColor;


    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (ColorManager.green == true && audioSource.isPlaying == false)
        {
            Invoke("StartgreenSound", 2f);
        }
        else if (ColorManager.pink == true && audioSource.isPlaying == false)
        {
            Invoke("StartpinkSound", 2f);
        }
        else if (ColorManager.orange == true && audioSource.isPlaying == false)
        {
            Invoke("StartorangeSound", 2f);
        }
        else if (ColorManager.red == true && audioSource.isPlaying == false)
        {
            Invoke("StartredSound", 2f);
        }
        else if (ColorManager.yellow == true && audioSource.isPlaying == false)
        {
            Invoke("StartyellowSound", 2f);
        }
        else if (ColorManager.blue == true && audioSource.isPlaying == false)
        {
            Invoke("StartblueSound", 2f);
        }
        else if (ColorManager.purple == true && audioSource.isPlaying == false)
        {
            Invoke("StartpurpleSound", 2f);
        }
    }
    private void Update()
    {
        if (ColorManager.green == false && ColorManager.pink == false && ColorManager.orange == false && ColorManager.red == false &&
            ColorManager.yellow == false && ColorManager.blue == false && ColorManager.purple == false && audioSource.isPlaying == false)
        {
            quizPanelColor = true;
            PlayerPrefs.SetInt("EnableColorQuiz", (quizPanelColor ? 1 : 0));

            audioSource.clip = FinishSound;
            audioSource.Play();
            Invoke("FinishLevel", 5f);
        }
    }
    void FinishLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void StartgreenSound()
    {
        audioSource.clip = GreenSound;
        audioSource.Play();
    }
    void StartpinkSound()
    {
        audioSource.clip = PinkSound;
        audioSource.Play();
    }
    void StartorangeSound()
    {
        audioSource.clip = OrangeSound;
        audioSource.Play();
    }
    void StartredSound()
    {
        audioSource.clip = RedSound;
        audioSource.Play();
    }
    void StartyellowSound()
    {
        audioSource.clip = YellowSound;
        audioSource.Play();
    }
    void StartblueSound()
    {
        audioSource.clip = BlueSound;
        audioSource.Play();
    }
    void StartpurpleSound()
    {
        audioSource.clip = PurpleSound;
        audioSource.Play();
    }
}
