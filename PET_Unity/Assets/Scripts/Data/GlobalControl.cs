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
    public ParametresModules paramModuleA1 = new ParametresModules();
    public SwitchsModules moduleA2 = new SwitchsModules();
    public ParametresModules paramModuleA2 = new ParametresModules();
    public SwitchsModules moduleC1 = new SwitchsModules();
    public ParametresModules paramModuleC1 = new ParametresModules();
    public SwitchsModules moduleC2 = new SwitchsModules();
    public ParametresModules paramModuleC2 = new ParametresModules();
    public SwitchsModules moduleC3 = new SwitchsModules();
    public ParametresModules paramModuleC3 = new ParametresModules();
    public SwitchsModules moduleC4 = new SwitchsModules();
    public ParametresModules paramModuleC4 = new ParametresModules();
    public SwitchsModules moduleC5 = new SwitchsModules();
    public ParametresModules paramModuleC5 = new ParametresModules();
    public SwitchsModules moduleC6 = new SwitchsModules();
    public ParametresModules paramModuleC6 = new ParametresModules();
    public SwitchsModules moduleE1 = new SwitchsModules();
    public ParametresModules paramModuleE1 = new ParametresModules();
    public SwitchsModules moduleE2 = new SwitchsModules();
    public ParametresModules paramModuleE2 = new ParametresModules();
    public SwitchsModules moduleE3 = new SwitchsModules();
    public ParametresModules paramModuleE3 = new ParametresModules();
    public SwitchsModules moduleE4 = new SwitchsModules();
    public ParametresModules paramModuleE4 = new ParametresModules();
    public SwitchsModules moduleS1 = new SwitchsModules();
    public ParametresModules paramModuleS1 = new ParametresModules();
    public SwitchsModules moduleS2 = new SwitchsModules();
    public ParametresModules paramModuleS2 = new ParametresModules();

    public int derniereCategorie;
    public int moduleOuHistorique;
    public float emplacementScrollVertical;
    public bool ampouleOn;
    public bool priseAOn;
    public bool priseBOn;
    public string nomPingouin;

    public ParametresTaches taches = new ParametresTaches();
    

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