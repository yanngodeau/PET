using UnityEngine;
using UnityEngine.UI;

public class ActiverPanel : MonoBehaviour {

    public bool ModuleOn;
    public bool test;
    public GameObject Superpanel;
    public Switch switchModule;

    void Start ()
    {
        ModuleOn = GlobalControl.Instance.ModuleOn;
        Superpanel.SetActive(ModuleOn);
        switchModule.isOn = ModuleOn;
    }

    public void BeenClicked()
    {
        ModuleOn = !ModuleOn;
        Superpanel.SetActive(ModuleOn);
        SavePlayer();
    }

    public void SavePlayer()
    {
        GlobalControl.Instance.ModuleOn = ModuleOn;
    }


}
