using UnityEngine;
using System.Collections;

 class StateActivePanel_Exit_Off : StatePanel {
     public StateActivePanel_Exit_Off()
     {
         DataLevel.Instance.screenExit_App.SetActive(false);
     }
     public override void Handle(ContextStatePanel context)
     {
         context.State=new StateActivePanel_Exit_On();
     }
 }
