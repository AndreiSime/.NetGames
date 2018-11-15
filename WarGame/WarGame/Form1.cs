using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame
{
    public partial class Form1 : Form
    {
       
        public static Player p1 = new Player();
        public static Player p2 = new Player();
        
      
        public Form1()
        {
            InitializeComponent();
            Engine.initGraf(pictureBox1);
            Engine.initSesion();
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Dispose();
            pictureBox4.Dispose();
            pictureBox5.Dispose();
            pictureBox2.Location = new Point(420, 450);
            p1 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(2));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox3.Dispose();
            pictureBox2.Dispose();
            pictureBox4.Dispose();
            pictureBox5.Location = new Point(420, 450);
             p1 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(1));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Dispose();
            pictureBox3.Dispose();
            pictureBox5.Dispose();
            pictureBox4.Location = new Point(420, 450);
             p1 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(0));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Dispose();
            pictureBox4.Dispose();
            pictureBox5.Dispose();
            pictureBox3.Location = new Point(420, 450);
             p1 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(3));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox7.Dispose();
            pictureBox8.Dispose();
            pictureBox9.Dispose();
            pictureBox6.Location = new Point(425, 70);
             p2 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(2));

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.Dispose();
            pictureBox8.Dispose();
            pictureBox9.Dispose();
            pictureBox7.Location = new Point(425, 70);
             p2 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(0));
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox6.Dispose();
            pictureBox7.Dispose();
            pictureBox9.Dispose();
            pictureBox8.Location = new Point(425, 70);
             p2 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(1));

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox7.Dispose();
            pictureBox8.Dispose();
            pictureBox6.Dispose();
            pictureBox9.Location = new Point(425, 70);
             p2 = Engine.getPlayer((ClassType)Enum.GetValues(typeof(ClassType)).GetValue(3));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Engine.StartGame();
            button2.Dispose();

        }
    }
}
