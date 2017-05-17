using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangerImagePingouin : MonoBehaviour {

    public Image pingouin;

    public Sprite pingouinHappy;
    public Sprite pingouinSad;
    public Sprite pingouinWtf;
    private int i = 0;
    

	public void BeenClicked()
    {
        switch (i)
        {
            case 0:
                pingouin.sprite = pingouinWtf;
                i++;
                break;
            case 1:
                pingouin.sprite = pingouinSad;
                i++;
                break;
            case 2:
                pingouin.sprite = pingouinHappy;
                i = 0;
                break;
        }
    }
}
