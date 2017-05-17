using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class TutorielAuto : MonoBehaviour
{
    public GameObject PanelA1;
    public GameObject PanelA2;
    public GameObject PanelA3;
    public GameObject PanelA4;
    public GameObject PanelMo1;
    public HorizontalScrollSnap SuperScroll;

    public void A1()
    {
        PanelA1.SetActive(false);
        PanelA2.SetActive(true);
        PanelA3.SetActive(false);
        PanelA4.SetActive(false);
    }
    public void A2()
    {
        PanelA1.SetActive(false);
        PanelA2.SetActive(false);
        PanelA3.SetActive(true);
        PanelA4.SetActive(false);
    }
    public void A3()
    {
        PanelA1.SetActive(false);
        PanelA2.SetActive(false);
        PanelA3.SetActive(false);
        PanelA4.SetActive(true);
    }
    public void A4()
    {
        PanelA4.SetActive(false);
        SuperScroll.NextScreen();
        PanelMo1.SetActive(true);
    }
}