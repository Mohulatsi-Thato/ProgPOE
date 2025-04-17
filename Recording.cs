using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE
{
    internal class Recording
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                // Path to the welcome audio file (make sure it exists)
                string filepath = @"C:\Users\lab_services_student\Desktop\CLDV\group2project\ProgPOE\Files\voice_greeting.wav"; 
                SoundPlayer player = new SoundPlayer(filepath); 
                player.Play();
            }
            catch (Exception)
            {
                Console.WriteLine("[!] Voice file missing or unsupported.");
            }
        }

    }

}
