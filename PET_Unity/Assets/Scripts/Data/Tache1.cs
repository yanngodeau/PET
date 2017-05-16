using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache1 : MonoBehaviour {

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public Dropdown dropdown;
    public GameObject popup;

	// Use this for initialization
	void Start () {
		
	}
	
    public void BeenClicked()
    {
        if (dropdown.value == 3 && !taches.tache1Terminee)
        {
            taches.tache1Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
