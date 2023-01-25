using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Dog : Animal
    {
        public Dog(string name, string color, string breed, string voice, byte age) : base(name, color, breed, voice, age)
        {

        }
        public override string GetVoice()
        {
            
            return voice;
        }
    }
}
