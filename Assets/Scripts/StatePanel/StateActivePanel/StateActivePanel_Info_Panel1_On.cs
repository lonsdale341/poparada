using UnityEngine;
using System.Collections;

 class StateActivePanel_Info_Panel1_On : StatePanel
{
     public StateActivePanel_Info_Panel1_On()
    {
        DataLevel.Instance.screenInfoPanel_1.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_Info_Panel1_Off();
    }
}