using UnityEngine;
using UnityEngine.UI;

public class ActiverPanel : MonoBehaviour {

    public GameObject panelGris;
    public SuperSwitch switchModule;

    void Start ()
    {
        if (switchModule.boolmodules.SwitchPrincipal == false)
        {
            panelGris.SetActive(true);
        }

        //panelGris.SetActive(!switchModule.isOn);
    }

    public void TogglePanel()
    {
        panelGris.SetActive(!switchModule.boolmodules.SwitchPrincipal);
    }


}
