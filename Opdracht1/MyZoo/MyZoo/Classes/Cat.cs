using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Classes
{
    internal class Cat : Feline, IPet
    {
        public Cat(string food, string sound) : base(food, sound)
        {
            Console.WriteLine("You have just created a Cat");
        }
        public override void MakeNoise()
        {
            Console.WriteLine("My noise is" + Sound);
        }

        public override void Eat()
        {
            Console.WriteLine("My food is" + Food);
        }

        public override void Roam()
        {
            Console.WriteLine("I am roaming around");
        }





        public void BeFriendly()
        {
            Console.WriteLine("Ik ben een vriendelijk Cat");
        }

        public void Play()
        {
            Console.WriteLine("Ik kan met je de hele dag spelen");
        }


    }
}
