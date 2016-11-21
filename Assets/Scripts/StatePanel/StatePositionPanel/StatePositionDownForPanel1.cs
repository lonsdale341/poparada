using UnityEngine;
using System.Collections;

 class StatePositionDownForPanel1 : StatePanel {

    public StatePositionDownForPanel1()
    {
       
        DataLevel.Instance.Arrow_Top_Right_Panel1.SetActive(false);
        TweenPosition.Begin(DataLevel.Instance.Panel_1, 0.2f, new Vector3(DataLevel.Instance.Panel_1.transform.localPosition.x, DataLevel.Instance.Y_start_Panel1 - 900, DataLevel.Instance.Panel_1.transform.localPosition.z));
        DataLevel.Instance.Arrow_Up_Panel_1.SetActive(true);
    }

    public override void Handle(ContextStatePanel context)
    {
        context.State=new StatePositionUpForPanel1();
    }
}
