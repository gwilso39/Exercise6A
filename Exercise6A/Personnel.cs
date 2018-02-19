using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class Personnel
    {
        public virtual void Rank()
        {
            Console.WriteLine("Marine");
        }

        public virtual void Weapon()
        {
            Console.WriteLine("Grab your M4-Carbine");
        }

        public void Vehicle(string preferredVehicle)
        {
            Console.WriteLine($"Preferred Vehicle is a: {preferredVehicle}");
        }

        public virtual void Speech()
        {
            Console.WriteLine("SemperFidelis!");
        }
    }
}
