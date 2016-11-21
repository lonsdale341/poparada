using UnityEngine;
using System.Collections;

public class ButtonExitCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DataLevel.Instance.ReguestSetActivePanel_CAmera();
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            if (DataLevel.Instance.Count_Shaders == 1)
            {
                DataLevel.Instance.ReguestSetActivePanel_2();
            }
            if (DataLevel.Instance.Count_Shaders == 2)
            {
                DataLevel.Instance.ReguestSetActivePanel_3();
            }
        }
	
	}
    void OnClick()
    {
        DataLevel.Instance.ReguestSetActivePanel_CAmera();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
       if (DataLevel.Instance.Count_Shaders==1)
       {
           DataLevel.Instance.ReguestSetActivePanel_2();
       }
       if (DataLevel.Instance.Count_Shaders == 2)
       {
           DataLevel.Instance.ReguestSetActivePanel_3();
       }
       
      


    }
}
