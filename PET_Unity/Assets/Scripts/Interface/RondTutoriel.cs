using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class RondTutoriel : MonoBehaviour
{

    public GameObject rond1;
    public GameObject rond2;
    public GameObject rond3;
    public GameObject rond4;
    public GameObject rond5;
    public GameObject rond1p;
    public GameObject rond2p;
    public GameObject rond3p;
    public GameObject rond4p;
    public GameObject rond5p;
    public HorizontalScrollSnap superscroll;
    public int test;

    void start()
    {
        rond1.SetActive(true);
        rond2.SetActive(true);
        rond3.SetActive(true);
        rond4.SetActive(true);
        rond5.SetActive(true);
        rond1p.SetActive(true);
    }

    public void changerpage()
    {
        test++;
        if (superscroll.CurrentPage == 0)
        {
            rond1p.SetActive(true);
            rond2p.SetActive(false);
            rond3p.SetActive(false);
            rond4p.SetActive(false);
            rond5p.SetActive(false);
        }
        else if (superscroll.CurrentPage == 1)
        {
            rond1p.SetActive(false);
            rond2p.SetActive(true);
            rond3p.SetActive(false);
            rond4p.SetActive(false);
            rond5p.SetActive(false);
        }
        else if (superscroll.CurrentPage == 2)
        {
            rond1p.SetActive(false);
            rond2p.SetActive(false);
            rond3p.SetActive(true);
            rond4p.SetActive(false);
            rond5p.SetActive(false);
        }
        else if (superscroll.CurrentPage == 3)
        {
            rond1p.SetActive(false);
            rond2p.SetActive(false);
            rond3p.SetActive(false);
            rond4p.SetActive(true);
            rond5p.SetActive(false);
        }
        else if (superscroll.CurrentPage == 4)
        {
            rond1p.SetActive(false);
            rond2p.SetActive(false);
            rond3p.SetActive(false);
            rond4p.SetActive(false);
            rond5p.SetActive(true);
        }
    }
}
