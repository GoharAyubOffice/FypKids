using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractable : MonoBehaviour
{
    public GameObject image;
    public Image[] imageAlphabet;
    public void TransparencyButton()
    {
        if (image.GetComponent<Image>().color == new Color32(255, 255, 255, 255))
        {
            image.GetComponent<Image>().color = new Color32(0, 0, 0, 200);
            
        }
        else if (image.GetComponent<Image>().color == new Color32(0, 0, 0, 200))
        {
            image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void ResetAlphabetsTransparency()
    {
        foreach (Image item in imageAlphabet)
        {
            item.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
}
