using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModulesGrisesAutomatisation : MonoBehaviour {

    public bool isOn;
    public GameObject PanelOn;
    public GameObject PanelOff;

	// Use this for initialization
	void Start () {
        isOn = GlobalControl.Instance.ModuleOn;
        if (!isOn)
        {
            PanelOn.SetActive(isOn);
            PanelOff.SetActive(!isOn);
        }
    }

}
