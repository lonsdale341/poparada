using UnityEngine;
using System.Collections;

class StateActivePanel_1_On : StatePanel
{
    public StateActivePanel_1_On()
    {
        DataLevel.Instance.Screen1.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State=new StateActivePanel_1_Off();
    }
}
