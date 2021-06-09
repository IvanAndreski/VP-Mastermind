using System;
using System.Drawing;

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
            Color[] progress = { Color.Empty, Color.Empty, Color.Empty, Color.Empty };
            int correctColor = 0;
            int correctPlace = 0;
            int[] guessDummy = { 0, 0, 0, 0 };
            int[] answerDummy = { 0, 0, 0, 0 };

            for (int i = 0; i < 4; i++)      
                if (GuessArray[i] == ResultArray[i]) {
                    ++correctPlace;
                    answerDummy[i] = guessDummy[i] = 1;
                }

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    if (GuessArray[i] == ResultArray[j] && !Convert.ToBoolean(answerDummy[j]) && i != j) {
                        ++correctColor;

                        answerDummy[j] = guessDummy[j] = 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < 4; i++) {
                if (correctPlace > 0) {
                    progress[i] = Color.IndianRed;
                    correctPlace--;
                }
                else if (correctColor > 0) {
                    progress[i] = Color.YellowGreen;
                    correctColor--;
                }
                else {
                    progress[i] = Scene.EmptyCircleColor;
                }
            }

            return progress;
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
