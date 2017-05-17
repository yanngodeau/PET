using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfficherNomPingouin : MonoBehaviour {

    public Text nom;

	// Use this for initialization
	void Start () {
        nom.text = "<" + GlobalControl.Instance.nomPingouin + ">";
	}
}
