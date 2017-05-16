using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache2 : MonoBehaviour
{

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public Button button;
    public GameObject popup;

    // Use this for initialization
    void Start()
    {

    }

    public void BeenClicked()
    {
        if (!taches.tache2Terminee)
        {
            taches.tache2Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
