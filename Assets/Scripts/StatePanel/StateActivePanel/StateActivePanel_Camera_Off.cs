using UnityEngine;
using System.Collections;

 class StateActivePanel_Camera_Off : StatePanel
{
     public StateActivePanel_Camera_Off()
    {
        DataLevel.Instance.sreenCamera.SetActive(false);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_Camera_On();
    }
}
