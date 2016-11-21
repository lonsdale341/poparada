using UnityEngine;
using System.Collections;

public class ButtonInstruction : MonoBehaviour {

    private void OnClick()
    {
        DataLevel.Instance.ReguestSetActivePanel_1();
        DataLevel.Instance.SetStartStatePanel1();

    }
}
