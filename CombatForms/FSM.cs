using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Needs Work------------------------------------------------------------------------
    //
    //          AddState Function is incomplete. (Has to do with state class missing info)
    //          AddTransition function is incomplete.
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------

 

    class FSM /*: State*/
    {

        //private State previousState;
        //private State currentState;
        

        //Reminder: Dictionary is: Dictionary<x, y>, List is: List<z>

        private Dictionary<string, State> statesDictionary;

        private Dictionary<string, List<State>> transitionsDictionary;



        /// <summary>
        /// Dictionaries for states and transitions
        /// Do not put <T> on constructor. It's pointless with it already on the class.
        /// </summary>
        public FSM()
        {
            statesDictionary = new Dictionary<string, State>();                             
            transitionsDictionary = new Dictionary<string, List<State>>();
        }

        
        public void AddState(Enum e)
        {
            State state = new State(e);
            
        }

        public void AddTransistion()
        {

        }

    }
}
