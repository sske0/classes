using System;

namespace classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            var cat1 = new Cat("Tom", "blue", "britanian", "myo", 2);
            var dog1 = new Dog("Browny", "brown", "po", "hav", 2);

            Console.WriteLine(cat1.GetVoice());
            Console.WriteLine(dog1.GetVoice());
        }
    }
}
