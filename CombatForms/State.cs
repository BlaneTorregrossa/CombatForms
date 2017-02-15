using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{



    // ----------------------------------------------Notes------------------------------------------------------------------------
    //
    //          No longer trying to use Callbacks or Handler delegate for FSM as they are not needed here.
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------

    

    class State
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public State() {}

        public List<string> states;         // getting warnings on this for some reason

        /// <summary>
        /// 
        /// </summary>
        /// <param name="State"></param>
       public void AddStates(string State)
        {
            if (!states.Contains(State.ToLower()))
                states.Add(State.ToLower());
        }

        //public void RemoveState(string State)
        //{

        //}


    }
}





