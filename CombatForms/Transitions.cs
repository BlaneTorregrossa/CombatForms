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
    //      Think more when using ! in if statements and how you can use it besides !true or !0
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------


   



    class Transitions : State 
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Transitions() {}

        public List<string> transitions;        // getting warnings about this for some reason

        public string currentState;

       public string previousState;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Start"></param>
            /// <param name="End"></param>
            /// <param name="isReversable"></param>
        public void AddTransitions(string Start, string End, bool isReversable /*, bool deadEndState*/)
        {
            if (states.Contains(Start.ToLower()) && (states.Contains(End.ToLower())))
            {
                string transition = CreateTransition(Start, End);

                TryAddTransition(transition);

                if (isReversable)
                {
                    transition = CreateTransition(End, Start);
                    TryAddTransition(transition);
                }

                
            }
        }

        //public void RemoveTransitions(string Start, string End)
        //{
            

        //}



        /// <summary>
        /// 
        /// </summary>
        /// <param name="goal"></param>
        public void UseTransition(string goal)
        {
            if (states.Contains(goal.ToLower()))
            {
                string transition = CreateTransition(currentState, goal);

                if (transition.Contains(transition))
                {
                    currentState = goal;
                }
            }
        }
        private void TryAddTransition(string transition)
        {

            if (!transitions.Contains(transition.ToLower()))
                transitions.Add(transition.ToLower());

        }

        private string CreateTransition(string from, string to)
        {
            return from.ToLower() + " ===> " + to.ToLower();
        }


      


    }
}
