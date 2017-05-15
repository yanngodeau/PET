using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SauvegarderDonneesModule : MonoBehaviour
{
    public ParametresModules paramModules = new ParametresModules();
    public bool dropdown;
    public bool jours;
    public bool heure1;
    public bool heure2;


    // Use this for initialization
    void Start()
    {
        paramModules = SelectScene();
    }


    private ParametresModules SelectScene()
    {
        Scene sceneactuelle;
        sceneactuelle = SceneManager.GetActiveScene();
        switch (sceneactuelle.name)
        {
            case "SceneAutomatisationModuleA1":
                paramModules = GlobalControl.Instance.paramModuleA1;
                break;
            case "SceneAutomatisationModuleA2":
                paramModules = GlobalControl.Instance.paramModuleA2;
                break;
            case "SceneAutomatisationModuleC1":
                paramModules = GlobalControl.Instance.paramModuleC1;
                break;
            case "SceneAutomatisationModuleC2":
                paramModules = GlobalControl.Instance.paramModuleC2;
                break;
            case "SceneAutomatisationModuleC3":
                paramModules = GlobalControl.Instance.paramModuleC3;
                break;
            case "SceneAutomatisationModuleC4":
                paramModules = GlobalControl.Instance.paramModuleC4;
                break;
            case "SceneAutomatisationModuleC5":
                paramModules = GlobalControl.Instance.paramModuleC5;
                break;
            case "SceneAutomatisationModuleC6":
                paramModules = GlobalControl.Instance.paramModuleC6;
                break;
            case "SceneAutomatisationModuleE1":
                paramModules = GlobalControl.Instance.paramModuleE1;
                break;
            case "SceneAutomatisationModuleE2":
                paramModules = GlobalControl.Instance.paramModuleE2;
                break;
            case "SceneAutomatisationModuleE3":
                paramModules = GlobalControl.Instance.paramModuleE3;
                break;
            case "SceneAutomatisationModuleE4":
                paramModules = GlobalControl.Instance.paramModuleE4;
                break;
            case "SceneAutomatisationModuleS1":
                paramModules = GlobalControl.Instance.paramModuleS1;
                break;
            case "SceneAutomatisationModuleS2":
                paramModules = GlobalControl.Instance.paramModuleS2;
                break;
        }

        return paramModules;
    }
}