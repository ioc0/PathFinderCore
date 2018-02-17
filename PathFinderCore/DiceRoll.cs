using System;
namespace PathFinderCore
{
    public class DiceRoll
    {
        public DiceRoll()
        {
        }


        public int roll(int n){
            Random rand = new Random();
            return rand.Next(1,n);

        }
    }
}
