using UnityEngine;
using System.Collections;

class StateActivePanel_Foto_On : StatePanel
{

    public StateActivePanel_Foto_On()
    {
        DataLevel.Instance.screenFoto.SetActive(true);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_Foto_Off();
    }
}
