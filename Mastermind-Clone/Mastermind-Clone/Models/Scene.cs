using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class Scene {
        public Guess[] Guesses { get; set; }
        public Guess[] ProgresArray { get; set; }
        public int ActiveGuess { get; set; }
        public Point PannelTopLeft { get; set; }

        public Scene(Point pannelTopLeft) {
            Guesses = new Guess[10];
            ProgresArray = new Guess[10];
            for (int i = 0; i < 10; i++) {
                Guesses[i] = new Guess(pannelTopLeft);
            }

            ActiveGuess = 0;
            PannelTopLeft = pannelTopLeft;
        }

        public void Draw(Graphics g) {
            Guesses[0].Draw(g);
        }
    }
}
