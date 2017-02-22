using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    // ----------------------------------------------Notes------------------------------------------------------------------------
    //
    //     
    //
    // ----------------------------------------------Notes------------------------------------------------------------------------

    class Entity : IDamagable, IDamager
    {


        public Entity() { }


        public Entity(float hp, float sp, float ap)
        {
            HealthPoints = hp;
            SpeedPoints = sp;
            AttackPower = ap;
        }


        //void IDamager.Update() { }
        //void IDamagable.Update() { }


        public void TakeStandardDamage(float takeDamage)
        {
            if (HealthPoints <= 0)
            {
                //Tell the player the target is dead and that the turn was wasted
            }
            else
                HealthPoints -= (5 + AttackPower);
        }

        public void TakeSpeedDamage(float takeDamage)
        {
            if (HealthPoints <= 0 || SpeedPoints <= 0)
            {
                //Tell the player the target is dead or can't lose more speed and that the turn was wasted
            }
            else
                SpeedPoints -= (2 + AttackPower);
        }


        public void GiveDamage(float DamageGiven)
        {
            
        }

        


        /// <summary> 
        /// Can be reduced by opposing team, If value is less than or equal to a float of 0 then player is no longer active
        /// </summary>
        private float healthPoints;
        public float HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }



        /// <summary>
        /// Determines additional damage done by players and opponents
        /// </summary>
        private float attackPower;
        public float AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }



        /// <summary>
        /// Can be reduced by oppossing team, Determines who goes first in what order in the game
        /// </summary>
        private float speedPoints;
        public float SpeedPoints
        {
            get { return speedPoints; }
            set { speedPoints = value; }
        }







    }
}
