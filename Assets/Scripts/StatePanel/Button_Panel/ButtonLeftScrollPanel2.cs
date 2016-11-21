using UnityEngine;
using System.Collections;

public class ButtonLeftScrollPanel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnClick()
    {
        DataLevel.Instance.CurrentBlockPanel_2--;

        DataLevel.Instance.ReguestArrowPanel2();
        DataLevel.Instance.ReguestScrollPanel2();
    }
}
