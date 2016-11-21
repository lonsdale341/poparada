using UnityEngine;
using System.Collections;

public class ButtonSelectedPanel_3_UP : MonoBehaviour {

    public int Mode;

    void OnClick()
    {
        DataLevel.Instance.ReguestSelectedPanel_3_UP(Mode);
    }
}
