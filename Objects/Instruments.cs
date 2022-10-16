using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Instrument
    {
        protected string name;
        protected string sound;
        protected bool resonant;
        protected bool playable;
        protected Random r = new Random();
        protected List<string> songs = new List<string>() {"Pachabel's canon", "Moonlight sonata", "Fur elise", "Minuet in G", "Hall of the mountain king", "World's smallest violin", "Swan lake", "The blue danube"};
        public Instrument(string pName, string pSound, bool pResonant, bool pPlayable)
        {
            name = pName.ToLower();
            sound = pSound.ToLower();
            resonant = pResonant;
            playable = pPlayable;
        }

        public void Clean()
        {
            Console.WriteLine($"You cleaned your {name}");
        }

        public void Play()
        {
            int index = r.Next(songs.Count);
            string song = songs[index];
            Console.WriteLine($"You played {song} on your {name}");
        }
    }
}
