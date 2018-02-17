
using System;
namespace PathFinderCore
{
    public class PlayerTemplate
    {
        public string PlayerName;
        public string PlayerClass;
        public int str;
        public int dex;
        public int con;
        public int pInt;
        public int wiz;
        public int pChar;

        //empty constructor;

        public PlayerTemplate(){
            
        }
        //base characteristics;

        public PlayerTemplate(string playerName, string playerClass, int str, int dex, int con, int pInt, int wiz, int pChar)
        {
            PlayerName = playerName;
            PlayerClass = playerClass;
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
