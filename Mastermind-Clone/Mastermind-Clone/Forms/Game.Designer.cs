
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timerUpdateProgressBar = new System.Windows.Forms.Timer(this.components);
            this.verticalProgressBarGameTimeLeft = new Mastermind_Clone.Models.VerticalProgressBar();
            this.btnCheck = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(544, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(220, 174);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // timerUpdateProgressBar
            // 
            this.timerUpdateProgressBar.Interval = 1000;
            this.timerUpdateProgressBar.Tick += new System.EventHandler(this.timerUpdateProgressBar_Tick);
            // 
            // verticalProgressBarGameTimeLeft
            // 
            this.verticalProgressBarGameTimeLeft.BackColor = System.Drawing.SystemColors.MenuText;
            this.verticalProgressBarGameTimeLeft.ForeColor = System.Drawing.Color.IndianRed;
            this.verticalProgressBarGameTimeLeft.Location = new System.Drawing.Point(493, 4);
            this.verticalProgressBarGameTimeLeft.Name = "verticalProgressBarGameTimeLeft";
            this.verticalProgressBarGameTimeLeft.Size = new System.Drawing.Size(34, 492);
            this.verticalProgressBarGameTimeLeft.TabIndex = 15;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.ErrorImage")));
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.Location = new System.Drawing.Point(593, 207);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(130, 30);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.TabStop = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.ErrorImage")));
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.Location = new System.Drawing.Point(593, 243);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(130, 30);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.TabStop = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.ErrorImage")));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(593, 279);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 30);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.verticalProgressBarGameTimeLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerUpdateProgressBar;
        private Models.VerticalProgressBar verticalProgressBarGameTimeLeft;
        private System.Windows.Forms.PictureBox btnCheck;
        private System.Windows.Forms.PictureBox btnRestart;
        private System.Windows.Forms.PictureBox btnMenu;
    }
}