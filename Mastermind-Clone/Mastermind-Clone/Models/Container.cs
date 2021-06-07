using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class Container {
        public Circle[] Circles { get; set; }
        public Point TopLeftPoint { get; set; }
        public Color[] palette = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Turquoise, Color.Blue, Color.Magenta, Color.Purple };

        private static int WIDTH = 200;
        private static int HEIGHT = 52;
        public static int temp = 0;

        public Container(Point topLeftPoint,bool isPick) {
            TopLeftPoint = topLeftPoint;

            Circles = new Circle[4];
            
            for (int i=0; i<4; i++) {
                Point p = new Point(TopLeftPoint.X + 27 + 48*i, TopLeftPoint.Y + 27);
                if(!isPick)
                Circles[i] = new GuessCircle(p, false);
                else
                {
                    Circles[i] = new PickCircle(p, palette[temp++]);
                }
            }
        }

        public void Draw(Graphics g) {
            //Enter background color
            Brush brush = new SolidBrush(Color.White);
            g.FillRectangle(Brushes.Blue, TopLeftPoint.X, TopLeftPoint.Y, WIDTH, HEIGHT);
            foreach (Circle c in Circles) {
                c.Draw(g);
            }
            brush.Dispose();
        }
    }
}
