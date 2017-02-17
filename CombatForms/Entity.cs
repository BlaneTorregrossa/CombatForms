using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    //-----------------------------------------Notes-------------------------------------------------------------
    //
    //      This needs complete revision!
    //
    //-----------------------------------------Notes-------------------------------------------------------------

    class Entity : IDamagable, IDamager /*, ILimbs */
    {


        public Entity() { }

        /// <summary>
        /// This is in need of Revision
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="sp"></param>
        public Entity(float hp, float sp)
        {
            Health = hp;
            SpeedPoints = sp;
        }


        void IDamager.Update() { }
        void IDamagable.Update() { }
        //void ILimbs.Update() { }

        /// <summary>
        /// This is in need of revision
        /// </summary>
        /// <param name="damageTaken"></param>
        /// <returns></returns>
        public float TakeStandardDamage(float damageTaken)
        {
            if (!LiveCheck())
            {
                return Health;
            }
            else
                return Health += Health - (damageTaken + attackPower);
        }

        public float TakeSpeedDamage(float damageTaken)
        {
            if (!LiveCheck())
            {
                return SpeedPoints;
            }
            else
                return SpeedPoints += SpeedPoints - (damageTaken + attackPower);
        }

        /// <summary>
        /// This is in need of Revision
        /// </summary>
        /// <param name="damageTaken"></param>
        /// <returns></returns>
        public float GiveDamage(float damageTaken)
        {
            return damageTaken;
        }


        public bool LiveCheck()
        {
            if (Health <= 0)
                return false;
            else if (Health >= 0)
                return true;
            else
                return true;
        }

        

        /// <summary>
        /// Can be reduced by players or opponents
        /// </summary>
        private float health;
        public float Health
        {
            get { return health; }
            set { health = value; }
        }



        /// <summary>
        /// Can be reduced by players or opponents
        /// </summary>
        private float attackPower;
        public float AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }


        
        /// <summary>
        /// Can be reduced by players or opponents
        /// </summary>
        private float speedPoints;
        public float SpeedPoints
        {
            get { return speedPoints; }
            set { speedPoints = value; }
        }

        

        



    }
}
