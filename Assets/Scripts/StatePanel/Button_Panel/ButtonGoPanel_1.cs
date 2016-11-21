using UnityEngine;
using System.Collections;

public class ButtonGoPanel_1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            DataLevel.Instance.ReguestSetActivePanel_ExitApp();
            DataLevel.Instance.ReguestSetActivePanel_1();
        }
    }

    void OnClick()
    {
        switch (DataLevel.Instance.NumberModel)
        {
            case 0:
                DataLevel.Instance.ReguestSetActivePanel_1();
                DataLevel.Instance.ReguestSetActivePanel_2();
                DataLevel.Instance.SetPositionPanel2();
                break;
            case 1:
                DataLevel.Instance.ReguestSetActivePanel_1();
                DataLevel.Instance.ReguestSetActivePanel_3();
                DataLevel.Instance.SetPositionPanel3();
                DataLevel.Instance.SetSelectedPanel3(DataLevel.Instance.CurrentShader_Flower_UP,DataLevel.Instance.CurrentShader_Flower_Down);
                break;
            case 2:
                
                DataLevel.Instance.ReguestSetActivePanel_1();
                DataLevel.Instance.ReguestSetActivePanel_3();
                DataLevel.Instance.SetPositionPanel3();
                DataLevel.Instance.SetSelectedPanel3(DataLevel.Instance.CurrentShader_Comfort_UP, DataLevel.Instance.CurrentShader_Comfort_Down);
                break;
            case 3:
               
                DataLevel.Instance.ReguestSetActivePanel_1();
                DataLevel.Instance.ReguestSetActivePanel_3();
                DataLevel.Instance.SetPositionPanel3();
                DataLevel.Instance.SetSelectedPanel3(DataLevel.Instance.CurrentShader_Sofa_UP, DataLevel.Instance.CurrentShader_Sofa_Down);
                break;
        }
        //if (DataLevel.Instance.Count_Shaders == 1)
        //{
        //    DataLevel.Instance.ReguestSetActivePanel_1();
        //    DataLevel.Instance.ReguestSetActivePanel_2();

        //}
        //else
        //{
        //    DataLevel.Instance.ReguestSetActivePanel_1();
        //    DataLevel.Instance.ReguestSetActivePanel_3();
        //}
    }
}
