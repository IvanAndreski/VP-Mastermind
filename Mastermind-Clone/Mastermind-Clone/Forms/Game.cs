using Mastermind_Clone.Models;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace Mastermind_Clone.Forms {
    public partial class Game : Form {
        public AudioPlayer Player { get; set; }
        public Scene Scene { get; set; }
        public Point LastMouseLocation { get; set; }
        public Panel Panel { get; set; }
        public Game(Panel panel1, AudioPlayer player) {
            InitializeComponent();
            Panel = panel1;
            DoubleBuffered = true;
            Player = player;

            NewGame();
        }

        private void NewGame() {
            timerUpdateProgressBar.Stop();

            Scene = new Scene(new Point(10, 5), new Point(250, 5), new Point(547, 365));
            verticalProgressBarGameTimeLeft.Value = 0;

            Player.PlayStart();

            timerUpdateProgressBar.Start();
        }

        private void GameOver() {
            timerUpdateProgressBar.Stop();

            if (MessageBox.Show("You Lost! Do you want to play again?", "Game Over!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                NewGame();
            }
            else {
                GoToMenu();
            }
        }

        private void GoToMenu() {
            Meni menu = new Meni(Panel, Player);
            menu.TopLevel = false;
            Panel.Controls.Clear();
            Panel.Controls.Add(menu);
            menu.Show();
        }

        private bool AreYouSure() {
            timerUpdateProgressBar.Stop();
            if (MessageBox.Show("Braum still needs your help, are you sure you want to back out now?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                return true;
            }
            else {
                timerUpdateProgressBar.Start();
                return false;
            }
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
            if (verticalProgressBarGameTimeLeft.Value + 1 <= verticalProgressBarGameTimeLeft.Maximum)
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

        private void btnCheck_Click(object sender, EventArgs e) {
            Invalidate();
            
            if (Scene.CompareGuessToResult()) {
                timerUpdateProgressBar.Stop();
                Player.PlayEnd();
                if (MessageBox.Show("You unlocked the gate successfuly and helped Braum rescue the poros like a true hero! Do you want to play again?", "Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    NewGame();
                }
                else {
                    GoToMenu();
                }
            }
            else if(Scene.ActiveGuess == 8) {
                GameOver();
            }

            Player.PlayMove();
            Invalidate();
        }

        private void btnRestart_Click(object sender, EventArgs e) {
            if (AreYouSure())
                NewGame();
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            if (AreYouSure()) {
                GoToMenu();
            }
        }
    }
}
