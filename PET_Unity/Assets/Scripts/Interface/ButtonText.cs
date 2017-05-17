using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonText : MonoBehaviour {

    public ParametresModules paramModules = new ParametresModules();

    public bool TextOn;
    public Text MyText;
    public Color ColorOff;
    public Color ColorOn;
    public Button MyButton;
    public Color buttonOff;
    public Color buttonOn;
    public int jour;

    void Start()
    {
        paramModules = SelectScene();
        switch (jour)
        {
            case 1:
                TextOn = paramModules.lundiOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
            case 2:
                TextOn = paramModules.mardiOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
            case 3:
                TextOn = paramModules.mercrediOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
            case 4:
                TextOn = paramModules.jeudiOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
            case 5:
                TextOn = paramModules.vendrediOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
            case 6:
                TextOn = paramModules.samediOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
            case 7:
                TextOn = paramModules.dimancheOn;
                MyText.color = TextOn ? ColorOn : ColorOff;
                MyButton.image.color = TextOn ? buttonOn : buttonOff;
                break;
        }
    }

    public void BeenClicked()
    {
        TextOn = !TextOn;
        MyText.color = TextOn ? ColorOn : ColorOff;
        MyButton.image.color = TextOn ? buttonOn : buttonOff;
        switch (jour){
            case 1:
                paramModules.lundiOn = TextOn;
                break;
            case 2:
                paramModules.mardiOn = TextOn;
                break;
            case 3:
                paramModules.mercrediOn = TextOn;
                break;
            case 4:
                paramModules.jeudiOn = TextOn;
                break;
            case 5:
                paramModules.vendrediOn = TextOn;
                break;
            case 6:
                paramModules.samediOn = TextOn;
                break;
            case 7:
                paramModules.dimancheOn = TextOn;
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