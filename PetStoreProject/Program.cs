using System;
using System.Collections.Generic;

namespace PetStoreProject {

    class Program { // Same setup as the inheritence examples however IPetAnimals(Interface) is opposite of parent directory

        static void Main(string[] args) {

            Parrot parrot = new Parrot() { // used in place of a constructor, does the same thing, "initializes properties" is term
                Inventory = 17,
                Sound = "Squak",
                Price = 3000,
                Longevity = 60
            };
            Hedgehog hedgehog = new Hedgehog() {
                Inventory = 3,
                Sound = "Squeak",
                Price = 200,
                CuteLevel = "Ultimate" // no longevity because not from the parrot class
            };
            Hampster hampster = new Hampster() {
                Inventory = 200,
                Sound = "Squeak'em",
                Price = 10,
                Color = "Dirty Brown"
            };

            List<IPetAnimal> animals = new List<IPetAnimal>(); // classes use interface to match properties, data type is IPetAnimal to create list

                animals.Add(parrot);
                animals.Add(hedgehog);
                animals.Add(hampster);

            decimal total = 0;
            foreach(IPetAnimal a in animals) {
                decimal value = a.Price * a.Inventory;
                total += value;
                Console.WriteLine($"All {a.GetType().Name}s will net {value:c}");
            }
            Console.WriteLine($"Total value is {total:c}");
        }
    }
}
