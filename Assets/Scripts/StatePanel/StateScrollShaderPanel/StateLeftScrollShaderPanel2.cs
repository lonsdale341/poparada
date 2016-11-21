using UnityEngine;
using System.Collections;

class StateLeftScrollShaderPanel2 : StatePanel
{
    public StateLeftScrollShaderPanel2()
    {
        
        TweenPosition.Begin(DataLevel.Instance.ScrollPanel2, 0.2f, new Vector3(-1700f * (DataLevel.Instance.CurrentBlockPanel_2 - 1), 0, 0));
        if (DataLevel.Instance.CurrentBlockPanel_2 == 1)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel2.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel2[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel2[0].SetActive(true);
        }
        if (DataLevel.Instance.CurrentBlockPanel_2 > 1)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel2.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel2[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel2[1].SetActive(true);
        }
        if (DataLevel.Instance.CurrentBlockPanel_2 > 3)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel2.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel2[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel2[2].SetActive(true);
        }
        if (DataLevel.Instance.CurrentBlockPanel_2 > 6)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel2.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel2[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel2[3].SetActive(true);
        }
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateRightScrollShaderPanel2();
    }
}
