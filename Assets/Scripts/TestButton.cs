using UnityEngine;
using System.Collections;

public class TestButton : MonoBehaviour
{
    public GameObject Panel;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        TweenPosition.Begin(Panel, 0.2f, new Vector3(Panel.transform.position.x, Panel.transform.position.y - 900, Panel.transform.position.z));
        Debug.Log("Click");
    }
}
