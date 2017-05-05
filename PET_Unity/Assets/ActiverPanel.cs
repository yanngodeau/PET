using UnityEngine;

public class ActiverPanel : MonoBehaviour {

    public bool ModuleOn;
    public GameObject Superpanel;

    public void BeenClicked()
    {
        ModuleOn = !ModuleOn;
        Superpanel.SetActive(!ModuleOn);
    }


}
