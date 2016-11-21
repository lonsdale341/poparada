using UnityEngine;
using System.Collections;

public class ButtonGoPanel_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DataLevel.Instance.ReguestSetActivePanel_2();
            DataLevel.Instance.ReguestSetActivePanel_1();
            DataLevel.Instance.SetMenuSateOff();
        }
	}
    void OnClick()
    {
        DataLevel.Instance.ReguestSetActivePanel_2();
        DataLevel.Instance.ReguestSetActivePanel_1();
        DataLevel.Instance.SetMenuSateOff();
    }
}
