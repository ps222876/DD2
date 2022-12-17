using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Classes
{
    internal class Hippo : Animal
    {
        public Hippo(string food, string sound) :base(food, sound)
        {
            Console.WriteLine("You have just created a Hippo");
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
    }
}
