using UnityEngine;
using System.Collections;

 class StateActivePanel_MenuSite2_Off : StatePanel
{
     public StateActivePanel_MenuSite2_Off()
	{
        DataLevel.Instance.MenuIconSate2.SetActive(true);
        DataLevel.Instance.MenuSate2.SetActive(false);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_MenuSite2_On();
    }
}
