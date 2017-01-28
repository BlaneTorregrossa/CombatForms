using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    class State
    {


        //CallBack onEnter;

        public delegate void OnEnter();
        public OnEnter onEnter;

        //CallBack onExit;

        public delegate void OnExit();
        public OnExit onExit;


        public State()
          {
              onEnter = null;
              onExit = null;
          }        
       




        public void Run()
        {
            


        }





    }
}
