
using UnityEngine;
using System.Collections;

class ConcretStateSelectedPanel1 : StateSelectedPanel1
{

    public ConcretStateSelectedPanel1(int mode)
    {
        DataLevel.Instance.CurrentNumberModel = mode;
        for (int i = 0; i < DataLevel.Instance.check_box_Panel1.Length; i++)
        {
            DataLevel.Instance.check_box_Panel1[i].SetActive(false);
            if (i == mode)
            {
                DataLevel.Instance.check_box_Panel1[i].SetActive(true);
                
            }
        }
        switch (mode)
        {
            case 0:
                
                DataLevel.Instance.Count_Shaders = 1;
                DataLevel.Instance.NumberModel = 0;
                DataLevel.Instance.CurrentModel = DataLevel.Instance.Oxford;
                DataLevel.Instance.Oxford.SetActive(true);
                DataLevel.Instance.Oxford.transform.localPosition=new Vector3(0,0,0);
                DataLevel.Instance.Oxford.transform.eulerAngles=new Vector3(0,0,0);
                DataLevel.Instance.Oxford.transform.localScale = new Vector3(0.5022258f, 0.5022258f, 0.5022258f);
                DataLevel.Instance.Bond.SetActive(false);
                DataLevel.Instance.Zeus.SetActive(false);
                DataLevel.Instance.Queens.SetActive(false);
                break;
            case 1:
                DataLevel.Instance.Count_Shaders = 2;
                DataLevel.Instance.NumberModel = 1;
                DataLevel.Instance.CurrentModel = DataLevel.Instance.Bond;
                DataLevel.Instance.Oxford.SetActive(false);
                DataLevel.Instance.Bond.SetActive(true);
                DataLevel.Instance.Bond.transform.localPosition=new Vector3(0,0,0);
                DataLevel.Instance.Bond.transform.eulerAngles=new Vector3(0,0,0);
                DataLevel.Instance.Bond.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f);
                DataLevel.Instance.Zeus.SetActive(false);
                DataLevel.Instance.Queens.SetActive(false);
                break;
            case 2:
                DataLevel.Instance.Count_Shaders = 2;
                DataLevel.Instance.NumberModel = 2;
                DataLevel.Instance.CurrentModel = DataLevel.Instance.Zeus;
                DataLevel.Instance.Oxford.SetActive(false);
                DataLevel.Instance.Bond.SetActive(false);
                DataLevel.Instance.Zeus.SetActive(true);
                DataLevel.Instance.Zeus.transform.localPosition=new Vector3(0,0,0);
                DataLevel.Instance.Zeus.transform.eulerAngles=new Vector3(0,0,0);
                DataLevel.Instance.Zeus.transform.localScale = new Vector3(0.175f, 0.175f, 0.175f);
                DataLevel.Instance.Queens.SetActive(false);
                break;
            case 3:
                DataLevel.Instance.Count_Shaders = 2;
                DataLevel.Instance.NumberModel = 3;
                DataLevel.Instance.CurrentModel = DataLevel.Instance.Queens;
                DataLevel.Instance.Oxford.SetActive(false);
                DataLevel.Instance.Bond.SetActive(false);
                DataLevel.Instance.Zeus.SetActive(false);
                DataLevel.Instance.Queens.SetActive(true);
                DataLevel.Instance.Queens.transform.localPosition=new Vector3(0,0,0);
                DataLevel.Instance.Queens.transform.eulerAngles=new Vector3(0,0,0);
                DataLevel.Instance.Queens.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f);
                break;
        }
    }
}
