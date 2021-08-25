using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program save information about Farmer's animals in a ranch.");
            Animal a1 = new();
            a1.AddAnimal();
            a1.Speak();
        }
    }
    public class Animal
    {
        string animalType;
        string name;
        int age;       
        

        public void AddAnimal()
        {
            Console.Write("Adding animal to the database...\nWrite type of an Animal: ");
            animalType = Console.ReadLine();
            Console.Write("Write name of an Animal: ");
            name = Console.ReadLine();
            Console.Write("Write age of an Animal: ");
            string readAge = Console.ReadLine();
            int.TryParse(readAge, out age);
        }

        public void Speak()
        {
            if (animalType == "cat")
            {
                Console.WriteLine($"{name} lat {age}: Miauu!");
            }
            else if (animalType == "goat")
            {
                Console.WriteLine($"{name} lat {age}: Meee!");
            }
            else if (animalType == "cow")
            {
                Console.WriteLine($"{name} lat {age}: Muuu!");
            }
            else
            {
                Console.WriteLine("Unrecognizable animal type.");
            }

        }
    }
}
