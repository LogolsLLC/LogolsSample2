using System;

namespace Test1
{
    public abstract class Pet
    {
        public virtual void Walk()
        {
            decimal minutes = 4.5M;
            decimal distance = CalculateDistance(minutes);
            Console.WriteLine(distance);
        }

        private decimal CalculateDistance(decimal minutes)
        {
            return minutes * 2;
        }
    }
}