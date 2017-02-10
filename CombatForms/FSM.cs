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
    //          Check for functions needing revisions. (Such as ChangeState, AddState and AddTransition)
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
            s = new State();
            statesDictionary = new Dictionary<string, State>();
            transitionsDictionary = new Dictionary<string, List<State>>();
            states = new List<State>();
        }


        //Reminder: Dictionary is: Dictionary<x, y>, List is: List<z>
        
        private Dictionary<string, State> statesDictionary;
        
        private Dictionary<string, List<State>> transitionsDictionary;

        private List<State> states;

        private bool work = true;

        private string selectedState, currentState, previousState;

        State s;


        /// <summary>
        /// Where new States for the statesDictionary are located
        /// ----------------------STILL NEEDS WORK----------------------------
        /// Revisions may affect how transitions work.
        /// </summary>
        public void NewStates()
        {
            //State s = new State();

            statesDictionary.Add("NewState1", s);
            statesDictionary.Add("NewState2", s);
        }

        /// <summary>
        /// Where new Transitions for the transitionsDictionary are located
        /// ----------------------STILL NEEDS WORK----------------------------
        /// Revisions from States work may affect this
        /// </summary>
        public void NewTransitions()
        {
            transitionsDictionary.Add("transitionTest", states);
        }


        //Note: selectedState is to be assigned outside the class.
        public void SetCurrentState()
        {
            previousState = currentState;
            currentState = selectedState;
        }

        /// <summary>
        /// Where new States that are activated and used.
        /// ----------------------STILL NEEDS WORK----------------------------
        /// Revisions may affect how Transitions work.
        /// </summary>
        public bool AddState()
        {
           
            if (work != false)
            {
                NewStates();
                return true;
            }
            else
                return false;
            
        }


        /// <summary>
        /// Where new Transitions are activated and used
        /// ----------------------STILL NEEDS WORK----------------------------
        /// Revisions from States work may affect this
        /// </summary>
        public bool AddTransistion()
        {
            
            if (work != false)
            {
                NewTransitions();
                return true;
            }
            else
                return false;
            
        }



        /// <summary>
        /// currentState to be set to the state that the transition demands
        /// ----------------------STILL NEEDS WORK----------------------------
        /// This whole function needs a revision
        /// </summary>
        /// <returns></returns>
        public bool ChangeState()
        {
            //State cs = new State();
            SetCurrentState();
            if (currentState == selectedState)
            {

                
                

                
                //currentState = 
                
                
                return true;
            }
            else
                return false;

        }
        



        


    }
}
