using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonText : MonoBehaviour, ISelectHandler, IDeselectHandler {

    public Text textui;

	void ISelectHandler.OnSelect(BaseEventData eventData)
    {
        textui.color = new Color(1f, 0.2f, 0.2f);

    }

    void IDeselectHandler.OnDeselect(BaseEventData eventData)
    {
        textui.color = Color.black;
    }
}