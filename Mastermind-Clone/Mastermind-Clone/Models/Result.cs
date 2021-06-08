using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class Result {
        public Color[] ResultArray { get; set; }
        public Color[] GuessArray { get; set; }

        public Result(Color[] result) {
            ResultArray = result;
            GuessArray = new Color[4];
            for (int i = 0; i < 4; i++) {
                GuessArray[i] = Color.Empty;
            }
        }

        public bool CheckGuess() {
            for (int i = 0; i < 4; i++) {
                if (ResultArray[i] != GuessArray[i])
                    return false;
            }

            return true;
        }

        public Color[] CreateProgressArray() {
            Color[] temp = { Color.Empty, Color.Empty, Color.Empty, Color.Empty };

            for (int i = 0; i < 4; i++) {
                if (ResultArray[i] == GuessArray[i]) {
                    temp[i] = Color.IndianRed;
                }
                else {
                    for (int j = 0; j < 4; j++) {
                        if (j != i) {
                            if (ResultArray[j] == GuessArray[i]) {
                                temp[i] = Color.YellowGreen;
                            }
                        }
                    }
                    if (temp[i] == Color.Empty) {
                        temp[i] = Color.DarkGray;
                    }
                }

            }

            return temp;
        }

        public bool CanPerformCheck() {
            foreach (Color c in GuessArray) {
                if (c == Color.Empty)
                    return false;
            }

            return true;
        }
    }
}
