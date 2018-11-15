using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WarGame
{
    public class Unit
    {
        public int AS, DS;
        public Point position;
        public bool destroy;
        

        public Unit(int a, int d)
        {
            AS = a;
            DS = d;
          
            destroy = false;
            
        }

        public void Draw()
        {
            SolidBrush BR = new SolidBrush(Color.Purple);
            Font F = new Font("Arial", 24, FontStyle.Bold);
            string s=AS+"/"+DS;
            Engine.grp.DrawRectangle(new Pen(Color.Black ,12), position.X, position.Y, 50, 60);
            Engine.grp.DrawString(s, F,BR,position);
            
        }
        
        public void setPosition(Point pos)
        {
            this.position=pos;
        }
        public void Attack(Unit u)
        {
            u.DS -= this.AS;
            this.DS -= u.AS;
            if (u.DS <= 0)
                u.destroy = true;
            if (this.DS <= 0)
                this.destroy = true;
        }
        public void Attack(Player P)
        {
            P.HP -= this.AS;

        }
    }
}
