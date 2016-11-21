using UnityEngine;
using System.Collections;

 class ContextStateSelectedPanel3_UP  {

	public StateSelectedPanel3_UP State { get; set; }

    public ContextStateSelectedPanel3_UP(StateSelectedPanel3_UP state)
    {
        this.State = state;
    }

    public void Reguest(int mode)
    {
        this.State.Handle(mode,this);
    }
}
