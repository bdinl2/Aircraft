using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Aircraft fighter = new Aircraft(g);
            List<Coord> listCoord = fighter.CalculateCoord(0f, fighter.pList);
            fighter.Draw(g, listCoord, 200, 150);

        }
    }
}
