using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayNumberSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip zeroSound;
    [SerializeField] AudioClip oneSound;
    [SerializeField] AudioClip twoSound;
    [SerializeField] AudioClip threeSound;
    [SerializeField] AudioClip fourSound;
    [SerializeField] AudioClip fiveSound;
    [SerializeField] AudioClip sixSound;
    [SerializeField] AudioClip sevenSound;
    [SerializeField] AudioClip eightSound;
    [SerializeField] AudioClip nineSound;
    [SerializeField] AudioClip FinishSound;

    [SerializeField] float endTimeofLevel;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (NumbersManager.zero == true && audioSource.isPlaying == false)
        {
            Invoke("StartZeroSound", 2f);
        }
        else if (NumbersManager.one == true && audioSource.isPlaying == false)
        {
            Invoke("StartOneSound", 2f);
        }
        else if (NumbersManager.two == true && audioSource.isPlaying == false)
        {
            Invoke("StartTwoSound", 2f);
        }
        else if (NumbersManager.three == true && audioSource.isPlaying == false)
        {
            Invoke("StartThreeSound", 2f);
        }
        else if (NumbersManager.four == true && audioSource.isPlaying == false)
        {
            Invoke("StartFourSound", 2f);
        }
        else if (NumbersManager.five == true && audioSource.isPlaying == false)
        {
            Invoke("StartFiveSound", 2f);
        }
        else if (NumbersManager.six == true && audioSource.isPlaying == false)
        {
            Invoke("StartSixSound", 2f);
        }
        else if (NumbersManager.seven == true && audioSource.isPlaying == false)
        {
            Invoke("StartSevenSound", 2f);
        }
        else if (NumbersManager.eight == true && audioSource.isPlaying == false)
        {
            Invoke("StartEightSound", 2f);
        }
        else if (NumbersManager.nine == true && audioSource.isPlaying == false)
        {
            Invoke("StartNineSound", 2f);
        }
        
    }
    private void Update()
    {
        if (NumbersManager.zero == false && NumbersManager.one == false && NumbersManager.two == false && NumbersManager.three == false &&
            NumbersManager.four == false && NumbersManager.five == false && NumbersManager.six == false && NumbersManager.seven == false &&
            NumbersManager.eight == false && NumbersManager.nine == false && audioSource.isPlaying == false)
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
    void StartZeroSound()
    {
        audioSource.clip = zeroSound;
        audioSource.Play();
    }
    void StartOneSound()
    {
        audioSource.clip = oneSound;
        audioSource.Play();
    }
    void StartTwoSound()
    {
        audioSource.clip = twoSound;
        audioSource.Play();
    }
    void StartThreeSound()
    {
        audioSource.clip = threeSound;
        audioSource.Play();
    }
    void StartFourSound()
    {
        audioSource.clip = fourSound;
        audioSource.Play();
    }
    void StartFiveSound()
    {
        audioSource.clip = fiveSound;
        audioSource.Play();
    }
    void StartSixSound()
    {
        audioSource.clip = sixSound;
        audioSource.Play();
    }
    void StartSevenSound()
    {
        audioSource.clip = sevenSound;
        audioSource.Play();
    }
    void StartEightSound()
    {
        audioSource.clip = eightSound;
        audioSource.Play();
    }
    void StartNineSound()
    {
        audioSource.clip = nineSound;
        audioSource.Play();
    }
}
