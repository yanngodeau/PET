using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmplacementScroll : MonoBehaviour {

    public ScrollRect scrollVertical;

	// Use this for initialization
	void Start () {
        scrollVertical.verticalNormalizedPosition = GlobalControl.Instance.emplacementScrollVertical;
	}
	
	public void BeenClicked()
    {
        GlobalControl.Instance.emplacementScrollVertical = scrollVertical.verticalNormalizedPosition;
    }
}
