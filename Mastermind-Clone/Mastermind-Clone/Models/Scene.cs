using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class Scene {
        public Container[] Guesses { get; set; }
        public Container[] ProgresArray { get; set; }
        public Container[] Picks { get; set; } 
        public int ActiveGuess { get; set; }
        public Point PanelGuessTopLeft { get; set; }
        public Point PanelProgressTopLeft { get; set; }
        public Point PanelPickColor { get; set; }

        public Scene(Point guess,Point progress,Point pick) {
            PanelGuessTopLeft = guess;
            PanelProgressTopLeft = progress;
            PanelPickColor = pick;
            Guesses = new Container[8];
            ProgresArray = new Container[8];
            Picks = new Container[2];
            for (int i = 0; i < 8; i++) {
                Guesses[i] = new Container(new Point(guess.X+10,guess.Y+13*(i+1)+i*46),false);
                ProgresArray[i] = new Container(new Point(progress.X+10, progress.Y + 13 * (i + 1) + i * 46),false);
                if (i <2)
                {
                    Picks[i] = new Container(new Point(pick.X + 10, pick.Y + 13 * (i + 1) + i * 46),true);
                }
                
            }
            Container.temp = 0;
            ActiveGuess = 0;
            
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(Color.LightBlue);
            g.FillRectangle(b, PanelGuessTopLeft.X, PanelGuessTopLeft.Y, 220, 490);
            g.FillRectangle(b, PanelProgressTopLeft.X, PanelProgressTopLeft.Y, 220, 490);
            g.FillRectangle(b, PanelPickColor.X, PanelPickColor.Y, 220, 130);
            for(int i=0;i<8;i++)
            {
                Guesses[i].Draw(g);
                ProgresArray[i].Draw(g);
                if (i < 2)
                {
                    Picks[i].Draw(g);
                }
            }
        }
    }
}
