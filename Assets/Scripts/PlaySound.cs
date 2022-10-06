using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip Asound;
    [SerializeField] AudioClip Bsound;
    [SerializeField] AudioClip Csound;
    [SerializeField] AudioClip Dsound;
    [SerializeField] AudioClip Esound;
    [SerializeField] AudioClip Fsound;
    [SerializeField] AudioClip Gsound;
    [SerializeField] AudioClip Hsound;
    [SerializeField] AudioClip Isound;
    [SerializeField] AudioClip Jsound;
    [SerializeField] AudioClip Ksound;
    [SerializeField] AudioClip Lsound;
    [SerializeField] AudioClip Msound;
    [SerializeField] AudioClip Nsound;
    [SerializeField] AudioClip Osound;
    [SerializeField] AudioClip Psound;
    [SerializeField] AudioClip Qsound;
    [SerializeField] AudioClip Rsound;
    [SerializeField] AudioClip Ssound;
    [SerializeField] AudioClip Tsound;
    [SerializeField] AudioClip Usound;
    [SerializeField] AudioClip Vsound;
    [SerializeField] AudioClip Wsound;
    [SerializeField] AudioClip Xsound;
    [SerializeField] AudioClip Ysound;
    [SerializeField] AudioClip Zsound;
    [SerializeField] AudioClip FinishSound;

    public static bool quizPanel;

    [SerializeField] float endTimeofLevel;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (AlphabetsManager.a == true && audioSource.isPlaying == false)
        {
            Invoke("StartASound", 2f);
        }
        else if (AlphabetsManager.b == true && audioSource.isPlaying == false)
        {
            Invoke("StartBSound", 2f);
        }
        else if (AlphabetsManager.c == true && audioSource.isPlaying == false)
        {
            Invoke("StartCSound", 2f);
        }
        else if (AlphabetsManager.d == true && audioSource.isPlaying == false)
        {
            Invoke("StartDSound", 2f);
        }
        else if (AlphabetsManager.e == true && audioSource.isPlaying == false)
        {
            Invoke("StartESound", 2f);
        }
        else if (AlphabetsManager.f == true && audioSource.isPlaying == false)
        {
            Invoke("StartFSound", 2f);
        }
        else if (AlphabetsManager.g == true && audioSource.isPlaying == false)
        {
            Invoke("StartGSound", 2f);
        }
        else if (AlphabetsManager.h == true && audioSource.isPlaying == false)
        {
            Invoke("StartHSound", 2f);
        }
        else if (AlphabetsManager.i == true && audioSource.isPlaying == false)
        {
            Invoke("StartISound", 2f);
        }
        else if (AlphabetsManager.j == true && audioSource.isPlaying == false)
        {
            Invoke("StartJSound", 2f);
        }
        else if (AlphabetsManager.k == true && audioSource.isPlaying == false)
        {
            Invoke("StartKSound", 2f);
        }
        else if (AlphabetsManager.l == true && audioSource.isPlaying == false)
        {
            Invoke("StartLSound", 2f);
        }
        else if (AlphabetsManager.m == true && audioSource.isPlaying == false)
        {
            Invoke("StartMSound", 2f);
        }
        else if (AlphabetsManager.n == true && audioSource.isPlaying == false)
        {
            Invoke("StartNSound", 2f);
        }
        else if (AlphabetsManager.o == true && audioSource.isPlaying == false)
        {
            Invoke("StartOSound", 2f);
        }
        else if (AlphabetsManager.p == true && audioSource.isPlaying == false)
        {
            Invoke("StartPSound", 2f);
        }
        else if (AlphabetsManager.q == true && audioSource.isPlaying == false)
        {
            Invoke("StartQSound", 2f);
        }
        else if (AlphabetsManager.r == true && audioSource.isPlaying == false)
        {
            Invoke("StartRSound", 2f);
        }
        else if (AlphabetsManager.s == true && audioSource.isPlaying == false)
        {
            Invoke("StartSSound", 2f);
        }
        else if (AlphabetsManager.t == true && audioSource.isPlaying == false)
        {
            Invoke("StartTSound", 2f);
        }
        else if (AlphabetsManager.u == true && audioSource.isPlaying == false)
        {
            Invoke("StartUSound", 2f);
        }
        else if (AlphabetsManager.v == true && audioSource.isPlaying == false)
        {
            Invoke("StartVSound", 2f);
        }
        else if (AlphabetsManager.w == true && audioSource.isPlaying == false)
        {
            Invoke("StartWSound", 2f);
        }
        else if (AlphabetsManager.x == true && audioSource.isPlaying == false)
        {
            Invoke("StartXSound", 2f);
        }
        else if (AlphabetsManager.y == true && audioSource.isPlaying == false)
        {
            Invoke("StartYSound", 2f);
        }
        else if (AlphabetsManager.z == true && audioSource.isPlaying == false)
        {
            Invoke("StartZSound", 2f);
        }
    }
    private void Update()
    {
        if (AlphabetsManager.a == false && AlphabetsManager.b == false && AlphabetsManager.c == false && AlphabetsManager.d == false &&
            AlphabetsManager.e == false && AlphabetsManager.f == false && AlphabetsManager.g == false && AlphabetsManager.h == false &&
            AlphabetsManager.i == false && AlphabetsManager.j == false && AlphabetsManager.k == false && AlphabetsManager.l == false &&
            AlphabetsManager.m == false && AlphabetsManager.n == false && AlphabetsManager.o == false && AlphabetsManager.p == false &&
            AlphabetsManager.q == false && AlphabetsManager.r == false && AlphabetsManager.s == false && AlphabetsManager.t == false &&
            AlphabetsManager.u == false && AlphabetsManager.v == false && AlphabetsManager.w == false && AlphabetsManager.x == false &&
            AlphabetsManager.y == false && AlphabetsManager.z == false && audioSource.isPlaying ==false)
        {
            quizPanel = true;
            PlayerPrefs.SetInt("EnableAlphabetsQuiz", (quizPanel ? 1 : 0));
            audioSource.clip = FinishSound;
            audioSource.Play();
            Invoke("FinishLevel", 5f);
        }
    }
    void FinishLevel()
    {
            Debug.Log("Finished Level ");
            SceneManager.LoadScene("MainMenu");
    }
    void StartASound()
    {
        audioSource.clip = Asound;
        audioSource.Play();
        Debug.Log("A Played");
    }
    void StartBSound()
    {
        audioSource.clip = Bsound;
        audioSource.Play();
        Debug.Log("B Played");
    }
    void StartCSound()
    {
        audioSource.clip = Csound;
        audioSource.Play();
        Debug.Log("C Played");
    }
    void StartDSound()
    {
        audioSource.clip = Dsound;
        audioSource.Play();
        Debug.Log("D Played");
    }
    void StartESound()
    {
        audioSource.clip = Esound;
        audioSource.Play();
        Debug.Log("E Played");
    }
    void StartFSound()
    {
        audioSource.clip = Fsound;
        audioSource.Play();
        Debug.Log("F Played");
    }
    void StartGSound()
    {
        audioSource.clip = Gsound;
        audioSource.Play();
        Debug.Log("G Played");
    }
    void StartHSound()
    {
        audioSource.clip = Hsound;
        audioSource.Play();
        Debug.Log("H Played");
    }
    void StartISound()
    {
        audioSource.clip = Isound;
        audioSource.Play();
        Debug.Log("I Played");
    }
    void StartJSound()
    {
        audioSource.clip = Jsound;
        audioSource.Play();
        Debug.Log("J Played");
    }
    void StartKSound()
    {
        audioSource.clip = Ksound;
        audioSource.Play();
        Debug.Log("K Played");
    }
    void StartLSound()
    {
        audioSource.clip = Lsound;
        audioSource.Play();
        Debug.Log("L Played");
    }
    void StartMSound()
    {
        audioSource.clip = Msound;
        audioSource.Play();
        Debug.Log("M Played");
    }
    void StartNSound()
    {
        audioSource.clip = Nsound;
        audioSource.Play();
        Debug.Log("N Played");
    }
    void StartOSound()
    {
        audioSource.clip = Osound;
        audioSource.Play();
        Debug.Log("O Played");
    }
    void StartPSound()
    {
        audioSource.clip = Psound;
        audioSource.Play();
        Debug.Log("P Played");
    }
    void StartQSound()
    {
        audioSource.clip = Qsound;
        audioSource.Play();
        Debug.Log("Q Played");
    }
    void StartRSound()
    {
        audioSource.clip = Rsound;
        audioSource.Play();
        Debug.Log("R Played");
    }
    void StartSSound()
    {
        audioSource.clip = Ssound;
        audioSource.Play();
        Debug.Log("S Played");
    }
    void StartTSound()
    {
        audioSource.clip = Tsound;
        audioSource.Play();
        Debug.Log("T Played");
    }
    void StartUSound()
    {
        audioSource.clip = Usound;
        audioSource.Play();
        Debug.Log("U Played");
    }
    void StartVSound()
    {
        audioSource.clip = Vsound;
        audioSource.Play();
        Debug.Log("V Played");
    }
    void StartWSound()
    {
        audioSource.clip = Wsound;
        audioSource.Play();
        Debug.Log("W Played");
    }
    void StartXSound()
    {
        audioSource.clip = Xsound;
        audioSource.Play();
        Debug.Log("X Played");
    }
    void StartYSound()
    {
        audioSource.clip = Ysound;
        audioSource.Play();
        Debug.Log("Y Played");
    }
    void StartZSound()
    {
        audioSource.clip = Zsound;
        audioSource.Play();
        Debug.Log("Z Played");
    }
}