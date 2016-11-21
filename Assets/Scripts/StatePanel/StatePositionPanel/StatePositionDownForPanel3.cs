using UnityEngine;
using System.Collections;

class StatePositionDownForPanel3 : StatePanel
{

    public StatePositionDownForPanel3()
    {

        DataLevel.Instance.Arrow_Top_Left_Panel3.SetActive(false);
        DataLevel.Instance.Foto_panel3.SetActive(false);
        DataLevel.Instance.MenuIconSate2.SetActive(false);
        DataLevel.Instance.MenuSate2.SetActive(false);
        TweenPosition.Begin(DataLevel.Instance.Panel_3, 0.2f, new Vector3(DataLevel.Instance.Panel_3.transform.localPosition.x, DataLevel.Instance.Y_start_Panel3 - 900, DataLevel.Instance.Panel_3.transform.localPosition.z));

        DataLevel.Instance.Arrow_Up_Panel_3.SetActive(true);
    }

    public override void Handle(ContextStatePanel context)
    {
        context.State = new StatePositionUpForPanel3();
    }
}

