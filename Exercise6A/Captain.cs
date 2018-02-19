using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6A
{
    class Captain : Personnel
    {
        public override void Rank()
        {
            Console.WriteLine("Captain");
        }

        public override void Weapon()
        {
            Console.WriteLine("Preferred Weapon is a M-4 Carbine.");
        }

        public override void Speech()
        {
            Console.WriteLine("Let's get the mission done and make the General proud!");
        }
    
    }
}
