using UnityEngine;
using System.Collections;

class StateActivePanel_2_Off : StatePanel
{
    public StateActivePanel_2_Off()
     {
         DataLevel.Instance.Screen2.SetActive(false);
     }

     public override void Handle(ContextStatePanel context)
     {
         context.State=new StateActivePanel_2_On();
     }
}
