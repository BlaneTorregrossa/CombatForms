using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Needs Work------------------------------------------------------------------------
    //
    //          No idea what to do with AddEnterFunction and AddExitFunction to get them to work.
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------


    class State
    {

        public State() {}

        public State(Enum e)
        {
            onEnter = null;
            onExit = null;

        }



        //CallBack onEnter;

        public delegate void OnEnter();
        public OnEnter onEnter;
        //onEnter = null;


        //CallBack onExit;

        public delegate void OnExit();
        public OnExit onExit;
        //onExit = null;


  // ----------------------------------------------THESE NEED TO BE FIXED------------------------------------------------------------------------


        public void AddEnterFunction(Delegate d)
        {
            //onEnter += d
        }

        public void AddExitFunction(Delegate d)
        {
            //onExit += d
        }

        
    }
}
