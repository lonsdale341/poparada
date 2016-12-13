using UnityEngine;
using System.Collections;

 class StatePositionUpForPanel3  : StatePanel {

     public StatePositionUpForPanel3()
     {
         DataLevel.Instance.Arrow_Up_Panel_3.SetActive(false);
         DataLevel.Instance.Foto_panel3.SetActive(true);
         DataLevel.Instance.MenuIconSate2.SetActive(true);
         DataLevel.Instance.MenuSate2.SetActive(false);
        // if (DataLevel.Instance.Panel_3.transform.localPosition.y - DataLevel.Instance.Y_start_Panel3 != 0)
             TweenPosition.Begin(DataLevel.Instance.Panel_3, 0.2f, new Vector3(DataLevel.Instance.Panel_3.transform.localPosition.x, DataLevel.Instance.Y_start_Panel3, DataLevel.Instance.Panel_3.transform.localPosition.z));
         DataLevel.Instance.Arrow_Top_Left_Panel3.SetActive(true);
     }

     public override void Handle(ContextStatePanel context)
     {
         
         context.State=new StatePositionDownForPanel3();
     }
 }
