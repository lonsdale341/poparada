using UnityEngine;
using System.Collections;

 class StateActivePanel_MenuSite2_On :StatePanel
{
     public StateActivePanel_MenuSite2_On()
	{
        DataLevel.Instance.MenuIconSate2.SetActive(false);
        DataLevel.Instance.MenuSate2.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_MenuSite2_Off();
    }
}
