// See https://aka.ms/new-console-template for more information
using MyZoo;
using MyZoo.Classes;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

{



    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Cat("Cat Food", " Cat Noise"));
        animals.Add(new Dog("Dog Food", " Dog Noise"));
        animals.Add(new Hippo("Hippo Food", " Hippo Noise"));
        animals.Add(new Lion("Lion Food", " Lion Noise"));
        animals.Add(new Tiger("Tiger Food", " Tiger Noise"));
        animals.Add(new Wolf("Wolf Food", " Wolf Noise"));

        Console.WriteLine("----------------------------------------");


        foreach (Animal a in animals)
        {
            a.MakeNoise();
            a.Eat();
            if (a is IPet)
            {
                ((IPet)a).BeFriendly();
                ((IPet)a).Play();
            }

            Console.WriteLine("----------------------------------------");
        }

        Console.ReadKey();
    }
}

