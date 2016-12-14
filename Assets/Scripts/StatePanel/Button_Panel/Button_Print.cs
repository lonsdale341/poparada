using UnityEngine;
using System.Collections;

public class Button_Print : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        
        Application.OpenURL("https://goo.gl/r8xDpR");
    }
}
