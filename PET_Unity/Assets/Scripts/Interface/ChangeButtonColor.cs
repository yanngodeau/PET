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
    public int appareil;

    void Start()
    {
        switch (appareil)
        {
            case 0:
                ButtonOn = GlobalControl.Instance.ampouleOn;
                MyButton.image.color = ButtonOn ? ColorOn : ColorOff;
                break;
            case 1:
                ButtonOn = GlobalControl.Instance.priseAOn;
                MyButton.image.color = ButtonOn ? ColorOn : ColorOff;
                break;
            case 2:
                ButtonOn = GlobalControl.Instance.priseBOn;
                MyButton.image.color = ButtonOn ? ColorOn : ColorOff;
                break;
        }
    }


    public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        MyButton.image.color = ButtonOn ? ColorOn : ColorOff;
        switch (appareil)
        {
            case 0:
                GlobalControl.Instance.ampouleOn = ButtonOn;
                break;
            case 1:
                GlobalControl.Instance.priseAOn = ButtonOn;
                break;
            case 2:
                GlobalControl.Instance.priseBOn = ButtonOn;
                break;
        }
    }
}