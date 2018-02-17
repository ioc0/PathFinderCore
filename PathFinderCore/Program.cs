using System;

namespace PathFinderCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int Race = 0;
            Console.WriteLine("Введите Имя:");
            var Name = Console.ReadLine();
            Console.WriteLine("Введите расу: 1. Human, 2. Elf, 3. Dwarf, 4. High Elf");
            try
            {
                Race = Int16.Parse(Console.ReadLine());
            
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Повторите ввод");
            }
            Console.WriteLine("Ввод расы: "+ Race);                       
            PlayerTemplate newPlayer1 = new PlayerTemplate(Name,12,12,12,13,14,15);
            for (int i = 0; i < 2;i++){
                DiceRoll dr = new DiceRoll();


                Console.WriteLine(dr.roll(20));    
            }

            Console.WriteLine("Print player name" + newPlayer1.PlayerName);
            Console.WriteLine(PlayerTemplate.PlayerRace(Race));
            Console.ReadKey();
        }
    }
}
