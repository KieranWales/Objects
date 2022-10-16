using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Strings : Instrument
    {
        protected int numStrings;
        protected int original;
        public Strings(string name = "", string sound = "", bool resonant = false, int pNumStrings = 0, bool playable = false) : base(name, sound, resonant, playable)
        {
            numStrings = pNumStrings;
            original = pNumStrings;
        }

        public void Break()
        {
            switch (numStrings)
            {
                case 0:
                    break;

                case 1:
                    numStrings = 0;
                    Console.WriteLine($"You snapped a string on your {name} and now there are no strings left so you can no longer play");
                    playable = false;
                    break;

                default:
                    numStrings -= 1;
                    Console.WriteLine($"You snapped a string on your {name} and now there are {numStrings} strings left");
                    break; 
            }
        }
        public void Repair()
        {
            Console.WriteLine($"You repaired your {name}");
            numStrings = original;
        }
    }
}
