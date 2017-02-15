using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Needs Work------------------------------------------------------------------------
    //
    //
    // ----------------------------------------------Needs Work------------------------------------------------------------------------


    class State
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public State() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public State(Enum e)
        {
            
        }



        //public delegate void Handler();


        //CallBack onEnter;

        public delegate void OnEnter();
        public OnEnter onEnter;


        //CallBack onExit;

        public delegate void OnExit();
        public OnExit onExit;


        private string stateName;
        public string StateName
        {
            get { return stateName; }
            set { stateName = value; }
        }



        /// <summary>
        /// public function of return type void named AddEnterFunction
        /// </summary>
        /// <param name="d"></param>
        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }


        /// <summary>
        /// public dunction of return type void named AddExitFunction
        /// </summary>
        /// <param name="d"></param>
        public void AddExitFunction(Delegate d)
        {
            onExit += d as OnExit;
        }

    }
}
