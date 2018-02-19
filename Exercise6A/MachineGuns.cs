using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class MachineGuns : Weapons
    {
        public void Load()
        {
            Console.WriteLine("Loading the belt with .50 caliber ammunition!");
        }

        public void Fire()
        {
            Console.WriteLine("Thump, Thump, Thump, Thump, Thump... 5 round bursts keep the barrell cool.");
        }

        public void EffectiveRateOfFire()
        {
            Console.WriteLine("Rounds on target up to 1,800 meters!");
        }

        public void WeaponNomenclature()
        {
            Console.WriteLine("M2, Heavy Machine gun");
        }
    }
}
