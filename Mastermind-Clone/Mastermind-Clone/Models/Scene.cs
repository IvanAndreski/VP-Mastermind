using System;
using System.Drawing;

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
        public static readonly Color EmptyCircleColor = Color.Gray;

        public Scene(Point guess, Point progress, Point pick) {
            Random = new Random();
            Result = new Result(GenerateResultArray());
            this.ResetCurrentGuess();

            PanelGuessTopLeft = guess;
            PanelProgressTopLeft = progress;
            PanelPickColor = pick;

            Guesses = new Container[8];
            ProgresArray = new Container[8];
            Picks = new Container[2];
            FillContainers();
            Container.temp = 0;

            CurrentPickedColor = PALETTE[0];
            ActiveGuess = 0;
        }

        private Color[] GenerateResultArray() {
            Color[] ResultColorArray = new Color[4];
            for (int i = 0; i < 4; i++) {
                ResultColorArray[i] = PALETTE[Random.Next(8)];
            }

            return ResultColorArray;
        }

        private void ResetCurrentGuess() {
            Result.GuessArray = new Color[4];
            for (int i = 0; i < 4; i++) {
                Result.GuessArray[i] = Color.Empty;
            }
        }

        private void FillContainers() {
            for (int i = 0; i < 8; i++) {
                Guesses[i] = new Container(new Point(PanelGuessTopLeft.X + 10, PanelGuessTopLeft.Y + 13 * (i + 1) + i * 46), false, PALETTE);
                ProgresArray[i] = new Container(new Point(PanelProgressTopLeft.X + 10, PanelProgressTopLeft.Y + 13 * (i + 1) + i * 46), false, PALETTE);
                if (i < 2) {
                    Picks[i] = new Container(new Point(PanelPickColor.X + 10, PanelPickColor.Y + 13 * (i + 1) + i * 46), true, PALETTE);
                }
            }
        }

        public void Draw(Graphics g) {
            Image image = Image.FromFile("../../Imgs/wood.png");
            Brush b = new TextureBrush(image);
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
            b.Dispose();
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
