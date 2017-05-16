using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NomPingouin : MonoBehaviour {

    public InputField nom;

	public void BeenClicked()
    {
        GlobalControl.Instance.nomPingouin = nom.text;
    }
}
