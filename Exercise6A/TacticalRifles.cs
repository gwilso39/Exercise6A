using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class TacticalRifles : Weapons
    {
        public void Load()
        {
            Console.WriteLine("Loading a 30 round magazine with NATO 5.56 Tracer Ammunition!");
        }

        public void EffectiveRateOfFire()
        {
            Console.WriteLine("Rounds on target up to 550 meters!");
        }

        public void WeaponNomenclature()
        {
            Console.WriteLine("M4, Carbine");
        }
    }
}
