using UnityEngine;
using System.Collections;

abstract class StateSelectedPanel3_UP 
{

    public void Handle(int mode, ContextStateSelectedPanel3_UP context)
    {
        context.State = new ConcretStateSelectedPanel3_UP(mode);
    }
}
