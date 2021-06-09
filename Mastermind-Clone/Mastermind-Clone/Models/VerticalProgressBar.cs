using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_Clone.Models {
    public class VerticalProgressBar : ProgressBar {

        public VerticalProgressBar() {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Rectangle rec = e.ClipRectangle;

            rec.Height = (int)(rec.Height * (1 - ((double)Value / Maximum))) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawVerticalBar(e.Graphics, e.ClipRectangle);
            e.Graphics.FillRectangle(Brushes.Blue, 0, 0, rec.Width, rec.Height);
        }
    }
}


