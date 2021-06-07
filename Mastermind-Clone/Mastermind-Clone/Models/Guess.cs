using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class Guess {
        public GuessCircle[] GuessCircles { get; set; }
        public Point TopLeftPoint { get; set; }

        private static int WIDTH = 200;
        private static int HEIGHT = 50;


        public Guess(Point topLeftPoint) {
            TopLeftPoint = topLeftPoint;

            GuessCircles = new GuessCircle[4];
            for (int i=0; i<4; i++) {
                Point p = new Point(TopLeftPoint.X + 18 + 48*i, TopLeftPoint.Y + 22);
                GuessCircles[i] = new GuessCircle(p, false);
            }
        }

        public void Draw(Graphics g) {
            //Enter background color
            Brush brush = new SolidBrush(Color.White);
            foreach(GuessCircle gc in GuessCircles) {
                //g.FillRectangle(Brushes.Blue, TopLeftPoint.X, TopLeftPoint.Y, WIDTH, HEIGHT);
                gc.Draw(g);
            }
            brush.Dispose();
        }
    }
}
