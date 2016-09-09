using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Aircraft
    {
        public List<Point> pList;
        public Aircraft(Graphics g)
        {
            pList = new List<Point>();
            Point nose = new Point(55, 0);
            pList.Add(nose);
            Point r1 = new Point(48, -0.1f);
            pList.Add(r1);
            Point r2 = new Point(49, -0.21f);
            pList.Add(r2);
            Point r3 = new Point(42, -0.3f);
            pList.Add(r3);
            Point r4 = new Point(28, -0.46f);
            pList.Add(r4);
            Point r5 = new Point(93, -1.3f);
            pList.Add(r5);
            Point r6 = new Point(100, -1.37f);
            pList.Add(r6);
            Point r7 = new Point(93, -1.46f);
            pList.Add(r7);
            Point r8 = new Point(28, -2.36f);
            pList.Add(r8);
            Point r9 = new Point(36, -2.86f);
            pList.Add(r9);
            Point r10 = new Point(47, -2.87f);
            pList.Add(r10);
            Point r11 = new Point(67, -2.59f);
            pList.Add(r11);
            Point r12 = new Point(73, -2.6f);
            pList.Add(r12);
            Point r13 = new Point(76, -2.66f);
            pList.Add(r13);
            Point r14 = new Point(75, -2.87f);
            pList.Add(r14);
            Point back = new Point(70, 3.14f);
            pList.Add(back);
            Point l14 = new Point(75, 2.87f);
            pList.Add(l14);
            Point l13 = new Point(76, 2.66f);
            pList.Add(l13);
            Point l12 = new Point(73, 2.6f);
            pList.Add(l12);
            Point l11 = new Point(67, 2.59f);
            pList.Add(l11);
            Point l10 = new Point(47, 2.87f);
            pList.Add(l10);
            Point l9 = new Point(36, 2.86f);
            pList.Add(l9);
            Point l8 = new Point(28, 2.36f);
            pList.Add(l8);
            Point l7 = new Point(93, 1.46f);
            pList.Add(l7);
            Point l6 = new Point(100, 1.37f);
            pList.Add(l6);
            Point l5 = new Point(93, 1.3f);
            pList.Add(l5);
            Point l4 = new Point(28, 0.46f);
            pList.Add(l4);
            Point l3 = new Point(42, 0.3f);
            pList.Add(l3);
            Point l2 = new Point(49, 0.21f);
            pList.Add(l2);
            Point l1 = new Point(48, 0.1f);
            pList.Add(l1);
        }

        public List<Coord> CalculateCoord(float asimut, List<Point> list)
        {
            List<Coord> coordList = new List<Coord>();
            foreach (Point p in list)
            {
                int x = Convert.ToInt32(Math.Round(p.ro * Math.Cos(p.fi - asimut)));//
                int y = Convert.ToInt32(Math.Round(p.ro * Math.Sin(p.fi - asimut)));
                Coord c = new Coord(x, y);
                coordList.Add(c);
            }

            return coordList;
        }

        public void Draw(Graphics g, List<Coord> listAircraft, int xAircraft, int yAircraft)
        {
            Pen penAircraft = new Pen(Color.Red);
            for(int c = 0; c<= listAircraft.Count -2; c++)
            {
                g.DrawLine(penAircraft, listAircraft[c].xAircraft + xAircraft, listAircraft[c].yAircraft + yAircraft, listAircraft[c + 1].xAircraft + xAircraft, listAircraft[c + 1].yAircraft + yAircraft);
                g.DrawLine(penAircraft, listAircraft[listAircraft.Count - 1].xAircraft + xAircraft, listAircraft[listAircraft.Count - 1].yAircraft + yAircraft, listAircraft[0].xAircraft + xAircraft, listAircraft[0].yAircraft + yAircraft);//из метода расчета координат
            }
            

        }

        


       /* public Coord CalculateCentrPoint()
        {

            return;
        }*/
    }
}
