using UnityEngine;
using System.Collections;

public class ButtonRunCamera : MonoBehaviour
{
    public DemoScript Demo;
    public AudioSource sound;
    public UIRoot Root;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        sound.Play();

        DataLevel.Instance.ReguestSetActivePanel_CAmera();
        if (Screen.orientation == ScreenOrientation.LandscapeLeft)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            DataLevel.Instance.StateOrientationScreen = 1;
        }
        if (Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            Screen.orientation = ScreenOrientation.LandscapeRight;
            DataLevel.Instance.StateOrientationScreen = 1;
        }
        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
            DataLevel.Instance.StateOrientationScreen = 2;
        }
        if (Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            Screen.orientation = ScreenOrientation.PortraitUpsideDown;
            DataLevel.Instance.StateOrientationScreen = 2;
        }
        Demo.OnSaveScreenshotPress();
        //  DataLevel.Instance.ReguestSetActivePanel_Foto();

    }
}
