using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAnimalsSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip CatSound;
    [SerializeField] AudioClip MonkeySound;
    [SerializeField] AudioClip FishSound;
    [SerializeField] AudioClip HorseSound;
    [SerializeField] AudioClip DeerSound;
    [SerializeField] AudioClip LionSound;
    [SerializeField] AudioClip FinishSound;

    [SerializeField] float endTimeofLevel;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (AnimalsManager.cat == true && audioSource.isPlaying == false)
        {
            Invoke("StartcatSound", 2f);
        }
        else if (AnimalsManager.monkey == true && audioSource.isPlaying == false)
        {
            Invoke("StartmonkeySound", 2f);
        }
        else if (AnimalsManager.fish == true && audioSource.isPlaying == false)
        {
            Invoke("StartfishSound", 2f);
        }
        else if (AnimalsManager.horse == true && audioSource.isPlaying == false)
        {
            Invoke("StarthorseSound", 2f);
        }
        else if (AnimalsManager.deer == true && audioSource.isPlaying == false)
        {
            Invoke("StartdeerSound", 2f);
        }
        else if (AnimalsManager.lion == true && audioSource.isPlaying == false)
        {
            Invoke("StartlionSound", 2f);
        }
    }
    private void Update()
    {
        if (AnimalsManager.cat == false && AnimalsManager.monkey == false && AnimalsManager.fish == false && AnimalsManager.horse == false &&
            AnimalsManager.deer == false && AnimalsManager.lion == false && audioSource.isPlaying == false)
        {
            audioSource.clip = FinishSound;
            audioSource.Play();
            Invoke("FinishLevel", 5f);
        }
    }
    void FinishLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void StartcatSound()
    {
        audioSource.clip = CatSound;
        audioSource.Play();
    }
    void StartmonkeySound()
    {
        audioSource.clip = MonkeySound;
        audioSource.Play();
    }
    void StartfishSound()
    {
        audioSource.clip = FishSound;
        audioSource.Play();
    }
    void StarthorseSound()
    {
        audioSource.clip = HorseSound;
        audioSource.Play();
    }
    void StartdeerSound()
    {
        audioSource.clip = DeerSound;
        audioSource.Play();
    }
    void StartlionSound()
    {
        audioSource.clip = LionSound;
        audioSource.Play();
    }
}
