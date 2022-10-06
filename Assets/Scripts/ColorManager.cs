using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static bool green = false;
    public static bool pink = false;
    public static bool orange = false;
    public static bool red = false;
    public static bool yellow = false;
    public static bool blue = false;
    public static bool purple = false;

    private void Start()
    {
        green = (PlayerPrefs.GetInt("green") != 0);
        pink = (PlayerPrefs.GetInt("pink") != 0);
        orange = (PlayerPrefs.GetInt("orange") != 0);
        red = (PlayerPrefs.GetInt("red") != 0);
        yellow = (PlayerPrefs.GetInt("yellow") != 0);
        blue = (PlayerPrefs.GetInt("blue") != 0);
        purple = (PlayerPrefs.GetInt("purple") != 0);
    }
    public void FalseColorBool()
    {
        green = false;
        PlayerPrefs.SetInt("green", (green ? 1 : 0));

        pink = false;
        PlayerPrefs.SetInt("pink", (pink ? 1 : 0));

        orange = false;
        PlayerPrefs.SetInt("orange", (orange ? 1 : 0));

        red = false;
        PlayerPrefs.SetInt("red", (red ? 1 : 0));

        yellow = false;
        PlayerPrefs.SetInt("yellow", (yellow ? 1 : 0));

        blue = false;
        PlayerPrefs.SetInt("blue", (blue ? 1 : 0));

        purple = false;
        PlayerPrefs.SetInt("purple", (purple ? 1 : 0));
    }
    public static void DeleteColorBool()
    {
        PlayerPrefs.DeleteKey("green");
        PlayerPrefs.DeleteKey("pink");
        PlayerPrefs.DeleteKey("orange");
        PlayerPrefs.DeleteKey("red");
        PlayerPrefs.DeleteKey("yellow");
        PlayerPrefs.DeleteKey("blue");
        PlayerPrefs.DeleteKey("purple");
    }
    public void Green()
    {
        if (green)
        {
            green = false;
            PlayerPrefs.SetInt("green", (green ? 1 : 0));
        }
        else
        {
            green = true;
            PlayerPrefs.SetInt("green", (green ? 1 : 0));
        }
    }
    public void Pink()
    {
        if (pink)
        {
            pink = false;
            PlayerPrefs.SetInt("pink", (pink ? 1 : 0));
        }
        else
        {
            pink = true;
            PlayerPrefs.SetInt("pink", (pink ? 1 : 0));

        }
    }
    public void Orange()
    {
        if (orange)
        {
            orange = false;
            PlayerPrefs.SetInt("orange", (orange ? 1 : 0));
        }
        else
        {
            orange = true;
            PlayerPrefs.SetInt("orange", (orange ? 1 : 0));

        }
    }
    public void Red()
    {
        if (red)
        {
            red = false;
            PlayerPrefs.SetInt("red", (red ? 1 : 0));
        }
        else
        {
            red = true;
            PlayerPrefs.SetInt("red", (red ? 1 : 0));

        }
    }
    public void Yellow()
    {
        if (yellow)
        {
            yellow = false;
            PlayerPrefs.SetInt("yellow", (yellow ? 1 : 0));
        }
        else
        {
            yellow = true;
            PlayerPrefs.SetInt("yellow", (yellow ? 1 : 0));

        }
    }
    public void Blue()
    {
        if (blue)
        {
            blue = false;
            PlayerPrefs.SetInt("blue", (blue ? 1 : 0));
        }
        else
        {
            blue = true;
            PlayerPrefs.SetInt("blue", (blue ? 1 : 0));

        }
    }
    public void Purple()
    {
        if (purple)
        {
            purple = false;
            PlayerPrefs.SetInt("purple", (purple ? 1 : 0));
        }
        else
        {
            purple = true;
            PlayerPrefs.SetInt("purple", (purple ? 1 : 0));

        }
    }
}
