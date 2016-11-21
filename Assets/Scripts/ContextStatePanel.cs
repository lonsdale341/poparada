using UnityEngine;
using System.Collections;

 class ContextStatePanel   {

     public StatePanel State { get; set; }

     public ContextStatePanel(StatePanel state)
    {
        this.State = state;
    }

    public void Reguest()
    {
        this.State.Handle(this);
    }
	
}
