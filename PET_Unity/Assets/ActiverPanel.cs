using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiverPanel : MonoBehaviour {

    public bool ModuleOn = false;
    public GameObject Superpanel;

    public void BeenClicked()
    {
        ModuleOn = !ModuleOn;
        if (ModuleOn)
        {
            Superpanel.SetActive(false);
        }
        else
        {
            Superpanel.SetActive(true);
        }
    }


}
