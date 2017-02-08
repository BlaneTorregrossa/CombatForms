using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Needs Work------------------------------------------------------------------------
    //
    //          AddEnterFunction and AddExitFunction doesn't work (FIX IT!)
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------


    class State 
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public State() { }

        /// <summary>
        /// Constructor that sets both onEnter and onExit delegates to have a value of null
        /// </summary>
        /// <param name="e"></param>
        public State(Enum e)
        {
            onEnter = null;
            onExit = null;
            
        }



        public delegate void Handler();


        //CallBack onEnter;

        public delegate void OnEnter();
        public OnEnter onEnter;


        //CallBack onExit;

        public delegate void OnExit();
        public OnExit onExit;


     



        /// <summary>
        /// public function of return type void named AddEnterFunction
        /// </summary>
        /// <param name="d"></param>
        public void AddEnterFunction(Delegate d)
        {

        }


        /// <summary>
        /// public dunction of return type void named AddExitFunction
        /// </summary>
        /// <param name="d"></param>
        public void AddExitFunction(Delegate d)
        {
            
        }

    }
}
