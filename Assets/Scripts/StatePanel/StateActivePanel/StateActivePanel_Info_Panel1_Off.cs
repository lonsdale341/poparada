using UnityEngine;
using System.Collections;

 class StateActivePanel_Info_Panel1_Off :StatePanel {
     public StateActivePanel_Info_Panel1_Off()
     {
         DataLevel.Instance.screenInfoPanel_1.SetActive(false);
     }

     public override void Handle(ContextStatePanel context)
     {
         context.State = new StateActivePanel_Info_Panel1_On();
     }
 }
