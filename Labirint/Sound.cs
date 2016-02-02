using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint
{
    static class Sound
    {
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.switch_8);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.Click_05);
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.Click_05);
        //static SoundPlayer sound = new SoundPlayer(Properties.Resources);
        static bool sound_enabled = true;

        public static void sound_on()
        {
            sound_enabled = true;
        }

        public static void sound_off()
        {
            sound_enabled = false;
        }

        public static void play_key()
        {
            if(sound_enabled)
              sound_key.Play();
        }

        public static void play_start()
        {
            if (sound_enabled)
                sound_start.Play();
        }

        public static void play_fail()
        {
            if (sound_enabled)
                sound_fail.Play();
        }
    }
}
