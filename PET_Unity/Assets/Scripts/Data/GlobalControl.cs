using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalControl : MonoBehaviour {

    //variable essentielle
    public static GlobalControl Instance;

    //variables a garder
    public bool ModuleOn;



    //fonction qui met a jour ce script lorsqu'on charge une scene
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

}
