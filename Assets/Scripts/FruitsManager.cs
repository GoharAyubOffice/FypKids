using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsManager : MonoBehaviour
{
    public static bool apple = false;
    public static bool mango = false;
    public static bool banana = false;
    public static bool grapes = false;
    public static bool orangefruit = false;
    public static bool waterMelon = false;
    public static bool pineApple = false;

    private void Start()
    {
        apple = (PlayerPrefs.GetInt("apple") != 0);
        mango = (PlayerPrefs.GetInt("mango") != 0);
        banana = (PlayerPrefs.GetInt("banana") != 0);
        grapes = (PlayerPrefs.GetInt("grapes") != 0);
        orangefruit = (PlayerPrefs.GetInt("orangefruit") != 0);
        waterMelon = (PlayerPrefs.GetInt("waterMelon") != 0);
        pineApple = (PlayerPrefs.GetInt("pineApple") != 0);
    }
    public void FalseFruitBool()
    {
        apple = false;
        PlayerPrefs.SetInt("apple", (apple ? 1 : 0));

        mango = false;
        PlayerPrefs.SetInt("mango", (mango ? 1 : 0));

        banana = false;
        PlayerPrefs.SetInt("banana", (banana ? 1 : 0));

        grapes = false;
        PlayerPrefs.SetInt("grapes", (grapes ? 1 : 0));

        orangefruit = false;
        PlayerPrefs.SetInt("orangefruit", (orangefruit ? 1 : 0));

        waterMelon = false;
        PlayerPrefs.SetInt("waterMelon", (waterMelon ? 1 : 0));

        pineApple = false;
        PlayerPrefs.SetInt("pineApple", (pineApple ? 1 : 0));
    }
    public static void DeleteFruitBool()
    {
        PlayerPrefs.DeleteKey("apple");
        PlayerPrefs.DeleteKey("mango");
        PlayerPrefs.DeleteKey("banana");
        PlayerPrefs.DeleteKey("grapes");
        PlayerPrefs.DeleteKey("orangefruit");
        PlayerPrefs.DeleteKey("waterMelon");
        PlayerPrefs.DeleteKey("pineApple");
    }
    public void Apple()
    {
        if (apple)
        {
            apple = false;
            PlayerPrefs.SetInt("apple", (apple ? 1 : 0));
        }
        else
        {
            apple = true;
            PlayerPrefs.SetInt("apple", (apple ? 1 : 0));
        }
    }
    public void Mango()
    {
        if (mango)
        {
            mango = false;
            PlayerPrefs.SetInt("mango", (mango ? 1 : 0));
        }
        else
        {
            mango = true;
            PlayerPrefs.SetInt("mango", (mango ? 1 : 0));

        }
    }
    public void Banana()
    {
        if (banana)
        {
            banana = false;
            PlayerPrefs.SetInt("banana", (banana ? 1 : 0));
        }
        else
        {
            banana = true;
            PlayerPrefs.SetInt("banana", (banana ? 1 : 0));

        }
    }
    public void Grapes()
    {
        if (grapes)
        {
            grapes = false;
            PlayerPrefs.SetInt("grapes", (grapes ? 1 : 0));
        }
        else
        {
            grapes = true;
            PlayerPrefs.SetInt("grapes", (grapes ? 1 : 0));

        }
    }
    public void Orangefruit()
    {
        if (orangefruit)
        {
            orangefruit = false;
            PlayerPrefs.SetInt("orangefruit", (orangefruit ? 1 : 0));
        }
        else
        {
            orangefruit = true;
            PlayerPrefs.SetInt("orangefruit", (orangefruit ? 1 : 0));

        }
    }
    public void WaterMelon()
    {
        if (waterMelon)
        {
            waterMelon = false;
            PlayerPrefs.SetInt("waterMelon", (waterMelon ? 1 : 0));
        }
        else
        {
            waterMelon = true;
            PlayerPrefs.SetInt("waterMelon", (waterMelon ? 1 : 0));

        }
    }
    public void PineApple()
    {
        if (pineApple)
        {
            pineApple = false;
            PlayerPrefs.SetInt("pineApple", (pineApple ? 1 : 0));
        }
        else
        {
            pineApple = true;
            PlayerPrefs.SetInt("pineApple", (pineApple ? 1 : 0));

        }
    }
}
