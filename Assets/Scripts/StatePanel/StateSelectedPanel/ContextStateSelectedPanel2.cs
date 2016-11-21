using UnityEngine;
using System.Collections;

 class ContextStateSelectedPanel2  {

	 public StateSelectedPanel2 State { get; set; }

      public ContextStateSelectedPanel2(StateSelectedPanel2 state)
    {
        this.State = state;
    }

    public void Reguest(int mode)
    {
        this.State.Handle(mode,this);
    }
}
