using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Player
    {
        public int AS;
        public int DS;
        public int HP;
        public Point f = new Point();

        public Player()
        {
        }

            public Player(int a, int b,int c)
        {
            AS = a;DS = b;HP = c;
        }
        
        public void SetPoint(int x ,int y)
        {
            f.X = x;
            f.Y = y;
        }
        public void showHP()
        {
            String s = HP + " HP";
            SolidBrush BR = new SolidBrush(Color.Purple);
            Font F = new Font("Arial", 24, FontStyle.Bold);
            
            Engine.grp.DrawRectangle(new Pen(Color.Black, 12), f.X,f.Y, 50, 60);
            Engine.grp.DrawString(s, F, BR, f);
        }
        public void Attack(Unit u)
        {
            u.DS -= this.AS;
            if (u.DS < 0)
                u.destroy = true;
        }
        public void Attack(Player P)
        {
            P.DS -= this.AS;
            
        }
    }
}
