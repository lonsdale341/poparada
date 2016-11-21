using UnityEngine;
using System.Collections;

 class StateActivePanel_3_Off : StatePanel
{
     public StateActivePanel_3_Off()
     {
         DataLevel.Instance.Screen3.SetActive(false);
     }

     public override void Handle(ContextStatePanel context)
     {
         context.State=new StateActivePanel_3_On();
     }
}

