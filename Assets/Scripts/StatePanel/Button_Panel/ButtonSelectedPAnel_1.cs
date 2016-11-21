using UnityEngine;
using System.Collections;

public class ButtonSelectedPAnel_1 : MonoBehaviour
{
    public int Mode;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnClick()
    {
        DataLevel.Instance.ReguestSelectedPanel_1(Mode);
    }
}
