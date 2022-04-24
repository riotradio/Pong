using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Pong
{
    class Sound
    {
        private static Random rnd = new Random();

        string soundPath = @"C:\Users\hit-t\Pong\Pong\Pong\lib\sound";

        private void PaddleSOU()
        {
            SoundPlayer returnSound = new SoundPlayer(soundPath += @"\paddle\PM_AG_1_1_ABSTRACT_GUNS.wav");
            returnSound.Play();
        }

        public static void PaddleSound()
        {
            Sound gennie = new Sound();
            gennie.PaddleSOU();
        }
    }
}
