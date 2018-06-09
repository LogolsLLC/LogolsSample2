using System;

namespace Test1
{
    public sealed class Dog : Pet
    {
        public void Bark()
        {
            Console.WriteLine("ruff");
        }

        public override decimal Walk()
        {
            
        }
    }
}