using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{


    public interface IDamager
    {

        //void Update();

        void GiveDamage(float damageGiven);

    }
    public interface IDamagable
    {

        //void Update();

        void TakeStandardDamage(float damageTaken);

        void TakeSpeedDamage(float damageTaken);
    }





}

