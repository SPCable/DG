using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Demo
{
   public class SoundMannager
    {
        public static WindowsMediaPlayer soundef = new WindowsMediaPlayer();
        public static void PlaySoundEF(string url)
        {
            if (soundef.enabled)
            {
                soundef.URL = url;
            }
            else
            {
                soundef.URL = "";
            }
        }
        public static void MuteSoundEF(string url)
        {
        }
    }
}
