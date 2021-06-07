using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class GuessCircle : Circle {
        public bool Hittable { get; set; }
        public GuessCircle(Point center, bool hittable) : base(center, Color.DarkGray) {
            Hittable = hittable;
        }

        public void Action(Color newColor) {
            Color = newColor;
        }

        public void ChangeStatus() {
            Hittable = !Hittable;
        }
    }
}
