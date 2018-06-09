namespace Zombie
{
    public class Zombie : IPerson
    {
        public decimal DistanceTraveled {get; set;}

        public void Walk(decimal minutes)
        {
            DistanceTraveled = DistanceTraveled + minutes;
        }
    }
}