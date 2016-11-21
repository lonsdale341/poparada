using UnityEngine;
using System.Collections;

class StateActivePanel_Foto_Off : StatePanel
{
    public StateActivePanel_Foto_Off()
    {
        DataLevel.Instance.screenFoto.SetActive(false);
    }
    public override void Handle(ContextStatePanel context)
    {
        context.State = new StateActivePanel_Foto_On();
    }
}
