using UnityEngine;
using System.Collections;

class StateActivePanel_3_On : StatePanel
{
   public StateActivePanel_3_On()
    {
        DataLevel.Instance.Screen3.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State=new StateActivePanel_3_Off();
    }
}
