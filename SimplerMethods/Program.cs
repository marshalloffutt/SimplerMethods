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
    }
}
