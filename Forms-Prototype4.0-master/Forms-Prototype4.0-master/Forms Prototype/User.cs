using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Prototype
{
    internal class User
    {
        private string Username;
        private string Password;
        private int Wins;
        private int UserID;
        private string Salt;

        public User(int userID , string username, string password , int wins, string salt)
        {
            Username = username;
            Password = password;
            Wins = wins;
            UserID = userID;
            Salt = salt;
            
        }
        public User()
        {

        }
        public string getUser()
        {
            return Username;
        }
        public string getPassword()
        {
            return Password;
        }
        public int getWins()
        {
            return Wins;
        }
        public string getSalt()
        {
            return Salt;
        }
        public int getUserID()
        {
            return UserID;
        }
        public void setName(string name)
        {
            Username = name;
        }
        public void setPassword(string password)
        {
            Password = password;
        }
        public void setSalt(string salt)
        {
            Salt = salt;
        }
        public void setWins(int wins)
        {
            Wins = wins;
        }
        public void setUserID(int userID)
        {
            UserID = userID;
        }
    }
}
