using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class PickCircle : Circle {
        public PickCircle(Point center, Color color) : base(center, color) { }

        public Color Action() {
            return Color;
        }
    }
}
