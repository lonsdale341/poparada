using UnityEngine;
using System.Collections;

abstract class StateSelectedPanel2 
{
    public void Handle(int mode, ContextStateSelectedPanel2 context)
    {
        context.State = new ConcretStateSelectedPanel2(mode);
    }
}
