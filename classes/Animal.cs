using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Animal
    {
        public string name;
        public string color;
        public string breed;
        public string voice;
        public byte age;

        public Animal(string name, string color, string breed, string voice, byte age) 
        {
            this.name = name;
            this.color = color;
            this.breed = breed;
            this.voice = voice;
            this.age = age;
        }

        public virtual string GetVoice()
        {
            return voice;

        }

    }
}
