using UnityEngine;
using System.Collections;

 class StatePositionUpForPanel2  : StatePanel {

     public StatePositionUpForPanel2()
     {
         DataLevel.Instance.Arrow_Up_Panel_2.SetActive(false);
         DataLevel.Instance.Arrow_Top_Left_Panel2.SetActive(true);
         DataLevel.Instance.Foto_panel2.SetActive(true);
         DataLevel.Instance.MenuIconSate.SetActive(true);
         DataLevel.Instance.MenuSate.SetActive(false);
         DataLevel.Instance.Arrow_Top_Left_Panel2.SetActive(true);
         if (DataLevel.Instance.Panel_2.transform.localPosition.y - DataLevel.Instance.Y_start_Panel2 != 0)
         {
             TweenPosition tp2 = TweenPosition.Begin(DataLevel.Instance.Panel_2, 0.2f, new Vector3(DataLevel.Instance.Panel_2.transform.localPosition.x, DataLevel.Instance.Y_start_Panel2, DataLevel.Instance.Panel_2.transform.localPosition.z));
         }
           
        
        
     }

     public override void Handle(ContextStatePanel context)
     {
         
         context.State=new StatePositionDownForPanel2();
     }
    
 }
