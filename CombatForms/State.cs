﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{



    // ----------------------------------------------Notes------------------------------------------------------------------------
    //
    //      No longer trying to use Callbacks or Handler delegate for FSM as they are not needed here.
    //      IMPORTANT: Evreything that involves how the States of the FSM work go in here
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------

   /*

    class State
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public State()
        {
            states = new List<string>();
        }

        public List<string> states;


        /// <summary>
        /// Trys to add a state to the list of states already in the FSM if the statealready exitsts it should not be added
        /// </summary>
        /// <param name="State"></param>
        public void AddStates(string State)
        {
            if (!states.Contains(State.ToLower()))
            {
                states.Add(State.ToLower());
            }
        }

      



    }
    */
}





