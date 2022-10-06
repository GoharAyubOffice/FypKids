using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesManager : MonoBehaviour
{
    public static bool circle = false;
    public static bool sqaure = false;
    public static bool triangle = false;
    public static bool rectangle = false;
    public static bool conee = false;
    public static bool diomand = false;
    public static bool pentagonal = false;
    public static bool hexagonal = false;
    public static bool oval = false;

    private void Start()
    {
        circle = (PlayerPrefs.GetInt("circle") != 0);
        sqaure = (PlayerPrefs.GetInt("sqaure") != 0);
        triangle = (PlayerPrefs.GetInt("triangle") != 0);
        rectangle = (PlayerPrefs.GetInt("rectangle") != 0);
        conee = (PlayerPrefs.GetInt("conee") != 0);
        diomand = (PlayerPrefs.GetInt("diomand") != 0);
        pentagonal = (PlayerPrefs.GetInt("pentagonal") != 0);
        hexagonal = (PlayerPrefs.GetInt("hexagonal") != 0);
        oval = (PlayerPrefs.GetInt("oval") != 0);
    }
    public void FalseShapesBool()
    {
        circle = false;
        PlayerPrefs.SetInt("circle", (circle ? 1 : 0));

        sqaure = false;
        PlayerPrefs.SetInt("sqaure", (sqaure ? 1 : 0));

        triangle = false;
        PlayerPrefs.SetInt("triangle", (triangle ? 1 : 0));

        rectangle = false;
        PlayerPrefs.SetInt("rectangle", (rectangle ? 1 : 0));

        conee = false;
        PlayerPrefs.SetInt("conee", (conee ? 1 : 0));

        diomand = false;
        PlayerPrefs.SetInt("diomand", (diomand ? 1 : 0));

        pentagonal = false;
        PlayerPrefs.SetInt("pentagonal", (pentagonal ? 1 : 0));

        hexagonal = false;
        PlayerPrefs.SetInt("hexagonal", (hexagonal ? 1 : 0));

        oval = false;
        PlayerPrefs.SetInt("oval", (oval ? 1 : 0));
    }
    public static void DeleteShapesBool()
    {
        PlayerPrefs.DeleteKey("circle");
        PlayerPrefs.DeleteKey("sqaure");
        PlayerPrefs.DeleteKey("triangle");
        PlayerPrefs.DeleteKey("rectangle");
        PlayerPrefs.DeleteKey("conee");
        PlayerPrefs.DeleteKey("diomand");
        PlayerPrefs.DeleteKey("pentagonal");
        PlayerPrefs.DeleteKey("hexagonal");
        PlayerPrefs.DeleteKey("oval");
    }
    public void Circle()
    {
        if (circle)
        {
            circle = false;
            PlayerPrefs.SetInt("circle", (circle ? 1 : 0));
        }
        else
        {
            circle = true;
            PlayerPrefs.SetInt("circle", (circle ? 1 : 0));
        }
    }
    public void Sqaure()
    {
        if (sqaure)
        {
            sqaure = false;
            PlayerPrefs.SetInt("sqaure", (sqaure ? 1 : 0));
        }
        else
        {
            sqaure = true;
            PlayerPrefs.SetInt("sqaure", (sqaure ? 1 : 0));

        }
    }
    public void Triangle()
    {
        if (triangle)
        {
            triangle = false;
            PlayerPrefs.SetInt("triangle", (triangle ? 1 : 0));
        }
        else
        {
            triangle = true;
            PlayerPrefs.SetInt("triangle", (triangle ? 1 : 0));

        }
    }
    public void Rectangle()
    {
        if (rectangle)
        {
            rectangle = false;
            PlayerPrefs.SetInt("rectangle", (rectangle ? 1 : 0));
        }
        else
        {
            rectangle = true;
            PlayerPrefs.SetInt("rectangle", (rectangle ? 1 : 0));

        }
    }
    public void Conee()
    {
        if (conee)
        {
            conee = false;
            PlayerPrefs.SetInt("conee", (conee ? 1 : 0));
        }
        else
        {
            conee = true;
            PlayerPrefs.SetInt("conee", (conee ? 1 : 0));

        }
    }
    public void Diomand()
    {
        if (diomand)
        {
            diomand = false;
            PlayerPrefs.SetInt("diomand", (diomand ? 1 : 0));
        }
        else
        {
            diomand = true;
            PlayerPrefs.SetInt("diomand", (diomand ? 1 : 0));

        }
    }
    public void Pentagonal()
    {
        if (pentagonal)
        {
            pentagonal = false;
            PlayerPrefs.SetInt("pentagonal", (pentagonal ? 1 : 0));
        }
        else
        {
            pentagonal = true;
            PlayerPrefs.SetInt("pentagonal", (pentagonal ? 1 : 0));

        }
    }
    public void Hexagonal()
    {
        if (hexagonal)
        {
            hexagonal = false;
            PlayerPrefs.SetInt("hexagonal", (hexagonal ? 1 : 0));
        }
        else
        {
            hexagonal = true;
            PlayerPrefs.SetInt("hexagonal", (hexagonal ? 1 : 0));

        }
    }
    public void Oval()
    {
        if (oval)
        {
            oval = false;
            PlayerPrefs.SetInt("oval", (oval ? 1 : 0));
        }
        else
        {
            oval = true;
            PlayerPrefs.SetInt("oval", (oval ? 1 : 0));

        }
    }
}
