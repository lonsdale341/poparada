using UnityEngine;
using System.Collections;

 class StateArrowRightPanel2 :StatePanel {

     public StateArrowRightPanel2()
     {
         DataLevel.Instance.ArrowLeftScrollPanel2.SetActive(true);
         DataLevel.Instance.ArrowRightScrollPanel2.SetActive(true);
         if (DataLevel.Instance.CurrentBlockPanel_2 == 1)
         {
             Debug.Log("State1");
             DataLevel.Instance.ArrowLeftScrollPanel2.SetActive(false);
             DataLevel.Instance.ArrowRightScrollPanel2.SetActive(true);
         }
         if (DataLevel.Instance.CurrentBlockPanel_2 == DataLevel.Instance.CountBlockPanel2)
         {
             Debug.Log("State2");
             DataLevel.Instance.ArrowLeftScrollPanel2.SetActive(true);
             DataLevel.Instance.ArrowRightScrollPanel2.SetActive(false);
         }
     }
     public override void Handle(ContextStatePanel context)
     {
         context.State = new StateArrowLeftPanel2();
     }
 }

