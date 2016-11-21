using UnityEngine;
using System.Collections;

 class StatePositionDownForPanel2 : StatePanel {

    public StatePositionDownForPanel2()
    {
       
        DataLevel.Instance.Arrow_Top_Left_Panel2.SetActive(false);
        DataLevel.Instance.MenuIconSate.SetActive(false);
        DataLevel.Instance.MenuSate.SetActive(false);
        DataLevel.Instance.Foto_panel2.SetActive(false);
        TweenPosition.Begin(DataLevel.Instance.Panel_2, 0.2f, new Vector3(DataLevel.Instance.Panel_2.transform.localPosition.x, DataLevel.Instance.Y_start_Panel2 - 900, DataLevel.Instance.Panel_2.transform.localPosition.z));
        DataLevel.Instance.Arrow_Up_Panel_2.SetActive(true);
    }

    public override void Handle(ContextStatePanel context)
    {
        context.State=new StatePositionUpForPanel2();
    }
}
