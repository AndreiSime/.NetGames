using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class UnitAttribute : Attribute
    {
        public int AS, DS ;

        public UnitAttribute(int a, int d )
        {
            AS = a;
            DS = d;
           
        }
    }
}
