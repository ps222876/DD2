using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Classes
{
    internal class Dog : Canine, IPet
    {
        public Dog(string food, string sound) : base(food, sound)
        {
            Console.WriteLine("You have just created a Dog");
        }

        public void MakeNoise()
        {
            Console.WriteLine("My noise is" + Sound);
        }

        public void Eat()
        {
            Console.WriteLine("My food is" + Food);
        }

        public void Roam()
        {
            Console.WriteLine("I am roaming around");
        }



        public void BeFriendly()
        {
            Console.WriteLine("Ik ben een vriendelijk Dog");
        }

        public void Play()
        {
            Console.WriteLine("Ik kan met je de hele dag spelen");
        }
    }
}
