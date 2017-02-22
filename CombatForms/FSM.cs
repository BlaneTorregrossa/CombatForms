using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{

  

    class FSM
    {

        FSM test;
        public List<string> states;
        public List<string> transitions;
        public string currentState;

        public FSM(string initialState)
        {
            transitions = new List<string>();
            states = new List<string>();
            currentState = states.First();
            AddStates(initialState);
        }


        /// <summary>
        /// Trys to add a state to the list of states already in the FSM if the statealready exitsts it should not be added
        /// </summary>
        /// <param name="State"></param>
        public void AddStates(string State)
        {
            if (!states.Contains(State.ToLower()))
            {
                states.Add(State.ToLower());
            }
        }


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
        /// Changes currentState to it's set Goal State
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

