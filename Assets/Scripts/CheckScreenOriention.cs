using UnityEngine;
using System.Collections;

public class CheckScreenOriention : MonoBehaviour
{
    public GameObject Plank_Land;
    public GameObject Exit_Land;
    public GameObject Plank_Port;
    public GameObject Exit_Potr;
    public GameObject Pr_P_P;
    public GameObject Pr_P_L;
    public GameObject Pr_L_L;
    public GameObject Pr_L_P;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (DataLevel.Instance.StateOrientationScreen==0)
	    {
	        Pr_P_P.SetActive(false);
            Pr_P_L.SetActive(false);
            Pr_L_L.SetActive(false);
            Pr_L_P.SetActive(false);
	    }
        if (DataLevel.Instance.StateOrientationScreen == 1)
        {
            Pr_P_P.SetActive(false);
            Pr_P_L.SetActive(true);
            Pr_L_L.SetActive(true);
            Pr_L_P.SetActive(false);
        }
        if (DataLevel.Instance.StateOrientationScreen == 2)
        {
            Pr_P_P.SetActive(true);
            Pr_P_L.SetActive(false);
            Pr_L_L.SetActive(false);
            Pr_L_P.SetActive(true);
        }
        if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
	    {
            Plank_Land.SetActive(false);
            Exit_Land.SetActive(false);
            Plank_Port.SetActive(true);
            Exit_Potr.SetActive(true);
	    }
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            Plank_Land.SetActive(true);
            Exit_Land.SetActive(true);
            Plank_Port.SetActive(false);
            Exit_Potr.SetActive(false);
        }
	}
}
