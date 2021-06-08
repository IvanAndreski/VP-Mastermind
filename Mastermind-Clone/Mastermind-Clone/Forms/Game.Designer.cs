
namespace Mastermind_Clone.Forms {
    partial class Game {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.timerUpdateProgressBar = new System.Windows.Forms.Timer(this.components);
            this.btnCheckGuess = new System.Windows.Forms.Button();
            this.verticalProgressBarGameTimeLeft = new Mastermind_Clone.Models.VerticalProgressBar();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(608, 200);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(104, 19);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(608, 266);
            this.btnExitGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(104, 19);
            this.btnExitGame.TabIndex = 13;
            this.btnExitGame.Text = "Exit";
            this.btnExitGame.UseVisualStyleBackColor = true;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Location = new System.Drawing.Point(608, 233);
            this.btnRestartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(104, 19);
            this.btnRestartGame.TabIndex = 14;
            this.btnRestartGame.Text = "Restart";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            // 
            // timerUpdateProgressBar
            // 
            this.timerUpdateProgressBar.Interval = 1000;
            this.timerUpdateProgressBar.Tick += new System.EventHandler(this.timerUpdateProgressBar_Tick);
            // 
            // btnCheckGuess
            // 
            this.btnCheckGuess.Location = new System.Drawing.Point(608, 177);
            this.btnCheckGuess.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckGuess.Name = "btnCheckGuess";
            this.btnCheckGuess.Size = new System.Drawing.Size(104, 19);
            this.btnCheckGuess.TabIndex = 16;
            this.btnCheckGuess.Text = "Check Guess";
            this.btnCheckGuess.UseVisualStyleBackColor = true;
            this.btnCheckGuess.Click += new System.EventHandler(this.btnCheckGuess_Click);
            // 
            // verticalProgressBarGameTimeLeft
            // 
            this.verticalProgressBarGameTimeLeft.ForeColor = System.Drawing.Color.IndianRed;
            this.verticalProgressBarGameTimeLeft.Location = new System.Drawing.Point(493, 4);
            this.verticalProgressBarGameTimeLeft.Name = "verticalProgressBarGameTimeLeft";
            this.verticalProgressBarGameTimeLeft.Size = new System.Drawing.Size(34, 492);
            this.verticalProgressBarGameTimeLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBarGameTimeLeft.TabIndex = 15;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.btnCheckGuess);
            this.Controls.Add(this.verticalProgressBarGameTimeLeft);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Timer timerUpdateProgressBar;
        private Models.VerticalProgressBar verticalProgressBarGameTimeLeft;
        private System.Windows.Forms.Button btnCheckGuess;
    }
}