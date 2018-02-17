using System;

namespace PathFinderCore
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerTemplate newPlayer1 = new PlayerTemplate("dummy","someClass",12,12,12,13,14,15);
            for (int i = 0; i < 100;i++){
                DiceRoll dr = new DiceRoll();


                Console.WriteLine(dr.roll(20));    
            }

            Console.WriteLine("Print player name" + newPlayer1.PlayerName);
            Console.ReadKey();
        }
    }
}
