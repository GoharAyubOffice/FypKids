using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBirdsSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip DuckSound;
    [SerializeField] AudioClip EagleSound;
    [SerializeField] AudioClip SparrowSound;
    [SerializeField] AudioClip ParrotSound;
    [SerializeField] AudioClip RoosterSound;
    [SerializeField] AudioClip ToucanSound;
    [SerializeField] AudioClip FinishSound;

    [SerializeField] float endTimeofLevel;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (BirdsManager.duck == true && audioSource.isPlaying == false)
        {
            Invoke("StartduckSound", 2f);
        }
        else if (BirdsManager.eagle == true && audioSource.isPlaying == false)
        {
            Invoke("StarteagleSound", 2f);
        }
        else if (BirdsManager.sparrow == true && audioSource.isPlaying == false)
        {
            Invoke("StartsparrowSound", 2f);
        }
        else if (BirdsManager.parrot == true && audioSource.isPlaying == false)
        {
            Invoke("StartparrotSound", 2f);
        }
        else if (BirdsManager.rooster == true && audioSource.isPlaying == false)
        {
            Invoke("StartroosterSound", 2f);
        }
        else if (BirdsManager.toucan == true && audioSource.isPlaying == false)
        {
            Invoke("StarttoucanSound", 2f);
        }
    }
    private void Update()
    {
        if (BirdsManager.duck == false && BirdsManager.eagle == false && BirdsManager.sparrow == false && BirdsManager.parrot == false &&
            BirdsManager.rooster == false && BirdsManager.toucan == false && audioSource.isPlaying == false)
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
    void StartduckSound()
    {
        audioSource.clip = DuckSound;
        audioSource.Play();
    }
    void StarteagleSound()
    {
        audioSource.clip = EagleSound;
        audioSource.Play();
    }
    void StartsparrowSound()
    {
        audioSource.clip = SparrowSound;
        audioSource.Play();
    }
    void StartparrotSound()
    {
        audioSource.clip = ParrotSound;
        audioSource.Play();
    }
    void StartroosterSound()
    {
        audioSource.clip = RoosterSound;
        audioSource.Play();
    }
    void StarttoucanSound()
    {
        audioSource.clip = ToucanSound;
        audioSource.Play();
    }
}
