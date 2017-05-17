using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class Tutoriel : MonoBehaviour
{
    public GameObject PanelM1;
    public GameObject PanelM2;
    public GameObject PanelM3;
    public GameObject PanelM4;
    public GameObject PanelA1;
    public HorizontalScrollSnap SuperScroll;

    public void M1()
    {
        PanelM1.SetActive(false);
        PanelM2.SetActive(true);
        PanelM3.SetActive(false);
        PanelM4.SetActive(false);
    }
    public void M2()
    {
        PanelM1.SetActive(false);
        PanelM2.SetActive(false);
        PanelM3.SetActive(true);
        PanelM4.SetActive(false);
    }
    public void M3()
    {
        PanelM1.SetActive(false);
        PanelM2.SetActive(false);
        PanelM3.SetActive(false);
        PanelM4.SetActive(true);
    }
    public void M4()
    {
        PanelM4.SetActive(false);
        SuperScroll.NextScreen();
        PanelA1.SetActive(true);
    }
}