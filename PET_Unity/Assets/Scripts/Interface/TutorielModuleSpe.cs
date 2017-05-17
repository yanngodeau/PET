using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class TutorielModuleSpe : MonoBehaviour
{
    public GameObject PanelMo1;
    public GameObject PanelMo2;
    public GameObject PanelC1;
    public HorizontalScrollSnap SuperScroll;

    public void Mo1()
    {
        PanelMo1.SetActive(false);
        PanelMo2.SetActive(true);
    }

    public void Mo2()
    {
        PanelMo2.SetActive(false);
        SuperScroll.NextScreen();
        PanelC1.SetActive(true);
    }
}