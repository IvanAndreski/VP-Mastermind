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
        public Game() {
            InitializeComponent();

            Scene = new Scene(panel3.Location);
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            panel3.Invalidate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {
            Scene.Draw(e.Graphics);
        }
    }
}
