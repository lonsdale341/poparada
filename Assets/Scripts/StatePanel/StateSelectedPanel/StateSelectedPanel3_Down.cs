using UnityEngine;
using System.Collections;

abstract class StateSelectedPanel3_Down 
{

    public void Handle(int mode, ContextStateSelectedPanel3_Down context)
    {
        context.State = new ConcretStateSelectedPanel3_Down(mode);
    }
}
