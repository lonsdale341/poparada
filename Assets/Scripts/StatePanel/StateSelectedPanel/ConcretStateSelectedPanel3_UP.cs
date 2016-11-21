using UnityEngine;
using System.Collections;

class ConcretStateSelectedPanel3_UP : StateSelectedPanel3_UP
{

    public ConcretStateSelectedPanel3_UP(int mode)
    {
        
       
        switch (DataLevel.Instance.NumberModel)
        {
            case 0:

                break;
            case 1:
                DataLevel.Instance.CurrentShader_Flower_UP = mode;
                for (int i = 0; i < DataLevel.Instance.check_box_Panel3_UP.Length; i++)
                {
                    DataLevel.Instance.check_box_Panel3_UP[i].SetActive(false);
                    if (i == DataLevel.Instance.CurrentShader_Flower_UP)
                    {
                        DataLevel.Instance.check_box_Panel3_UP[i].SetActive(true);
                    }
                }
                Material[] mats_1 = DataLevel.Instance.ChangedFlower_UP.GetComponent<Renderer>().materials;
                mats_1[0] = DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Flower_UP];
                DataLevel.Instance.ChangedFlower_UP.GetComponent<Renderer>().materials = mats_1;
                break;
            case 2:
                 DataLevel.Instance.CurrentShader_Comfort_UP = mode;
                for (int i = 0; i < DataLevel.Instance.check_box_Panel3_UP.Length; i++)
                {
                    DataLevel.Instance.check_box_Panel3_UP[i].SetActive(false);
                    if (i == DataLevel.Instance.CurrentShader_Comfort_UP)
                    {
                        DataLevel.Instance.check_box_Panel3_UP[i].SetActive(true);
                    }
                }
                Material[] mats_2 = DataLevel.Instance.ChangedComfort_UP.GetComponent<Renderer>().materials;
                mats_2[0] = DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Comfort_UP];
                DataLevel.Instance.ChangedComfort_UP.GetComponent<Renderer>().materials = mats_2;
                break;
            case 3:
                 DataLevel.Instance.CurrentShader_Sofa_UP = mode;
                for (int i = 0; i < DataLevel.Instance.check_box_Panel3_UP.Length; i++)
                {
                    DataLevel.Instance.check_box_Panel3_UP[i].SetActive(false);
                    if (i == DataLevel.Instance.CurrentShader_Sofa_UP)
                    {
                        DataLevel.Instance.check_box_Panel3_UP[i].SetActive(true);
                    }
                }
                 Material[] mats_3 = DataLevel.Instance.ChangedSofa_UP.GetComponent<Renderer>().materials;
                 mats_3[0] = DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Sofa_UP];
                 DataLevel.Instance.ChangedSofa_UP.GetComponent<Renderer>().materials = mats_3;
                break;
        }

    }
}