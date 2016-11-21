using UnityEngine;
using System.Collections;

class StateActivePanel_2_On : StatePanel
{
    public StateActivePanel_2_On()
    {
        DataLevel.Instance.Screen2.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State=new StateActivePanel_2_Off();
    }
}
