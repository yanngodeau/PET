using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SuperSwitch : MonoBehaviour
{
    //variables de chaque switch

    //cf Serializables
    public SwitchsModules boolmodules = new SwitchsModules();


    public Button boutonOnOff;
    public GameObject panelOff;
    public GameObject panelOn;
    public GameObject textOff;
    public GameObject textOn;
    public int noSwitch;

    private string test;

    private bool activation;

    //Charge les valeurs des booleens du bon module et active le switch en fonction
    void Start()
    {
        boolmodules = SelectSwitch();
        ActiverSwitch(noSwitch);
    }

    //Change la valeur du boolean, change le switch et sauvegarde les nouvelles valeurs
    public void ClickPrincipal()
    {
        boolmodules.SwitchPrincipal = !boolmodules.SwitchPrincipal;
        ActiverSwitch(1);
        //SavePlayer();
    }

    public void ClickSwitch2()
    {
        boolmodules.Switch2 = !boolmodules.Switch2;
        ActiverSwitch(2);
        //SavePlayer();
    }

    public void ClickSwitch3()
    {
        boolmodules.Switch3 = !boolmodules.Switch3;
        ActiverSwitch(3);
        //SavePlayer();
    }

    public void ClickSwitch4()
    {
        boolmodules.Switch4 = !boolmodules.Switch4;
        ActiverSwitch(4);
        //SavePlayer();
    }

    //Partie visuelle du switch
    private void ActiverSwitch(int switchAActiver)
    {
        switch (switchAActiver)
        {
            case 1:
                activation = boolmodules.SwitchPrincipal;
                break;
            case 2:
                activation = boolmodules.Switch2;
                break;
            case 3:
                activation = boolmodules.Switch3;
                break;
            case 4:
                activation = boolmodules.Switch4;
                break;
        }
        panelOn.SetActive(activation);
        textOff.SetActive(activation);
        panelOff.SetActive(!activation);
        textOn.SetActive(!activation);
    }

    private SwitchsModules SelectSwitch()
    {
        Scene sceneactuelle;
        sceneactuelle = SceneManager.GetActiveScene();
        Debug.Log(sceneactuelle.name);
        switch (sceneactuelle.name)
        {
            case "SceneAutomatisationModuleA1":
                boolmodules = GlobalControl.Instance.moduleA1;
                break;
            case "SceneAutomatisationModuleA2":
                boolmodules = GlobalControl.Instance.moduleA2;
                break;
            case "SceneAutomatisationModuleC1":
                boolmodules = GlobalControl.Instance.moduleC1;
                break;
            case "SceneAutomatisationModuleC2":
                boolmodules = GlobalControl.Instance.moduleC2;
                break;
            case "SceneAutomatisationModuleC3":
                boolmodules = GlobalControl.Instance.moduleC3;
                break;
            case "SceneAutomatisationModuleC4":
                boolmodules = GlobalControl.Instance.moduleC4;
                break;
            case "SceneAutomatisationModuleC5":
                boolmodules = GlobalControl.Instance.moduleC5;
                break;
            case "SceneAutomatisationModuleC6":
                boolmodules = GlobalControl.Instance.moduleC6;
                break;
            case "SceneAutomatisationModuleE1":
                boolmodules = GlobalControl.Instance.moduleE1;
                break;
            case "SceneAutomatisationModuleE2":
                boolmodules = GlobalControl.Instance.moduleE2;
                break;
            case "SceneAutomatisationModuleE3":
                boolmodules = GlobalControl.Instance.moduleE3;
                break;
            case "SceneAutomatisationModuleE4":
                boolmodules = GlobalControl.Instance.moduleE4;
                break;
            case "SceneAutomatisationModuleS1":
                boolmodules = GlobalControl.Instance.moduleS1;
                break;
            case "SceneAutomatisationModuleS2":
                boolmodules = GlobalControl.Instance.moduleS2;
                break;
        }

        return boolmodules;
    }

    public void SavePlayer()
    {
        GlobalControl.Instance.moduleA1 = boolmodules;
    }
}