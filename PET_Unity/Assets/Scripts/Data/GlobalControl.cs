using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalControl : MonoBehaviour
{
    //variable essentielle
    public static GlobalControl Instance;

    //variables a garder
    public SwitchsModules moduleA1 = new SwitchsModules();

    public SwitchsModules moduleA2 = new SwitchsModules();
    public SwitchsModules moduleC1 = new SwitchsModules();
    public SwitchsModules moduleC2 = new SwitchsModules();
    public SwitchsModules moduleC3 = new SwitchsModules();
    public SwitchsModules moduleC4 = new SwitchsModules();
    public SwitchsModules moduleC5 = new SwitchsModules();
    public SwitchsModules moduleC6 = new SwitchsModules();
    public SwitchsModules moduleE1 = new SwitchsModules();
    public SwitchsModules moduleE2 = new SwitchsModules();
    public SwitchsModules moduleE3 = new SwitchsModules();
    public SwitchsModules moduleE4 = new SwitchsModules();
    public SwitchsModules moduleS1 = new SwitchsModules();
    public SwitchsModules moduleS2 = new SwitchsModules();

    public int derniereCategorie;
    public int moduleOuHistorique;
    public float emplacementScrollVertical;
    public bool ampouleOn;
    public bool priseAOn;
    public bool priseBOn;


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