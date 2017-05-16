using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tache5 : MonoBehaviour {

    public ParametresTaches taches = GlobalControl.Instance.taches;
    public Dropdown dropdown;
    public GameObject popup;

	// Use this for initialization
	void Start () {
		
	}
	
    public void BeenClicked()
    {
        if (dropdown.value == 4 && !taches.tache5Terminee)
        {
            taches.tache5Terminee = true;
            popup.SetActive(true);
        }
    }

    public void Valider()
    {
        popup.SetActive(false);
    }

}
