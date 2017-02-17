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
    //          Have a fully functioning FSM
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------

    public enum TST
    {
        INIT = 0,
        RESULT = 1,
        PLAYERTURN = 2,
        OPPONENTTURN = 3,
        FIGHTOVER = 4,
        END = 1000,
    };

    class FSM : Transitions
    {

        FSM test;

        public FSM(string initialState)
        {
            transitions = new List<string>();
            states = new List<string>();
            currentState = states.First();
            AddStates(initialState);
        }




        /// <summary>
        /// Function will contain information from classes that aren't State.cs, transitions.cs, or FSM.cs
        /// </summary>
        public void FSMMain()
        {
            
        }


        public void TestFSMRun()
        {
            //test.AddStates("init");
            //test.AddStates("words");
            //test.AddStates("Words");
            //test.AddStates("moreWords");
            //test.AddStates("noWords");
            //test.AddStates("end");

            //test.AddTransitions("init", "words", false);
            //test.AddTransitions("words", "nowords", true);
            //test.AddTransitions("words", "morewords", true);
            //test.AddTransitions("morewords", "end", false);
            //test.AddTransitions("nowords", "end", false);


            //test.TryTransition("words");
            //test.TryTransition("nowords");
            //test.TryTransition("morewords");
            //test.TryTransition("end");

        }

    }

}
