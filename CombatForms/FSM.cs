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
    //          Check for functions needing revisions. (Such as ChangeState and AddNewTransition)
    //          
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------

    // Reminder: NO LOOPS IN A WINFORMS APPLICATION!

    class FSM
    {

        /// <summary>
        /// Constructor that news up the lists and Dictionaries.
        /// </summary>
        public FSM()
        {
            //s = new State();
            statesDictionary = new Dictionary<string, State>();
            transitionsDictionary = new Dictionary<string, List<State>>();
            states = new List<State>();
        }


        //Reminder: Dictionary is: Dictionary<x, y>, List is: List<z>
        
        private Dictionary<string, State> statesDictionary;
        
        private Dictionary<string, List<State>> transitionsDictionary;

        // Is this needed?
        private List<State> states;                 

        private bool work = true;

        // Is this needed?
        private string selectedState, currentState, previousState;

        State s;



        /// <summary>
        /// ----------------------STILL NEEDS WORK----------------------------
        /// Revisions may affect how transitions work.
        /// </summary>
        public void AddNewStates()
        {
            s = new State();
            statesDictionary.Add(s.StateName, s);
        }

        /// <summary>
        /// ----------------------STILL NEEDS WORK----------------------------
        /// Revisions from States work may affect this
        /// </summary>
        public void AddNewTransitions()
        {
            State transitionState1 = new State();
            State transitionState2 = new State();
            states.Add(transitionState1);
            states.Add(transitionState2);
            // Need to add actual transition
        }


        // Is this needed?
        public void SetCurrentState()
        {
            previousState = currentState;
            currentState = selectedState;
        }

        public void ChangeState()
        {

        }

        ///// <summary>
        ///// Where new States that are activated and used.
        ///// ----------------------STILL NEEDS WORK----------------------------
        ///// Revisions may affect how Transitions work.
        ///// </summary>
        //public bool AddState()
        //{

        //    if (work != false)
        //    {
        //        NewStates();
        //        return true;
        //    }
        //    else
        //        return false;

        //}


        ///// <summary>
        ///// Where new Transitions are activated and used
        ///// ----------------------STILL NEEDS WORK----------------------------
        ///// Revisions from States work may affect this
        ///// </summary>
        //public bool AddTransistion()
        //{

        //    if (work != false)
        //    {
        //        NewTransitions();
        //        return true;
        //    }
        //    else
        //        return false;

        //}



        ///// <summary>
        ///// currentState to be set to the state that the transition demands
        ///// ----------------------STILL NEEDS WORK----------------------------
        ///// This whole function needs a revision
        ///// </summary>
        ///// <returns></returns>
        //public bool ChangeState()
        //{
        //    //State cs = new State();
        //    SetCurrentState();
        //    if (currentState == selectedState)
        //    {





        //        //currentState = 


        //        return true;
        //    }
        //    else
        //        return false;

        //}







    }
}
