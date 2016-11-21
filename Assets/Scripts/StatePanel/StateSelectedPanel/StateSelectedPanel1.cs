using UnityEngine;
using System.Collections;
public enum SelectMode
{
    Mode_1,
    Mode_2,
    Mode_3,
    Mode_4
}
abstract class StateSelectedPanel1  {

    public void Handle(int  mode, ContextStateSelectedPanel1 context)
    {
        context.State=new ConcretStateSelectedPanel1(mode);
    }

}
