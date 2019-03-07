using System;
using System.Collections.Generic;

namespace SimplerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a few bugs
            var carrol = new Bug("Carrol", "caterpillar", new List<string> { "wasps", "ants", "owls" }, new List<string> { "plants", "flowers", "carrots" });
            var frank = new Bug("Franklin", "fly", new List<string> { "mosquitos", "wasps", "spiders" }, new List<string> { "fruit", "garbage", "meat" });
            var will = new Bug("William", "worm", new List<string> { "fish", "clowns", "dogs" }, new List<string> { "poop", "dirt", "rocks" });

            //Invoke some methods
            Console.WriteLine(frank.Eat("garbage"));
            Console.WriteLine(carrol.Eat(""));
            Console.WriteLine(will.PreyList());
            Console.WriteLine(frank.PredatorList());

            Console.ReadKey();
        }

        public class Bug
        {
            /*
                You can declare a typed public property, make it read-only,
                and initialize it with a default value all on the same
                line of code in C#. Readonly properties can be set in the
                class' constructors, but not by external code.
            */
            public string Name { get; } = "";
            public string Species { get; } = "";
            public ICollection<string> Predators { get; } = new List<string>();
            public ICollection<string> Prey { get; } = new List<string>();

            // Convert this readonly property to an expression member
            public string FormalName => $"{this.Name} the {this.Species}";

            // Class constructor
            public Bug(string name, string species, List<string> predators, List<string> prey)
            {
                this.Name = name;
                this.Species = species;
                this.Predators = predators;
                this.Prey = prey;
            }

            // Convert this method to an expression member
            public string PreyList() => string.Join(",", this.Prey);


            // Convert this method to an expression member
            public string PredatorList() => string.Join(",", this.Predators);


            // Convert this to expression method (hint: use a C# ternary)
            public string Eat(string food) => this.Prey.Contains(food) ? $"{this.Name} ate the {food}" : $"{this.Name} is still hungry.";

        }

    }
}
