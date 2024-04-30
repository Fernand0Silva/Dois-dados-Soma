
namespace MyticPartyTracker.Models
{
    internal class Dice
    {
        public int Side { get; set; } // Side = contidade de dados

        public Dice(int side) //
        {
            Side = side;
        }

        public int Roll()
        {
            return new Random().Next(Side) + 1;
        }
    }
}
