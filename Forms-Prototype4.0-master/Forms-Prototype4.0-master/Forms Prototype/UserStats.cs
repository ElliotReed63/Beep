using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Prototype
{
    public class UserStats
    {
        public string Name { get; set; }
        public int Battles { get; set; }
        public int Winrate { get; set; }
        public int UserID { get; set; }
        public int Loses { get; set; }
        public int Wins { get; set; }
        public UserStats(int userID, string name, int wins, int loses, int winrate, int battles)
        {
            UserID = userID;
            Name = name;
            Wins = wins;
            Loses = loses;
            Winrate = winrate;
            Battles = battles;
        }
        public UserStats()
        {

        }
        public int getUserID()
        {
            return UserID;
        }
        public string getName()
        {
            return Name;
        }
        public int getWins()
        {
            return Wins;
        }
        public int getLoses()
        {
            return Loses;
        }
        public int getWinrate()
        {
            return Winrate;
        }
        public int getBattles()
        {
            return Battles;
        }
        public void setUserID(int userID)
        {
            UserID = userID;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void setWins(int wins)
        {
            Wins = wins;
        }
        public void setLoses(int loses)
        {
            Loses = loses;
        }
        public void setWinrate(int winrate)
        {
            Winrate = winrate;
        }
        public void setBattles(int battles)
        {
            Battles = battles;
        }


    }

}
