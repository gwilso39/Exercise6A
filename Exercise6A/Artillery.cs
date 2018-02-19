using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class Artillery : Weapons
    {
        public void Load()
        {
            Console.WriteLine("Loading the 155 mm caliber M107 sir!");
        }

        public void Elevate()
        {
            Console.WriteLine("Elevate to 50 degrees!");
        }

        public void EffectiveRateOfFire()
        {
            Console.WriteLine("Rounds on target up to 14.9 miles!");
        }

        public void WeaponNomenclature()
        {
            Console.WriteLine("M777, Ultralight-weight Field Howitzer");
        }
    }
}
