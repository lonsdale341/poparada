using UnityEngine;
using System.Collections;

public class ButtonFotoPanel2 : MonoBehaviour
{
    // public GameObject Arrow;
    public DemoScript Demo;
    public AudioSource sound;
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
      // sound.Play();
      if (DataLevel.Instance.Count_Shaders == 1)
      {
          DataLevel.Instance.ReguestSetActivePanel_2();
      }
      if (DataLevel.Instance.Count_Shaders == 2)
      {
          DataLevel.Instance.ReguestSetActivePanel_3();
      }
        Screen.orientation = ScreenOrientation.AutoRotation;
      // Demo.OnSaveScreenshotPress();
      //  DataLevel.Instance.ReguestSetActivePanel_Foto();
        DataLevel.Instance.ReguestSetActivePanel_CAmera();

    }
}
