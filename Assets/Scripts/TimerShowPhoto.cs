using UnityEngine;
using System.Collections;

public class TimerShowPhoto : MonoBehaviour
{
    public float timeLeft=3f;
    public UITexture texture;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 3f;
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
}
