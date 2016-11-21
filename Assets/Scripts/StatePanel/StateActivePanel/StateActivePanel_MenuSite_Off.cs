using UnityEngine;
using System.Collections;

class StateActivePanel_MenuSite_Off : StatePanel
{
    public StateActivePanel_MenuSite_Off()
	{
        DataLevel.Instance.MenuIconSate.SetActive(true);
        DataLevel.Instance.MenuSate.SetActive(false);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_MenuSite_On();
    }
}
