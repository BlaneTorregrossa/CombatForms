using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Needs Work------------------------------------------------------------------------
    //
    //          Put anything private to the bottom once done.
    //          AddState Function is incomplete. (Might have to do with state class missing info)
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------

    public enum PlayerAction
    {
        INIT = 0,
        NOACTION = 1,
        ATTACK = 2,
        TAKEDAMAGE = 3,
        END = 1000,
    }

    class FSM<T>
    {

        //-------------------------Reminder Dictionary is: Dictionary<x, y>, List is: List<z>.-------------------------------------------------------------------------------------------------------------------------

        private Dictionary<string, State> statesDictionary;

        private Dictionary<string, List<State>> transitionsDictionary;

        public FSM/*<T>*/()
        {
            statesDictionary = new Dictionary<string, State>();
            transitionsDictionary = new Dictionary<string, List<State>>();
        }


        public void AddState(Enum e)
        {
            State s = new State(e);
            //statesDictionary.Add = 
        }

        public void AddTransistion()
        {

        }

    }
}
