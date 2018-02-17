
using System;
namespace PathFinderCore
{
    public class PlayerTemplate
    {
        //base Vars
        public string PlayerName;
        public string PlayerClass;
        //return Race
        public static string PlayerRace(int n){
            if (n == 1)
            {
                return "Human";
            }
            else if (n == 2)
            {
                return "Dwarf";
            }
            else if (n == 3){
                return "Elf";
            }
            else if (n == 4){
                return "High Elf";
            }
            else return "Не правильный ввод";

        }
            

            

        public int str;
        public int dex;
        public int con;
        public int pInt;
        public int wiz;
        public int pChar;
        public int HP;
        public int AC;



        //empty constructor;

        public PlayerTemplate(int v)
        {
            
        }
        //base characteristics;

        public PlayerTemplate(string playerName, int str, int dex, int con, int pInt, int wiz, int pChar)
        {
            PlayerName = playerName;
            this.str = str;
            this.dex = dex;
            this.con = con;
            this.pInt = pInt;
            this.wiz = wiz;
            this.pChar = pChar;
        }

        public int dTwentyRoll(){
            Random rndRoll = new Random(20);
            return rndRoll.Next(1,20);
        }
    }
}
