using Mastermind_Clone.Forms;
using Mastermind_Clone.Models;
using System.Windows.Forms;

namespace Mastermind_Clone {
    public partial class Form1 : Form {
        public AudioPlayer Player { get; set; }
        public Form1() {
            InitializeComponent();
            Player = new AudioPlayer();

            Meni();
        }

        public void Meni() {
            Meni menu = new Meni(panel1, Player);
            menu.TopLevel = false;
            panel1.Controls.Add(menu);
            menu.Show();
        }
    }
}
