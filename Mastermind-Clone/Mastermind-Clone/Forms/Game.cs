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
            DoubleBuffered = true;
            Scene = new Scene(new Point(10,5), new Point(250,5),new Point(547,365));
            
        }

        

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        
    }
}
