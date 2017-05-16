using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AfficherAide : MonoBehaviour {

    public GameObject panel;

    public void BeenClicked()
    {
        panel.SetActive(true);
    }

    public void BeenClickedOk()
    {
        panel.SetActive(false);
    }
}
