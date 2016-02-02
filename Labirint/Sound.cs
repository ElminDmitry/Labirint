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
        static SoundPlayer sound_back = new SoundPlayer(Properties.Resources.wav_library_net_music_9);//click_sound
        //static SoundPlayer sound = new SoundPlayer(Properties.Resources);
        //static SoundPlayer sound = new SoundPlayer(Properties.Resources);
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

        public static void play_back()
        {
            if(sound_enabled)
              sound_back.Play();
        }
    }
}
