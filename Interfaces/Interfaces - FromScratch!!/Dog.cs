using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces___FromScratch__
{
    internal class Dog :Animal, Imove,ImakeSound
    {
        public  void Move()
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }
}
