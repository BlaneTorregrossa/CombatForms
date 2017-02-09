using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Needs Work------------------------------------------------------------------------
    //
    //          Unless something from state class needs to be changed then fixing this is now the MAIN PRIORTY!
    //          AddState Function is incomplete. (Work on this one first.)
    //          AddTransition function is incomplete.
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------



    class FSM : State
    {


        public FSM()
        {
            statesDictionary = new Dictionary<string, State>();
            transitionsDictionary = new Dictionary<string, List<State>>();
        }

        //Reminder: Dictionary is: Dictionary<x, y>, List is: List<z>

        private Dictionary<string, State> statesDictionary = new Dictionary<string, State>();

        private Dictionary<string, List<State>> transitionsDictionary = new Dictionary<string, List<State>>();

        private string currentState;



        public void AddState()
        {
            State s = new State();

            /*
            statesDictionary.Add("Not it", s);
            s.NewState += 
            */
        }


        public void AddTransistion()
        {
            State t1 = new State();
            State t2 = new State();
            
            
        }


        public void ChangeState()
        {
            State c1 = new State();
            
            
        }




    }
}
