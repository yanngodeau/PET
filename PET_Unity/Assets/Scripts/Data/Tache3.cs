using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache3 : MonoBehaviour
{

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public GameObject popup;

    // Use this for initialization
    void Start()
    {
        if (!taches.tache3Terminee)
        {
            taches.tache3Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
