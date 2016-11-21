using UnityEngine;
using System.Collections;

 class ContextStateSelectedPanel1   {

	  public StateSelectedPanel1 State { get; set; }

      public ContextStateSelectedPanel1(StateSelectedPanel1 state)
    {
        this.State = state;
    }

    public void Reguest(int mode)
    {
        this.State.Handle(mode,this);
    }
	
}
