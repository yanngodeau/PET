using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache8 : MonoBehaviour
{

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public GameObject popup;

    // Use this for initialization
    void Start()
    {
        if (!taches.tache8Terminee)
        {
            taches.tache8Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
