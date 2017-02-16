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

    //public enum TST
    //{
    //    init = 0,
    //    one = 1,
    //    two = 2,
    //    three = 3,
    //    end = 1000,
    //};

    class FSM : Transitions
    {
        //State s = new State();
        //Transitions t = new Transitions();
        FSM test = new FSM();
        State s0, s1, s2, s3, s1000 = new State();
        


        public FSM() {}

        
        public void ListFSM()
        {
            // States Added
            test.AddStates("init", s0);
            test.AddStates("one", s1);
            test.AddStates("two", s2);
            test.AddStates("three", s3);
            test.AddStates("end", s1000);
            // End of States Added 

            // Transitions Added
            test.AddTransitions("init", "one", false, "init");
            test.AddTransitions("one", "two", true, "one");
            test.AddTransitions("two", "three", true, "two");
            test.AddTransitions("three", "four", true, "three");
            test.AddTransitions("four", "end", false, "four");
            // End of Transitions Added

            // State to Transition to
            test.UseTransition("init");
            test.UseTransition("one");
            test.UseTransition("one");
            test.UseTransition("two");
            test.UseTransition("three");
            test.UseTransition("one");
            test.UseTransition("two");
            test.UseTransition("four");
            test.UseTransition("three");
            test.UseTransition("four");
            test.UseTransition("end");
            // End of states to transition to

            

        }

      

        public void DebugFSM()
        {
            Debug.WriteLine(currentState);
            Debug.WriteLine(currentState);
        }



    }

}
