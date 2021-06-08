using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class Scene {
        public Container[] Guesses { get; set; }
        public Container[] Picks { get; set; }
        public Container[] ProgresArray { get; set; }
        public Result Result { get; set; }
        public int ActiveGuess { get; set; }
        public Point PanelGuessTopLeft { get; set; }
        public Point PanelProgressTopLeft { get; set; }
        public Point PanelPickColor { get; set; }
        public Color CurrentPickedColor { get; set; }
        public Random Random { get; set; }

        public static readonly Color[] PALETTE = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Turquoise, Color.Blue, Color.Magenta, Color.Purple };

        public Scene(Point guess, Point progress, Point pick) {
            Random = new Random();
            Color[] temp = new Color[4];
            for (int i = 0; i < 4; i++) {
                temp[i] = PALETTE[Random.Next(8)];
            }
            Result = new Result(temp);
            this.ResetCurrentGuess();

            PanelGuessTopLeft = guess;
            PanelProgressTopLeft = progress;
            PanelPickColor = pick;

            Guesses = new Container[8];
            ProgresArray = new Container[8];
            Picks = new Container[2];
            for (int i = 0; i < 8; i++) {
                Guesses[i] = new Container(new Point(guess.X + 10, guess.Y + 13 * (i + 1) + i * 46), false, PALETTE);
                ProgresArray[i] = new Container(new Point(progress.X + 10, progress.Y + 13 * (i + 1) + i * 46), false, PALETTE);
                if (i < 2) {
                    Picks[i] = new Container(new Point(pick.X + 10, pick.Y + 13 * (i + 1) + i * 46), true, PALETTE);
                }
            }
            Container.temp = 0;

            CurrentPickedColor = PALETTE[0];
            ActiveGuess = 0;
        }

        private void ResetCurrentGuess() {
            Result.GuessArray = new Color[4];
            for (int i = 0; i < 4; i++) {
                Result.GuessArray[i] = Color.Empty;
            }
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(Color.LightBlue);
            g.FillRectangle(b, PanelGuessTopLeft.X, PanelGuessTopLeft.Y, 220, 490);
            g.FillRectangle(b, PanelProgressTopLeft.X, PanelProgressTopLeft.Y, 220, 490);
            g.FillRectangle(b, PanelPickColor.X, PanelPickColor.Y, 220, 130);
            for (int i = 0; i < 8; i++) {
                Guesses[i].Draw(g);
                ProgresArray[i].Draw(g);
                if (i < 2) {
                    Picks[i].Draw(g);
                }
            }
        }

        public Color DetectPickCircleHit(Point mouseLocation) {
            Color temp = Color.Empty;
            for (int i = 0; i < 2; i++) {
                temp = Picks[i].DetectPickCircleHit(mouseLocation);
                if (temp != Color.Empty) {
                    CurrentPickedColor = temp;
                    return temp;
                }
            }

            return temp;
        }

        public void DetectGuessCircleHit(Point mouseLocation) {
            for (int i = 0; i < 4; i++) {
                Circle c = Guesses[ActiveGuess].Circles[i];
                if (c.Hit(mouseLocation)) {
                    c.Color = CurrentPickedColor;
                    Result.GuessArray[i] = c.Color;
                    break;
                }
            }
        }

        public bool CompareGuessToResult() {
            if (Result.CanPerformCheck()) {
                if (Result.CheckGuess()) {
                    ProgresArray[ActiveGuess++].UpdateCircleColors(Result.CreateProgressArray());
                    return true;
                }

                ProgresArray[ActiveGuess++].UpdateCircleColors(Result.CreateProgressArray());
                this.ResetCurrentGuess();
            }

            return false;
        }
    }
}
