using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WarGame
{
    public enum ClassType
   
    {
        [PlayerAttribute(20, 5, 50)]
        mage,

        [PlayerAttribute(10, 20, 100)]
        warrior,

        [PlayerAttribute(11, 11, 75)]
        shamman,

        [PlayerAttribute(14, 8, 60)]
        assasin
    }
}
