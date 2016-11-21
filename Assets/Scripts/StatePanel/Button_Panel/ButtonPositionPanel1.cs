using UnityEngine;
using System.Collections;

public class ButtonPositionPanel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DataLevel.Instance.ReguestSetActivePanel_ExitApp();
            DataLevel.Instance.ReguestSetActivePanel_1();
        }
	
	}
    void OnClick()
    {
        DataLevel.Instance.ReguestPositionPanel_1();
    }
}
