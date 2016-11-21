using UnityEngine;
using System.Collections;

public class ButtonSelectedPanel_2 : MonoBehaviour {

    public int Mode;
    
    void OnClick()
    {
        DataLevel.Instance.ReguestSelectedPanel_2(Mode);
    }
}
