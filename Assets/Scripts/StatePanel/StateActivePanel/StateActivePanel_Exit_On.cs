using UnityEngine;
using System.Collections;

class StateActivePanel_Exit_On : StatePanel {
    public StateActivePanel_Exit_On()
    {
        DataLevel.Instance.screenExit_App.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State=new StateActivePanel_Exit_Off();
    }
}
