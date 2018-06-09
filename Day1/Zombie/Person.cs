namespace Zombie
{
    public class Person
    {
        public decimal DistanceTraveled {get; set;}

        public virtual void Walk(decimal minutes)
        {
            DistanceTraveled = DistanceTraveled + (minutes * 1.5M);
        }
    }
}