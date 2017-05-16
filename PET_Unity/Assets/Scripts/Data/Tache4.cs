using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache4 : MonoBehaviour
{

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public GameObject popup;


    public void BeenClicked()
    {
        if (!taches.tache4Terminee)
        {
            taches.tache4Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
