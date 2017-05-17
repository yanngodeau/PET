using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TachesTerminees : MonoBehaviour
{

    public ParametresTaches paramTaches = new ParametresTaches();
    public GameObject victoryPanel;

    // Use this for initialization
    void Start()
    {
        paramTaches = GlobalControl.Instance.taches;
        if (paramTaches.tache1Terminee && paramTaches.tache2Terminee && paramTaches.tache3Terminee && paramTaches.tache4Terminee && paramTaches.tache5Terminee && paramTaches.tache6Terminee && paramTaches.tache7Terminee && paramTaches.tache8Terminee)
        {
            victoryPanel.SetActive(true);
        }

    }

    public void BeenClicked()
    {
        victoryPanel.SetActive(false);
    }

}