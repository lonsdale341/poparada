using UnityEngine;
using System.Collections;

 class StateArrowLeftPanel3 :  StatePanel {
     public StateArrowLeftPanel3()
     {
         DataLevel.Instance.ArrowLeftScrollPanel3.SetActive(true);
         DataLevel.Instance.ArrowRightScrollPanel3.SetActive(true);
         if (DataLevel.Instance.CurrentBlockPanel_3==1)
         {
             DataLevel.Instance.ArrowLeftScrollPanel3.SetActive(false);
             DataLevel.Instance.ArrowRightScrollPanel3.SetActive(true);
         }
         if (DataLevel.Instance.CurrentBlockPanel_3 == DataLevel.Instance.CountBlockPanel2)
         {
             DataLevel.Instance.ArrowLeftScrollPanel3.SetActive(true);
             DataLevel.Instance.ArrowRightScrollPanel3.SetActive(false);
         }
     }
     public override void Handle(ContextStatePanel context)
     {
         context.State=new StateArrowRightPanel3();
     }
 }
