using UnityEngine;
using System.Collections;

public class ButtonMenuIcon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        DataLevel.Instance.ReguestMenuSatePanel();
    }
}
