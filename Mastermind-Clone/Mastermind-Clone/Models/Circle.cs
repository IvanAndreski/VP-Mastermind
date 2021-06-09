using System;
using System.Drawing;

namespace Mastermind_Clone.Models {
    public class Circle {
        public Point Center { get; set; }
        public Color Color { get; set; }

        public static readonly int RADIUS = 15;

        public Circle(Point center, Color color) {
            Center = center;
            Color = color;
        }

        public void Draw(Graphics g) {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - RADIUS, Center.Y - RADIUS, 2*RADIUS, 2*RADIUS);
            brush.Dispose();
        }

        public bool Hit(Point mouseLocation) {
            return Math.Sqrt(Math.Pow(Center.X - mouseLocation.X, 2) + Math.Pow(Center.Y - mouseLocation.Y, 2)) < RADIUS;
        }
    }
}
