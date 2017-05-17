using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListeTaches : MonoBehaviour {

    public ParametresTaches taches = GlobalControl.Instance.taches;

    public GameObject Tache1Check;
    public GameObject Tache1Help;
    public GameObject Tache2Check;
    public GameObject Tache2Help;
    public GameObject Tache3Check;
    public GameObject Tache3Help;
    public GameObject Tache4Check;
    public GameObject Tache4Help;
    public GameObject Tache5Check;
    public GameObject Tache5Help;
    public GameObject Tache6Check;
    public GameObject Tache6Help;
    public GameObject Tache7Check;
    public GameObject Tache7Help;
    public GameObject Tache8Check;
    public GameObject Tache8Help;




    void Start () {
        Tache1Check.SetActive(taches.tache1Terminee);
        Tache1Help.SetActive(!taches.tache1Terminee);
        Tache2Check.SetActive(taches.tache2Terminee);
        Tache2Help.SetActive(!taches.tache2Terminee);
        Tache3Check.SetActive(taches.tache3Terminee);
        Tache3Help.SetActive(!taches.tache3Terminee);
        Tache4Check.SetActive(taches.tache4Terminee);
        Tache4Help.SetActive(!taches.tache4Terminee);
        Tache5Check.SetActive(taches.tache5Terminee);
        Tache5Help.SetActive(!taches.tache5Terminee);
        Tache6Check.SetActive(taches.tache6Terminee);
        Tache6Help.SetActive(!taches.tache6Terminee);
        Tache7Check.SetActive(taches.tache7Terminee);
        Tache7Help.SetActive(!taches.tache7Terminee);
        Tache8Check.SetActive(taches.tache8Terminee);
        Tache8Help.SetActive(!taches.tache8Terminee);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
