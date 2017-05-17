using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class TutorielConso : MonoBehaviour
{
    public GameObject PanelC1;
    public GameObject PanelC2;
    public GameObject PanelC3;
    public HorizontalScrollSnap SuperScroll;

    public void C1()
    {
        PanelC1.SetActive(false);
        PanelC2.SetActive(true);
        PanelC3.SetActive(false);
    }
    public void C2()
    {
        PanelC1.SetActive(false);
        PanelC2.SetActive(false);
        PanelC3.SetActive(true);
    }
}