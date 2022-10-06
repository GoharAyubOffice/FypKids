using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTransparencyButtons : MonoBehaviour
{
    Color32 resetOriginalColor = new Color32(255, 255, 225, 255);
    public Button[] buttons;

   // private void Awake()
    //{
    //    buttons = FindObjectsOfType<Button>();
    //}
    public void ResetButtonsTransparency()
    {
        foreach (Button item in buttons)
        {
            item.GetComponent<Image>().color = resetOriginalColor;
        }
    }
}