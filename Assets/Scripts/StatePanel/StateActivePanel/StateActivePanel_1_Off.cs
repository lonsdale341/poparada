using UnityEngine;
using System.Collections;

 class StateActivePanel_1_Off : StatePanel {
     public StateActivePanel_1_Off()
     {
         DataLevel.Instance.Screen1.SetActive(false);
     }

     public override void Handle(ContextStatePanel context)
     {
         context.State=new StateActivePanel_1_On();
     }
 }
