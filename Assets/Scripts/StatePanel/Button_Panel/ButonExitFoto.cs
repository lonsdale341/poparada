using UnityEngine;
using System.Collections;

public class ButonExitFoto : MonoBehaviour
{
    public UITexture texture;
    public UIRoot Root;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnClick()
    {
       // if (DataLevel.Instance.Count_Shaders==1)
       // {
       //     DataLevel.Instance.ReguestSetActivePanel_2();
       // }
       // if (DataLevel.Instance.Count_Shaders == 2)
       // {
       //     DataLevel.Instance.ReguestSetActivePanel_3();
       // }
        texture.mainTexture = null;
        Screen.orientation = ScreenOrientation.AutoRotation;
        //Root.scalingStyle = UIRoot.Scaling.ConstrainedOnMobiles;

       // Root.manualHeight = Screen.height;
       // Root.manualWidth = Screen.width;
       // Root.fitWidth = true;
        //Root.fitHeight = false;
        DataLevel.Instance.ReguestSetActivePanel_Foto();
       DataLevel.Instance.ReguestSetActivePanel_CAmera();


    }
}
