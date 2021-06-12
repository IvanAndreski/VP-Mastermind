using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Clone.Models {
    public class AudioPlayer {
        public SoundPlayer SoundPlayer { get; set; }
        public Random Random { get; set; }

        public AudioPlayer() {
            SoundPlayer = new SoundPlayer();
            Random = new Random();
        }

        public void PlayStart() {
            SoundPlayer.SoundLocation = string.Format("../../audio/start/Braum.start{0}.wav", Random.Next(1, 6));
            SoundPlayer.Play();
        }

        public void PlayMove() {
            SoundPlayer.SoundLocation = string.Format("../../audio/move/Braum.move{0}.wav", Random.Next(1, 4));
            SoundPlayer.Play();
        }

        public void PlayEnd() {
            SoundPlayer.SoundLocation = string.Format("../../audio/end/Braum.end{0}.wav", Random.Next(1, 5));
            SoundPlayer.Play();
        }
    }
}
