using UnityEngine;
using System.Collections;

 class StateActivePanel_Camera_On : StatePanel
{
     public StateActivePanel_Camera_On()
    {
        DataLevel.Instance.sreenCamera.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_Camera_Off();
    }
}
