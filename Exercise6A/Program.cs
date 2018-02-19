using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                getSome();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }

        static void getSome()
        {
            Console.WriteLine("It's time for War!");
            Console.WriteLine("Who is in charge here?");
            Captain usMarine = new Captain();
            usMarine.Rank();
            usMarine.Weapon();
            usMarine.Speech();
            Console.WriteLine("How good is that weapon?");
            TacticalRifles myWeapon = new TacticalRifles();
            myWeapon.WeaponNomenclature();
            myWeapon.EffectiveRateOfFire();
            Console.WriteLine("What is our mission?");
            Missions myMission = new Missions();
            myMission.Training();
            usMarine.Vehicle("MRAP");

        }
    }
}
