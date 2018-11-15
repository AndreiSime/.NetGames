using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class PlayerAttribute:Attribute
    {
       public  int AS, DS, HP;
        public PlayerAttribute(int a,int b,int c)
        {
            AS = a;
            DS = b;
            HP = c;
        }
    }
}
