using System;
using System.Collections.Generic;

namespace Zombie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();
            people.Add(new Human());
            people.Add(new Zombie());
            people.Add(new Human());

            foreach(IPerson person in people)
            {
                person.Walk(5);
                Console.WriteLine(person.DistanceTraveled);
            }
            /* 
            Human bob = new Human();
            Zombie jim  = new Zombie();
            bob.Run(3.0M);
            jim.Walk(3.0M);
            bob.Walk(4.0M);
            jim.Walk(4.0M);
            Console.WriteLine("Bob went: " + bob.DistanceTraveled);
            Console.WriteLine("Jim went: " + jim.DistanceTraveled);
            */
        }
    }
}
