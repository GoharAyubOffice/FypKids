using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersManager : MonoBehaviour
{
    public static bool zero = false;
    public static bool one = false;
    public static bool two = false;
    public static bool three = false;
    public static bool four = false;
    public static bool five = false;
    public static bool six = false;
    public static bool seven = false;
    public static bool eight = false;
    public static bool nine = false;

    private void Start()
    {
        zero = (PlayerPrefs.GetInt("zero") != 0);
        one = (PlayerPrefs.GetInt("one") != 0);
        two = (PlayerPrefs.GetInt("two") != 0);
        three = (PlayerPrefs.GetInt("three") != 0);
        four = (PlayerPrefs.GetInt("four") != 0);
        five = (PlayerPrefs.GetInt("five") != 0);
        six = (PlayerPrefs.GetInt("six") != 0);
        seven = (PlayerPrefs.GetInt("seven") != 0);
        eight = (PlayerPrefs.GetInt("eight") != 0);
        nine = (PlayerPrefs.GetInt("nine") != 0);
    }
    public void FalseNumbersBool()
    {
        zero = false;
        PlayerPrefs.SetInt("zero", (zero ? 1 : 0));

        one = false;
        PlayerPrefs.SetInt("one", (one ? 1 : 0));

        two = false;
        PlayerPrefs.SetInt("two", (two ? 1 : 0));

        three = false;
        PlayerPrefs.SetInt("three", (three ? 1 : 0));

        four = false;
        PlayerPrefs.SetInt("four", (four ? 1 : 0));

        five = false;
        PlayerPrefs.SetInt("five", (five ? 1 : 0));

        six = false;
        PlayerPrefs.SetInt("six", (six ? 1 : 0));

        seven = false;
        PlayerPrefs.SetInt("seven", (seven ? 1 : 0));

        eight = false;
        PlayerPrefs.SetInt("eight", (eight ? 1 : 0));

        nine = false;
        PlayerPrefs.SetInt("nine", (nine ? 1 : 0));

       
    }
    public static void DeleteNumbersBool()
    {
        PlayerPrefs.DeleteKey("zero");
        PlayerPrefs.DeleteKey("one");
        PlayerPrefs.DeleteKey("two");
        PlayerPrefs.DeleteKey("three");
        PlayerPrefs.DeleteKey("four");
        PlayerPrefs.DeleteKey("five");
        PlayerPrefs.DeleteKey("six");
        PlayerPrefs.DeleteKey("seven");
        PlayerPrefs.DeleteKey("eight");
        PlayerPrefs.DeleteKey("nine");
    }
    public void Zero()
    {
        if (zero)
        {
            zero = false;
            PlayerPrefs.SetInt("zero", (zero ? 1 : 0));
        }
        else
        {
            zero = true;
            PlayerPrefs.SetInt("zero", (zero ? 1 : 0));
        }
    }
    public void One()
    {
        if (one)
        {
            one = false;
            PlayerPrefs.SetInt("one", (one ? 1 : 0));
        }
        else
        {
            one = true;
            PlayerPrefs.SetInt("one", (one ? 1 : 0));

        }
    }
    public void Two()
    {
        if (two)
        {
            two = false;
            PlayerPrefs.SetInt("two", (two ? 1 : 0));
        }
        else
        {
            two = true;
            PlayerPrefs.SetInt("two", (two ? 1 : 0));

        }
    }
    public void Three()
    {
        if (three)
        {
            three = false;
            PlayerPrefs.SetInt("three", (three ? 1 : 0));
        }
        else
        {
            three = true;
            PlayerPrefs.SetInt("three", (three ? 1 : 0));

        }
    }
    public void Four()
    {
        if (four)
        {
            four = false;
            PlayerPrefs.SetInt("four", (four ? 1 : 0));
        }
        else
        {
            four = true;
            PlayerPrefs.SetInt("four", (four ? 1 : 0));

        }
    }
    public void Five()
    {
        if (five)
        {
            five = false;
            PlayerPrefs.SetInt("five", (five ? 1 : 0));
        }
        else
        {
            five = true;
            PlayerPrefs.SetInt("five", (five ? 1 : 0));

        }
    }
    public void Six()
    {
        if (six)
        {
            six = false;
            PlayerPrefs.SetInt("six", (six ? 1 : 0));
        }
        else
        {
            six = true;
            PlayerPrefs.SetInt("six", (six ? 1 : 0));

        }
    }
    public void Seven()
    {
        if (seven)
        {
            seven = false;
            PlayerPrefs.SetInt("seven", (seven ? 1 : 0));
        }
        else
        {
            seven = true;
            PlayerPrefs.SetInt("seven", (seven ? 1 : 0));

        }
    }
    public void Eight()
    {
        if (eight)
        {
            eight = false;
            PlayerPrefs.SetInt("eight", (eight ? 1 : 0));
        }
        else
        {
            eight = true;
            PlayerPrefs.SetInt("eight", (eight ? 1 : 0));

        }
    }
    public void Nine()
    {
        if (nine)
        {
            nine = false;
            PlayerPrefs.SetInt("nine", (nine ? 1 : 0));
        }
        else
        {
            nine = true;
            PlayerPrefs.SetInt("nine", (nine ? 1 : 0));

        }
    }
    }
