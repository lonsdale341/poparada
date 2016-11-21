using UnityEngine;
using System.Collections;

 class StatePositionUpForPanel1 : StatePanel {

     public StatePositionUpForPanel1()
     {
         DataLevel.Instance.Arrow_Up_Panel_1.SetActive(false);
         DataLevel.Instance.Arrow_Top_Right_Panel1.SetActive(true);
         TweenPosition.Begin(DataLevel.Instance.Panel_1, 0.2f, new Vector3(DataLevel.Instance.Panel_1.transform.localPosition.x, DataLevel.Instance.Y_start_Panel1, DataLevel.Instance.Panel_1.transform.localPosition.z));
    
     }

     public override void Handle(ContextStatePanel context)
     {
         
         context.State=new StatePositionDownForPanel1();
     }
 }
