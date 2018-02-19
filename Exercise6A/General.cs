using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class General : Personnel
    {
        public override void Rank()
        {
            Console.WriteLine("General: ");
        }

        public void Assistant()
        {
            Console.WriteLine("Aide de Camp");
        }

        public override void Weapon()
        {   
            Console.WriteLine("Preferred Weapon is a M-9 Berretta");
        }
    }
}
