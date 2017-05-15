using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

//Script pas utilisé car error au premier lancement (marche sinon)
public class ModuleOuHistorique : MonoBehaviour
{
    public HorizontalScrollSnap scrollHorizontal;
    private int lul;

    void Awake()
    {
        lul = GlobalControl.Instance.moduleOuHistorique;
        Debug.Log(lul);
        scrollHorizontal.StartingScreen = GlobalControl.Instance.moduleOuHistorique;
    }

    public void BeenClicked()
    {
        GlobalControl.Instance.moduleOuHistorique = scrollHorizontal.CurrentPage;
    }
}