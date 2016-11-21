using UnityEngine;
using System.Collections;

 class StateRightScrollShaderPanel3 : StatePanel
{
     public StateRightScrollShaderPanel3()
    {
        
        TweenPosition.Begin(DataLevel.Instance.ScrollPanel3, 0.2f, new Vector3(-1700f * (DataLevel.Instance.CurrentBlockPanel_3 - 1), 0, 0));
        if (DataLevel.Instance.CurrentBlockPanel_3 == 1)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel3.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel3[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel3[0].SetActive(true);
        }
        if (DataLevel.Instance.CurrentBlockPanel_3 > 1)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel3.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel3[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel3[1].SetActive(true);
        }
        if (DataLevel.Instance.CurrentBlockPanel_3 > 3)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel3.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel3[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel3[2].SetActive(true);
        }
        if (DataLevel.Instance.CurrentBlockPanel_3 > 6)
        {
            for (int i = 0; i < DataLevel.Instance.Label_Text_Panel3.Length; i++)
            {
                DataLevel.Instance.Label_Text_Panel3[i].SetActive(false);
            }
            DataLevel.Instance.Label_Text_Panel3[3].SetActive(true);
        }
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateRightScrollShaderPanel3();
    }
}
