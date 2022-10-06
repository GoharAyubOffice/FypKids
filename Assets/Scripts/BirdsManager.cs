using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsManager : MonoBehaviour
{
    public static bool duck = false;
    public static bool eagle = false;
    public static bool rooster = false;
    public static bool sparrow = false;
    public static bool parrot = false;
    public static bool toucan = false;

    private void Start()
    {
        duck = (PlayerPrefs.GetInt("duck") != 0);
        eagle = (PlayerPrefs.GetInt("eagle") != 0);
        rooster = (PlayerPrefs.GetInt("rooster") != 0);
        sparrow = (PlayerPrefs.GetInt("sparrow") != 0);
        parrot = (PlayerPrefs.GetInt("parrot") != 0);
        toucan = (PlayerPrefs.GetInt("toucan") != 0);
    }
    public void FalseBirdsBool()
    {
        duck = false;
        PlayerPrefs.SetInt("duck", (duck ? 1 : 0));

        eagle = false;
        PlayerPrefs.SetInt("eagle", (eagle ? 1 : 0));

        rooster = false;
        PlayerPrefs.SetInt("rooster", (rooster ? 1 : 0));

        sparrow = false;
        PlayerPrefs.SetInt("sparrow", (sparrow ? 1 : 0));

        parrot = false;
        PlayerPrefs.SetInt("parrot", (parrot ? 1 : 0));

        toucan = false;
        PlayerPrefs.SetInt("toucan", (toucan ? 1 : 0));
    }
    public static void DeleteBirdsBool()
    {
        PlayerPrefs.DeleteKey("duck");
        PlayerPrefs.DeleteKey("eagle");
        PlayerPrefs.DeleteKey("rooster");
        PlayerPrefs.DeleteKey("sparrow");
        PlayerPrefs.DeleteKey("parrot");
        PlayerPrefs.DeleteKey("toucan");
    }
    public void Duck()
    {
        if (duck)
        {
            duck = false;
            PlayerPrefs.SetInt("duck", (duck ? 1 : 0));
        }
        else
        {
            duck = true;
            PlayerPrefs.SetInt("duck", (duck ? 1 : 0));
        }
    }
    public void Eagle()
    {
        if (eagle)
        {
            eagle = false;
            PlayerPrefs.SetInt("eagle", (eagle ? 1 : 0));
        }
        else
        {
            eagle = true;
            PlayerPrefs.SetInt("eagle", (eagle ? 1 : 0));

        }
    }
    public void Rooster()
    {
        if (rooster)
        {
            rooster = false;
            PlayerPrefs.SetInt("rooster", (rooster ? 1 : 0));
        }
        else
        {
            rooster = true;
            PlayerPrefs.SetInt("rooster", (rooster ? 1 : 0));

        }
    }
    public void Sparrow()
    {
        if (sparrow)
        {
            sparrow = false;
            PlayerPrefs.SetInt("sparrow", (sparrow ? 1 : 0));
        }
        else
        {
            sparrow = true;
            PlayerPrefs.SetInt("sparrow", (sparrow ? 1 : 0));

        }
    }
    public void Parrot()
    {
        if (parrot)
        {
            parrot = false;
            PlayerPrefs.SetInt("parrot", (parrot ? 1 : 0));
        }
        else
        {
            parrot = true;
            PlayerPrefs.SetInt("parrot", (parrot ? 1 : 0));

        }
    }
    public void Toucan()
    {
        if (toucan)
        {
            toucan = false;
            PlayerPrefs.SetInt("toucan", (toucan ? 1 : 0));
        }
        else
        {
            toucan = true;
            PlayerPrefs.SetInt("toucan", (toucan ? 1 : 0));

        }
    }
}
