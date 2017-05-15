using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SauvegarderDonneesDropdown : MonoBehaviour
{
    public ParametresModules paramModules = new ParametresModules();

    //0 pour location/autre, 1 pour heureD, 2 pour minD, 3 pour heureF, 4 pour minF
    public int typeDropdown;

    public Dropdown dropdown;


    // Use this for initialization
    void Start()
    {
        paramModules = SelectScene();
        switch (typeDropdown)
        {
            case 0:
                dropdown.value = paramModules.valeurDropdown;
                break;
            case 1:
                dropdown.value = paramModules.heureDebut;
                break;
            case 2:
                dropdown.value = paramModules.minuteDebut;
                break;
            case 3:
                dropdown.value = paramModules.heureFin;
                break;
            case 4:
                dropdown.value = paramModules.minuteFin;
                break;
        }
    }

    public void BeenClicked()
    {
        switch (typeDropdown)
        {
            case 0:
                paramModules.valeurDropdown = dropdown.value;
                break;
            case 1:
                paramModules.heureDebut = dropdown.value;
                break;
            case 2:
                paramModules.minuteDebut = dropdown.value;
                break;
            case 3:
                paramModules.heureFin = dropdown.value;
                break;
            case 4:
                paramModules.minuteFin = dropdown.value;
                break;
        }
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