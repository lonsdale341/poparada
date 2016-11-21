using UnityEngine;
using System.Collections;

 class StateActivePanel_MenuSite_On : StatePanel
{
     public StateActivePanel_MenuSite_On()
	{
        DataLevel.Instance.MenuIconSate.SetActive(false);
        DataLevel.Instance.MenuSate.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_MenuSite_Off();
    }
}
