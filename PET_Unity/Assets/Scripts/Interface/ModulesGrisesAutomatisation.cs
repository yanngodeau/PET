using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModulesGrisesAutomatisation : MonoBehaviour {

   // private SwitchsModules boolmodules = new SwitchsModules();
    public Color moduleAOn;
    public Color moduleAOff;
    public Color moduleCOn;
    public Color moduleCOff;
    public Color moduleEOn;
    public Color moduleEOff;
    public Color moduleSOn;
    public Color moduleSOff;
    public Image moduleA1;
    public Image moduleA2;
    public Image moduleA3;
    public Image moduleA4;
    public Image moduleC1;
    public Image moduleC2;
    public Image moduleC3;
    public Image moduleC4;
    public Image moduleC5;
    public Image moduleC6;
    public Image moduleC7;
    public Image moduleC8;
    public Image moduleC9;
    public Image moduleC10;
    public Image moduleC11;
    public Image moduleC12;
    public Image moduleE1;
    public Image moduleE2;
    public Image moduleE3;
    public Image moduleE4;
    public Image moduleE5;
    public Image moduleE6;
    public Image moduleE7;
    public Image moduleE8;
    public Image moduleS1;
    public Image moduleS2;
    public Image moduleS3;
    public Image moduleS4;

    
    // Use this for initialization
    void Start () {

        


        //moduleA1
        if (GlobalControl.Instance.moduleA1.SwitchPrincipal)
        {
            moduleA1.color = moduleAOn;
            moduleA3.color = moduleAOn;
        }
        else
        {
            moduleA1.color = moduleAOff;
            moduleA3.color = moduleAOff;
        }
        //moduleA2
        if (GlobalControl.Instance.moduleA2.SwitchPrincipal)
        {
            moduleA2.color = moduleAOn;
            moduleA4.color = moduleAOn;
        }
        else
        {
            moduleA2.color = moduleAOff;
            moduleA4.color = moduleAOff;
        }
        //moduleC1
        if (GlobalControl.Instance.moduleC1.SwitchPrincipal)
        {
            moduleC1.color = moduleCOn;
            moduleC7.color = moduleCOn;
        }
        else
        {
            moduleC1.color = moduleCOff;
            moduleC7.color = moduleCOff;
        }
        //moduleC2
        if (GlobalControl.Instance.moduleC2.SwitchPrincipal)
        {
            moduleC2.color = moduleCOn;
            moduleC8.color = moduleCOn;
        }
        else
        {
            moduleC2.color = moduleCOff;
            moduleC8.color = moduleCOff;
        }
        //moduleC3
        if (GlobalControl.Instance.moduleC3.SwitchPrincipal)
        {
            moduleC3.color = moduleCOn;
            moduleC9.color = moduleCOn;
        }
        else
        {
            moduleC3.color = moduleCOff;
            moduleC9.color = moduleCOff;
        }
        //moduleC4
        if (GlobalControl.Instance.moduleC4.SwitchPrincipal)
        {
            moduleC4.color = moduleCOn;
            moduleC10.color = moduleCOn;
        }
        else
        {
            moduleC4.color = moduleCOff;
            moduleC10.color = moduleCOff;
        }
        //moduleC5
        if (GlobalControl.Instance.moduleC5.SwitchPrincipal)
        {
            moduleC5.color = moduleCOn;
            moduleC11.color = moduleCOn;
        }
        else
        {
            moduleC5.color = moduleCOff;
            moduleC11.color = moduleCOff;
        }
        //moduleC6
        if (GlobalControl.Instance.moduleC6.SwitchPrincipal)
        {
            moduleC6.color = moduleCOn;
            moduleC12.color = moduleCOn;
        }
        else
        {
            moduleC6.color = moduleCOff;
            moduleC12.color = moduleCOff;
        }
        //moduleE1
        if (GlobalControl.Instance.moduleE1.SwitchPrincipal)
        {
            moduleE1.color = moduleEOn;
            moduleE5.color = moduleEOn;
        }
        else
        {
            moduleE1.color = moduleEOff;
            moduleE5.color = moduleEOff;
        }
        //moduleE2
        if (GlobalControl.Instance.moduleE2.SwitchPrincipal)
        {
            moduleE2.color = moduleEOn;
            moduleE6.color = moduleEOn;
        }
        else
        {
            moduleE2.color = moduleEOff;
            moduleE6.color = moduleEOff;
        }
        //moduleE3
        if (GlobalControl.Instance.moduleE3.SwitchPrincipal)
        {
            moduleE3.color = moduleEOn;
            moduleE7.color = moduleEOn;
        }
        else
        {
            moduleE3.color = moduleEOff;
            moduleE7.color = moduleEOff;
        }
        //moduleE4
        if (GlobalControl.Instance.moduleE4.SwitchPrincipal)
        {
            moduleE4.color = moduleEOn;
            moduleE8.color = moduleEOn;
        }
        else
        {
            moduleE4.color = moduleEOff;
            moduleE8.color = moduleEOff;
        }
        //moduleS1
        if (GlobalControl.Instance.moduleS1.SwitchPrincipal)
        {
            moduleS1.color = moduleSOn;
            moduleS3.color = moduleSOn;
        }
        else
        {
            moduleS1.color = moduleSOff;
            moduleS3.color = moduleSOff;
        }
        //moduleS2
        if (GlobalControl.Instance.moduleS2.SwitchPrincipal)
        {
            moduleS2.color = moduleSOn;
            moduleS4.color = moduleSOn;
        }
        else
        {
            moduleS2.color = moduleSOff;
            moduleS4.color = moduleSOff;
        }



    }

    

   /* public SwitchsModules choixModule(string nomModule)
    {
        switch (nomModule)
        {
            case ("moduleA1"):
                boolmodules = GlobalControl.Instance.moduleA1;
                break;
            case ("moduleA2"):
                boolmodules = GlobalControl.Instance.moduleA2;
                break;
            case ("moduleC1"):
                boolmodules = GlobalControl.Instance.moduleC1;
                break;
            case ("moduleC2"):
                boolmodules = GlobalControl.Instance.moduleC2;
                break;
            case ("moduleC3"):
                boolmodules = GlobalControl.Instance.moduleC3;
                break;
            case ("moduleC4"):
                boolmodules = GlobalControl.Instance.moduleC4;
                break;
            case ("moduleC5"):
                boolmodules = GlobalControl.Instance.moduleC5;
                break;
            case ("moduleC6"):
                boolmodules = GlobalControl.Instance.moduleC6;
                break;
            case ("moduleE1"):
                boolmodules = GlobalControl.Instance.moduleE1;
                break;
            case ("moduleE2"):
                boolmodules = GlobalControl.Instance.moduleE2;
                break;
            case ("moduleE3"):
                boolmodules = GlobalControl.Instance.moduleE3;
                break;
            case ("moduleE4"):
                boolmodules = GlobalControl.Instance.moduleE4;
                break;
            case ("moduleS1"):
                boolmodules = GlobalControl.Instance.moduleS1;
                break;
            case ("moduleS2"):
                boolmodules = GlobalControl.Instance.moduleS2;
                break;
        }
        return boolmodules;
    }*/
}
