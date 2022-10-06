using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsManager : MonoBehaviour
{
    public static bool cat = false;
    public static bool monkey = false;
    public static bool lion = false;
    public static bool horse = false;
    public static bool fish = false;
    public static bool deer = false;

    private void Start()
    {
        cat = (PlayerPrefs.GetInt("cat") != 0);
        monkey = (PlayerPrefs.GetInt("monkey") != 0);
        lion = (PlayerPrefs.GetInt("lion") != 0);
        horse = (PlayerPrefs.GetInt("horse") != 0);
        fish = (PlayerPrefs.GetInt("fish") != 0);
        deer = (PlayerPrefs.GetInt("deer") != 0);
    }
    public void FalseAnimalBool()
    {
        cat = false;
        PlayerPrefs.SetInt("cat", (cat ? 1 : 0));

        monkey = false;
        PlayerPrefs.SetInt("monkey", (monkey ? 1 : 0));

        lion = false;
        PlayerPrefs.SetInt("lion", (lion ? 1 : 0));

        horse = false;
        PlayerPrefs.SetInt("horse", (horse ? 1 : 0));

        fish = false;
        PlayerPrefs.SetInt("fish", (fish ? 1 : 0));

        deer = false;
        PlayerPrefs.SetInt("deer", (deer ? 1 : 0));
    }
    public static void DeleteAnimalBool()
    {
        PlayerPrefs.DeleteKey("cat");
        PlayerPrefs.DeleteKey("monkey");
        PlayerPrefs.DeleteKey("lion");
        PlayerPrefs.DeleteKey("horse");
        PlayerPrefs.DeleteKey("fish");
        PlayerPrefs.DeleteKey("deer");
    }
    public void Cat()
    {
        if (cat)
        {
            cat = false;
            PlayerPrefs.SetInt("cat", (cat ? 1 : 0));
        }
        else
        {
            cat = true;
            PlayerPrefs.SetInt("cat", (cat ? 1 : 0));
        }
    }
    public void Monkey()
    {
        if (monkey)
        {
            monkey = false;
            PlayerPrefs.SetInt("monkey", (monkey ? 1 : 0));
        }
        else
        {
            monkey = true;
            PlayerPrefs.SetInt("monkey", (monkey ? 1 : 0));

        }
    }
    public void Lion()
    {
        if (lion)
        {
            lion = false;
            PlayerPrefs.SetInt("lion", (lion ? 1 : 0));
        }
        else
        {
            lion = true;
            PlayerPrefs.SetInt("lion", (lion ? 1 : 0));

        }
    }
    public void Horse()
    {
        if (horse)
        {
            horse = false;
            PlayerPrefs.SetInt("horse", (horse ? 1 : 0));
        }
        else
        {
            horse = true;
            PlayerPrefs.SetInt("horse", (horse ? 1 : 0));

        }
    }
    public void Fish()
    {
        if (fish)
        {
            fish = false;
            PlayerPrefs.SetInt("fish", (fish ? 1 : 0));
        }
        else
        {
            fish = true;
            PlayerPrefs.SetInt("fish", (fish ? 1 : 0));

        }
    }
    public void Deer()
    {
        if (deer)
        {
            deer = false;
            PlayerPrefs.SetInt("deer", (deer ? 1 : 0));
        }
        else
        {
            deer = true;
            PlayerPrefs.SetInt("deer", (deer ? 1 : 0));

        }
    }
}
