using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public abstract class Animal
    {
        private string food;
        public string Food
        {
            get { return food; }
            set { food = value; }
        }

        private string sound;
        public string Sound
        {
            get { return sound; }
            set { sound = value; }

        }
        public Animal(string food, string sound)
        {
            Food = food;
            Sound = sound;
            Console.WriteLine("You have just created an animal");
        }


        public virtual void MakeNoise() { Console.WriteLine("My noise is" + Sound); }
        public virtual void Eat() { Console.WriteLine("I like to eat" + Food); }
        public virtual void Roam() { Console.WriteLine("I am roaming around"); }


        
    }
}
