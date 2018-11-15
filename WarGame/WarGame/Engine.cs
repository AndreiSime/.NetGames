using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WarGame
{
    public static class Engine
    {
        public static List<Unit> deck1;
        public static List<Unit> deck2;
        public static Random r = new Random();
        public static int resx, resy;
        public static Graphics grp;
        public static Bitmap bmp;
        public static PictureBox display;
        public static List<Unit> board1;
        public static List<Unit> board2;

        public static void initSesion()
        {
            deck1 = new List<Unit>();
            deck2 = new List<Unit>();

            for (int i = 0; i < 30; i++)
            {
                int n = Enum.GetValues(typeof(unitType)).Length;

                int t = r.Next(n);
                int X = r.Next(n);
                deck1.Add(getUnit((unitType)Enum.GetValues(typeof(unitType)).GetValue(t)));
                deck2.Add(getUnit((unitType)Enum.GetValues(typeof(unitType)).GetValue(X)));



            }
        }

        public static void initGraf(PictureBox p)
        {
            display = p;
            resx = p.Width;
            resy = p.Height;
            bmp = new Bitmap(resx, resy);
            grp = Graphics.FromImage(bmp);
            
        }

        public static void StartGame()
        {
            display.Image = bmp;
            board1 = new List<Unit>();
            board2 = new List<Unit>();

            for (int i = 0; i < 5; i++)
            {
                board1.Add(deck1[i]);
                board1[i].setPosition(new Point(i * 100 + 300, 240));
                board1[i].Draw();



                board2.Add(deck2[i]);
                board2[i].setPosition(new Point(i * 100 + 300, 350));
                deck2[i].Draw();
            }
            Form1.p1.SetPoint(475, 10);
            Form1.p2.SetPoint(475, 600);
            Form1.p1.showHP();
            Form1.p2.showHP();

            int j1 = 4;
            int j2 = 4;



            int[] v = new int[2];

            while (Form1.p1.HP > 0 && Form1.p2.HP > 0)
            { 

            int x;
            Random r = new Random();
            foreach (Unit u in board1)
            {
                x = r.Next(5);
                if (board2[x].destroy == false)
                    u.Attack(board2[x]);
                else
                    u.Attack(Form1.p2);
            }
            Color cl = new Color();
            grp.Clear(cl);

            Form1.p1.showHP();
            Form1.p2.showHP();
            v = updateBG(j1, j2);
            j1 = v[0];
            j2 = v[1];
            
           
            for (int i = 0; i < 5; i++)
            {

                board1[i].setPosition(new Point(i * 100 + 300, 240));
                board1[i].Draw();

                board2[i].setPosition(new Point(i * 100 + 300, 350));
                deck2[i].Draw();
            }
        
                
                 









                foreach (Unit u in board2)
                {
                    x = r.Next(5);
                    if (board1[x].destroy == false)
                        u.Attack(board1[x]);
                    else
                        u.Attack(Form1.p1);
                }
                
                
                initGraf(display);


                Form1.p1.showHP();
                Form1.p2.showHP();
                v = updateBG(j1, j2);
                j1 = v[0];
                j2 = v[1];
                for (int i = 0; i < 5; i++)
                {

                    board1[i].setPosition(new Point(i * 100 + 300, 240));
                    board1[i].Draw();




                    board2[i].setPosition(new Point(i * 100 + 300, 350));
                    deck2[i].Draw();
                }

   

            } 
        }


        public static int []  updateBG(int j1,int j2)
        {
            System.Threading.Thread.Sleep(5000);
            int []v = new int[2];
            if (j1 < deck1.Count-1)
            {
                for (int i = 0; i < 5; i++)
                    if (board1[i].destroy == true)
                    {
                        try { 
                        board1[i] = deck1[j1];
                        j1++;
                        }
                        catch { }
                    }
            }
            for (int i = 0; i < 5; i++)
            {
                if (j2 < deck2.Count - 1)
                {
                    if (board2[i].destroy == true)
                    {
                        board2[i] = deck2[j2];
                        j2++;
                    }
                }
            }
            v[0] = j1;
            v[1] = j2;
            return v;
        }






        public static UnitAttribute getAtribute(unitType t)
        {
            return (UnitAttribute)Attribute.GetCustomAttribute(
                typeof(unitType).GetField(Enum.GetName(typeof(unitType), t)),
                typeof(UnitAttribute));
        }
        public static PlayerAttribute getAtribute2(ClassType t)
        {
            return (PlayerAttribute)Attribute.GetCustomAttribute(
                typeof(ClassType).GetField(Enum.GetName(typeof(ClassType), t)),
                typeof(PlayerAttribute));
        }

        public static Unit getUnit(unitType t)
        {
            UnitAttribute local = getAtribute(t);
            Unit r = new Unit(local.AS, local.DS);
            return r;
        }
        public static Player getPlayer(ClassType t)
        {
            PlayerAttribute local = getAtribute2(t);
            Player r = new Player(local.AS, local.DS,local.HP);
            return r;
        }
    }
}
