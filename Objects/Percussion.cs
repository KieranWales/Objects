
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Percussion : Instrument
    {
        protected int numDrums;
        protected int original;
        public Percussion(string name = "", string sound = "", bool resonant = false, int pNumDrums = 0, bool playable = false) : base(name, sound, resonant, playable)
        {
            numDrums = pNumDrums;
            original = pNumDrums;
        }

        public void Break()
        {
            int power = r.Next(100) + 1;
            int breaking = power / 34;
            Console.Write($"You hit the {name} with {power}% power");
            switch (breaking)
            {
                case 0:
                    Console.WriteLine(" - Come on you barely even hit it");
                    break;
                case 1:
                    Console.WriteLine(" - Good job you gave it a good smack");
                    break;
                case 2:
                    switch (numDrums)
                    {
                        case 0:
                            break;

                        case 1:
                            numDrums = 0;
                            Console.WriteLine(" - Well done /s - You broke something and can no longer play"); ;
                            playable = false;
                            break;

                        default:
                            numDrums -= 1;
                            Console.WriteLine($" - Well done /s - You broke something but there are still {numDrums} left");
                            break;
                    }
                    break;
            }
        }
        public void Repair()
        {
            Console.WriteLine($"You repaired your {name}");
            numDrums = original;
        }
    }
}
