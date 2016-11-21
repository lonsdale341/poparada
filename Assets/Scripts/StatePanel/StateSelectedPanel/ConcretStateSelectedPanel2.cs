using UnityEngine;
using System.Collections;

 class ConcretStateSelectedPanel2 : StateSelectedPanel2
{

	public ConcretStateSelectedPanel2(int mode)
	{
	    DataLevel.Instance.CurrentShaderPanel2 = mode;
        for (int i = 0; i < DataLevel.Instance.check_box_Panel2.Length; i++)
        {
            DataLevel.Instance.check_box_Panel2[i].SetActive(false);
            if (i == mode)
            {
                DataLevel.Instance.check_box_Panel2[i].SetActive(true);
            }
        }
        Material[] mats = DataLevel.Instance.ChangedPoparada.GetComponent<Renderer>().materials;
	    mats[0] = DataLevel.Instance.Matrerials[mode];
        DataLevel.Instance.ChangedPoparada.GetComponent<Renderer>().materials = mats;
    }
}
