using Mastermind_Clone.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_Clone.Forms {
    public partial class Game : Form {
        public Scene Scene { get; set; }
        public Point LastMouseLocation { get; set; }
        public Game() {
            InitializeComponent();
            DoubleBuffered = true;

            NewGame();
        }

        private void NewGame() {
            timerUpdateProgressBar.Stop();

            Scene = new Scene(new Point(10, 5), new Point(250, 5), new Point(547, 365));
            verticalProgressBarGameTimeLeft.Value = 0;

            timerUpdateProgressBar.Start();
        }

        private void Game_Paint(object sender, PaintEventArgs e) {
            Scene.Draw(e.Graphics);

            Brush brush = new SolidBrush(Scene.CurrentPickedColor);
            e.Graphics.FillEllipse(brush,
                LastMouseLocation.X - Circle.RADIUS/2,
                LastMouseLocation.Y - Circle.RADIUS/2,
                (Circle.RADIUS / 2) * 2,
                (Circle.RADIUS / 2) * 2);
            brush.Dispose();
        }

        private void timerUpdateProgressBar_Tick(object sender, EventArgs e) {
            if (verticalProgressBarGameTimeLeft.Value == verticalProgressBarGameTimeLeft.Maximum) {
                GameOver();
            }
            verticalProgressBarGameTimeLeft.Value += 1;
        }

        private void Game_MouseClick(object sender, MouseEventArgs e) {
            Scene.DetectPickCircleHit(e.Location);
            Scene.DetectGuessCircleHit(e.Location);

            Invalidate();
        }

        private void Game_MouseMove(object sender, MouseEventArgs e) {
            LastMouseLocation = e.Location;

            Invalidate();
        }

        private void btnCheckGuess_Click(object sender, EventArgs e) {
            if(Scene.CompareGuessToResult()) {
                if(MessageBox.Show("Congratulations", "You Won!", MessageBoxButtons.OK) == DialogResult.OK) {
                    NewGame();
                }
                else {
                    //TODO: Go to main menu
                }
            }
            
            if(Scene.ActiveGuess == 8) {
                GameOver();
            }

            Invalidate();
        }

        private void GameOver() {
            timerUpdateProgressBar.Stop();

            if (MessageBox.Show("Game Over!", "You Lost!", MessageBoxButtons.OK) == DialogResult.OK) {
                NewGame();
            }
            else {
                //TODO: Go to main menu
            }
        }
    }
}
