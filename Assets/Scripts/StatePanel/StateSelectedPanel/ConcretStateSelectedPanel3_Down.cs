using UnityEngine;
using System.Collections;

 class ConcretStateSelectedPanel3_Down  : StateSelectedPanel3_Down
{

     public ConcretStateSelectedPanel3_Down(int mode)
    {
        
        switch (DataLevel.Instance.NumberModel)
        {
            case 0:

                break;
            case 1:
                 DataLevel.Instance.CurrentShader_Flower_Down = mode;
                 for (int i = 0; i < DataLevel.Instance.check_box_Panel3_Down.Length; i++)
                 {
                     DataLevel.Instance.check_box_Panel3_Down[i].SetActive(false);
                     if (i == DataLevel.Instance.CurrentShader_Flower_Down)
                     {
                         DataLevel.Instance.check_box_Panel3_Down[i].SetActive(true);
                     }
                 }
                Material[] mats_1 = DataLevel.Instance.ChangedFlower_Down.GetComponent<Renderer>().materials;
                mats_1[0] = DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Flower_Down];
                DataLevel.Instance.ChangedFlower_Down.GetComponent<Renderer>().materials = mats_1;
                break;
            case 2:
                DataLevel.Instance.CurrentShader_Comfort_Down = mode;
                for (int i = 0; i < DataLevel.Instance.check_box_Panel3_Down.Length; i++)
                {
                    DataLevel.Instance.check_box_Panel3_Down[i].SetActive(false);
                    if (i == DataLevel.Instance.CurrentShader_Comfort_Down)
                    {
                        DataLevel.Instance.check_box_Panel3_Down[i].SetActive(true);
                    }
                }
                Material[] mats_2 = DataLevel.Instance.ChangedComfort_Down.GetComponent<Renderer>().materials;
                mats_2[0] = DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Comfort_Down];
                DataLevel.Instance.ChangedComfort_Down.GetComponent<Renderer>().materials = mats_2;
                break;
            case 3:
                DataLevel.Instance.CurrentShader_Sofa_Down = mode;
                for (int i = 0; i < DataLevel.Instance.check_box_Panel3_Down.Length; i++)
                {
                    DataLevel.Instance.check_box_Panel3_Down[i].SetActive(false);
                    if (i == DataLevel.Instance.CurrentShader_Sofa_Down)
                    {
                        DataLevel.Instance.check_box_Panel3_Down[i].SetActive(true);
                    }
                }
                Material[] mats_3 = DataLevel.Instance.ChangedSofa_Down.GetComponent<Renderer>().materials;
                mats_3[0] = DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Sofa_Down];
                DataLevel.Instance.ChangedSofa_Down.GetComponent<Renderer>().materials = mats_3;
                break;
        }
    }
}