using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeProgression : MonoBehaviour {

    public GameObject barreDeProgression;
    public GameObject barreGradient;
    public ParametresTaches paramTaches = new ParametresTaches();
    private Vector3 pos;
    private int i = 0;
    private int decalage;
    private float pourcentage = 0;
    public Text textPourcentage;

    // Use this for initialization
    void Start () {
        paramTaches = GlobalControl.Instance.taches;
        if (paramTaches.tache1Terminee)
            i++;
        if (paramTaches.tache2Terminee)
            i++;
        if (paramTaches.tache3Terminee)
            i++;
        if (paramTaches.tache4Terminee)
            i++;
        if (paramTaches.tache5Terminee)
            i++;
        if (paramTaches.tache6Terminee)
            i++;
        if (paramTaches.tache7Terminee)
            i++;
        if (paramTaches.tache8Terminee)
            i++;

        decalage = i * 56;
        //decalage = i * 112;
        if (i == 8)
            pourcentage = 100;
        else
            pourcentage = i * 12.5f;
        
        textPourcentage.text = pourcentage.ToString() + " %";

        pos = barreGradient.transform.position;
		barreDeProgression.transform.position = new Vector3(pos.x+decalage,pos.y,pos.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
