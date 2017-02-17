using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{


    public interface IDamager
    {

        void Update();


        float TakeStandardDamage(float damageTaken);

        float TakeSpeedDamage(float damageTaken);
    }

    public interface IDamagable
    {

        void Update();

        float GiveDamage(float damageTaken);
    }

    //public interface ILimbs
    //{

    //    void Update();

    //    float LimbCheck(float offenseLimbs, float speedLimbs);

    //}




}

