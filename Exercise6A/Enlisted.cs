using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class Enlisted : Personnel
    {
        public override void Rank()
        {
            Console.WriteLine("Sergeant");
        }

        public override void Weapon()
        {
            Console.WriteLine("Preferred Weapon is anything crew served!");
        }

        public override void Speech()
        {
            Console.WriteLine("Motovate!  Kill bodies!");
        }
    }
}
