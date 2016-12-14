using UnityEngine;
using System.Collections;

public class Buton_Inf_P1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        DataLevel.Instance.ReguestSetActivePanel_1();
        DataLevel.Instance.ReguestSetActivePanel_Info_P1();
    }
}
