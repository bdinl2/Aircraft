using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            // пока переменнная flag = true будет выполняться цикл (движение самолета)
            bool flag = true;
            int xAircraft = 200;
            int yAircraft = 150;
            float asimut = 0f;
            while (flag)
            {
                float ugol = Convert.ToSingle(Math.Atan2(yAircraft - Form1.MousePosition.Y, Form1.MousePosition.X - xAircraft)); //Form1.MousePosition.X - xAircraft
                if (asimut < ugol)
                {
                    asimut += 0.04f;
                }
                else
                {
                    asimut -= 0.04f;
                }
                xAircraft += Convert.ToInt32(Math.Cos(asimut) * 5);
                yAircraft -= Convert.ToInt32(Math.Sin(asimut) * 5);
                Graphics g = e.Graphics;
                Aircraft fighter = new Aircraft(g);
                List<Coord> listCoord = fighter.CalculateCoord(asimut, fighter.pList);
                e.Graphics.Clear(Color.White);
                fighter.Draw(g, listCoord, xAircraft, yAircraft);
                Thread.Sleep(200);
            }

        }
    }
}
