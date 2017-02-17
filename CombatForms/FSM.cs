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
    //          Have a fully functioning FSM before doing other work.
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------

    public enum TST
    {
        init = 0,
        one = 1,
        two = 2,
        three = 3,
        end = 1000,
    };

    class FSM
    {

        FSM test;


        public FSM()
        {
            transitions = new List<string>();
            states = new List<string>();
        }

        public List<string> transitions;
        public List<string> states;

        public string currentState;


        static public void FSMMain()
        {

        }

      
        public void StartFSM()
        {
            if ()
            {
                
            }
        }
      


    }

}
