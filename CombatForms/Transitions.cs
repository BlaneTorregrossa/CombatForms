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
    //      IMPORTANT: Evreything that involves how the Transitions work in the FSM go here.
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------


    class Transitions : State
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Transitions()
        {
            transitions = new List<string>();
            states = new List<string>();
            currentState = states.First();
        }

        public List<string> transitions;

        public string currentState;



        /// <summary>
        /// Creates a new transitition frome one state to another and another transition from the initial end state to the start state
        /// </summary>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <param name="isReversable"></param>
        public void AddTransitions(string Start, string End, bool isReversable)
        {

            if (states.Contains(Start.ToLower()) && (states.Contains(End.ToLower())))
            {

                string transition = SelectTransition(Start, End);

                TryAddTransition(transition);

                if (isReversable)
                {
                    transition = SelectTransition(End, Start);
                    TryAddTransition(transition);
                }
            }
        }


        /// <summary>
        /// Changes currentState to Goal State
        /// </summary>
        /// <param name="goal"></param>
        public void TryTransition(string goal)
        {
            if (states.Contains(goal.ToLower()))
            {
                string transition = SelectTransition(currentState, goal);

                if (transition.Contains(transition))
                {
                    currentState = goal;
                }
            }
        }

        /// <summary>
        /// Trys to add transition to the list of transitions
        /// </summary>
        /// <param name="transition"></param>
        private void TryAddTransition(string transition)
        {

            if (!transitions.Contains(transition.ToLower()))
            {
                transitions.Add(transition.ToLower());
            }
        }

        /// <summary>
        /// Selects specific States to be picked and made a part of a transition
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private string SelectTransition(string from, string to)
        {
            return from.ToLower() + " ===> " + to.ToLower();
        }



    }
}
