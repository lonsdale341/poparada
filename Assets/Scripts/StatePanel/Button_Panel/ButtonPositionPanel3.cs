using UnityEngine;
using System.Collections;

public class ButtonPositionPanel3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DataLevel.Instance.ReguestSetActivePanel_3();
            DataLevel.Instance.ReguestSetActivePanel_1();
            DataLevel.Instance.SetMenuSateOff2();
        }
	}
    void OnClick()
    {
        DataLevel.Instance.ReguestPositionPanel_3();
    }
}
