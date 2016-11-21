using UnityEngine;
using System.Collections;

public class ButtonExitApp : MonoBehaviour
{
    public bool Yes_No;
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
        if (Yes_No)
        {
            Application.Quit();
        }
        else
        {
            DataLevel.Instance.ReguestSetActivePanel_ExitApp();
            DataLevel.Instance.ReguestSetActivePanel_1();

        }
    }
}
