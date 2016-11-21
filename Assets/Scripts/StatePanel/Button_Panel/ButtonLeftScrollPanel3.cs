using UnityEngine;
using System.Collections;

public class ButtonLeftScrollPanel3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnClick()
    {
        DataLevel.Instance.CurrentBlockPanel_3--;

        DataLevel.Instance.ReguestArrowPanel3();
        DataLevel.Instance.ReguestScrollPanel3();
    }
}
