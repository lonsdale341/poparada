using UnityEngine;
using System.Collections;

public class ButtonGoWebsite : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        Application.OpenURL("http://poparada.com.ua/");
    }
}
