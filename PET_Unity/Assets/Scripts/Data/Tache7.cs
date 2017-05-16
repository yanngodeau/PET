using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache7 : MonoBehaviour {

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public Dropdown dropdownH;
    public Dropdown dropdownM;
    public GameObject popup;

	// Use this for initialization
	void Start () {
		
	}
	
    public void BeenClicked()
    {
        if (dropdownH.value == 1 && dropdownM.value == 1 && !taches.tache7Terminee)
        {
            taches.tache7Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
