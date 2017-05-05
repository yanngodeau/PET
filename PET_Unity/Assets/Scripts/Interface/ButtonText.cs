using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonText : MonoBehaviour {

    public bool TextOn;
    public Text MyText;
    public Color ColorOff;
    public Color ColorOn;

    public void BeenClicked()
    {
        TextOn = !TextOn;
        MyText.color = TextOn ? ColorOn : ColorOff;
    }
}