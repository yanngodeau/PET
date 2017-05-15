using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownPanelAuto : MonoBehaviour
{

    public Dropdown superdropdown;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public int derniereCategorie;

    void Start()
    {
        //se place dans la bonne categorie
        superdropdown.value = GlobalControl.Instance.derniereCategorie;
        BeenClicked();
    }


    public void BeenClicked()
    {
        if (superdropdown.value == 0)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
            panel5.SetActive(false);
        }
        else if (superdropdown.value == 1)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            panel3.SetActive(false);
            panel4.SetActive(false);
            panel5.SetActive(false);
        }
        else if (superdropdown.value == 2)
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(true);
            panel4.SetActive(false);
            panel5.SetActive(false);
        }
        else if (superdropdown.value == 3)
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(true);
            panel5.SetActive(false);
        }
        else if (superdropdown.value == 4)
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
            panel5.SetActive(true);
        }
        GlobalControl.Instance.derniereCategorie = superdropdown.value;
    }
}
