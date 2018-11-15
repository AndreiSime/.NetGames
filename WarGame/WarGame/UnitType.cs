using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public enum unitType

    {
        [UnitAttribute(7, 8)]
        human,

        [UnitAttribute(4, 10)]
        orc,

        [UnitAttribute(8, 8)]
        troll,

        [UnitAttribute(7, 10)]
        dwarf,

        [UnitAttribute(7, 9)]
        gnome,

        [UnitAttribute(6, 11)]
        elf,
    }
}
