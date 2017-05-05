using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownPanel : MonoBehaviour {

    public Dropdown superdropdown;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    public void BeenClicked()
    {
        if (superdropdown.value == 0)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
        }
        else if (superdropdown.value == 1)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            panel3.SetActive(false);
            panel4.SetActive(false);
        }
        else if (superdropdown.value == 2)
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(true);
            panel4.SetActive(false);
        }
        else if (superdropdown.value == 3)
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(true);
        }
    }
}
