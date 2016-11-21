using UnityEngine;
using System.Collections;

 class ContextStateSelectedPanel3_Down  {

	public StateSelectedPanel3_Down State { get; set; }

    public ContextStateSelectedPanel3_Down(StateSelectedPanel3_Down state)
    {
        this.State = state;
    }

    public void Reguest(int mode)
    {
        this.State.Handle(mode,this);
    }
}
