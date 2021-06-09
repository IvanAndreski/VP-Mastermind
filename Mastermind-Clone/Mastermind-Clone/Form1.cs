using Mastermind_Clone.Forms;
using System.Windows.Forms;

namespace Mastermind_Clone {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Meni();
        }

        public void Meni() {
            Meni menu = new Meni(panel1);
            menu.TopLevel = false;
            panel1.Controls.Add(menu);
            menu.Show();
        }
    }
}
