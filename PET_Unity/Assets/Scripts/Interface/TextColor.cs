using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextColor : MonoBehaviour
{
    public Text textui;

    void Start()
    {
        textui.color = Color.red;
    }
}