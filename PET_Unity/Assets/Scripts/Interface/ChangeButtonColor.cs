using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{
    public bool ButtonOn = false;
    public Button MyButton;
    public Color ColorOff;
    public Color ColorOn;

    public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        MyButton.image.color = ButtonOn ? ColorOn : ColorOff;
    }
}