using System;
using System.Collections.Generic;

namespace Prove;

public static class EserciziInterview
{
    public static void Interview1()
    {
        var mammalFound=FindMammals();
        foreach (var mammal in mammalFound)
        {
            Console.WriteLine(mammal.Name); 
        }

        List<Animal> FindMammals()
        {
            Animal[] animals =
            {
                new() { Name = "Dog", IsMammal = true },
                new() { Name = "Snake", IsMammal = false },
                new() { Name = "Cheetah", IsMammal = true },
                new() { Name = "Dolphin", IsMammal = true },

            };

            var mammals = new List<Animal>();

            foreach (var animal in animals)
            {
                if(animal.IsMammal)
                    mammals.Add(animal);
            }

            return mammals;
        }
    }
}