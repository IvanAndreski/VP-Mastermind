using System.Drawing;

namespace Mastermind_Clone.Models {
    public class Container {
        public Circle[] Circles { get; set; }
        public Point TopLeftPoint { get; set; }

        private static int WIDTH = 200;
        private static int HEIGHT = 52;
        public static int temp = 0;

        public Container(Point topLeftPoint, bool isPick, Color[] palette) {
            TopLeftPoint = topLeftPoint;
            Circles = new Circle[4];

            for (int i = 0; i < 4; i++) {
                Point p = new Point(TopLeftPoint.X + 27 + 48 * i, TopLeftPoint.Y + 27);
                if (!isPick)
                    Circles[i] = new Circle(p, Scene.EmptyCircleColor);
                else {
                    Circles[i] = new Circle(p, palette[temp++]);
                }
            }
        }

        public void Draw(Graphics g) {
            Image image = Image.FromFile("../../Imgs/pattern.png");
            Brush brush = new TextureBrush(image);
            g.FillRectangle(brush, TopLeftPoint.X, TopLeftPoint.Y, WIDTH, HEIGHT);
            foreach (Circle c in Circles) {
                c.Draw(g);
            }
            brush.Dispose();
        }

        public Color DetectPickCircleHit(Point mouseLocation) {
            foreach(Circle c in Circles) {
                if(c.Hit(mouseLocation)) {
                    return c.Color;
                }
            }

            return Color.Empty;
        }

        public void UpdateCircleColors(Color[] colors) {
            for(int i=0; i<4; i++) {
                Circles[i].Color = colors[i];
            }
        }
    }
}
