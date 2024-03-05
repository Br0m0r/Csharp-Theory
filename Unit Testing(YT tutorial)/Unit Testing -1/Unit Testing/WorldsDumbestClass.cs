using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    public class WorldsDumbestFunction
    {
        public string ReturnsPikachuIfZero(int numb)
        {
            if(numb == 0)
            {
                return "PIKACHU";
            }
            else
            {
                return "Squirtle";
            }
        }
    }
}
