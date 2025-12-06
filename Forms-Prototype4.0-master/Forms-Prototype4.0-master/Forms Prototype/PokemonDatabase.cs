using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Forms_Prototype
{
    internal class PokemonDatabase
    {
        private MySql.Data.MySqlClient.MySqlConnection myConnection;
        private const string myConnectionString = "server=62.171.193.18;uid=ElliotR;pwd=Computer99!;database=elliotr";

        public PokemonDatabase()
        {
            try
            {
                myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                myConnection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Pokemon getPokemonFromID(int pokeID)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = @"SELECT * FROM pokemon WHERE pokeID = @pokeID";
                myCommand.Parameters.AddWithValue("@pokeID", pokeID);

                using var myReader = myCommand.ExecuteReader();
                myReader.Read();
                int id = myReader.GetInt32("pokeID");
                string name = myReader.GetString("name");
                string type = myReader.GetString("type");
                string sprite = myReader.GetString("sprite");
                int health = myReader.GetInt32("health");
                Pokemon currentPokemon = new Pokemon(id, name, type, sprite, health);
                myConnection.Close();
                return currentPokemon;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Pokemon noPokemon = new Pokemon();
            return noPokemon;
        }
        public List<Pokemon> getPokemon(string partName)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = @"SELECT * FROM pokemon WHERE name LIKE @partName;";
                myCommand.Parameters.AddWithValue("@partName", "%" + partName + "%");

                using var myReader = myCommand.ExecuteReader();
                {
                    while (myReader.Read())
                    {
                        int id = myReader.GetInt32("pokeID");
                        string name = myReader.GetString("name");
                        string type = myReader.GetString("type");
                        string sprite = myReader.GetString("sprite");
                        int health = myReader.GetInt32("health");
                        Pokemon currentPokemon = new Pokemon(id, name, type, sprite, health);
                        pokemons.Add(currentPokemon);

                    }
                }
                myConnection.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pokemons;
        }
        public bool LoginCheck(string username, string password)
        {
            int Check = 0;
            MessageBox.Show(password);
            MessageBox.Show(username);
            try
            {

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.CommandText = @"SELECT username, password FROM user WHERE username = @Username AND password = @password";
                myCommand.Parameters.AddWithValue("@Username", username);
                myCommand.Parameters.AddWithValue("@password", password);

                using var myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    return true;
                }
                myReader.Close();
                myConnection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return false;
        }
        public List<User> getUserWins()
        {
            List<User> users = new List<User>();
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = @"SELECT wins FROM userstats ORDER BY wins DESC;";
                using var myReader = myCommand.ExecuteReader();
                {
                    while (myReader.Read())
                    {
                        string name = "Jeff";
                        int wins = myReader.GetInt32("Wins");
                        string password = "nul";
                        int userID = 0;
                        string salt = null;
                        User currentuser = new User(userID ,name, password, wins,salt);
                        users.Add(currentuser);

                    }
                }
                myConnection.Close();
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
            MessageBox.Show(ex.Message);
            }
            return users;
        }
        public bool CreateUser(string username, string password)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = @"INSERT INTO `user` (username, password, wins) VALUES (@username, @password, @wins)";
                myCommand.Parameters.AddWithValue("@username", username);
                myCommand.Parameters.AddWithValue("@password", password);
                myCommand.Parameters.AddWithValue("@wins", 0);
                
                using var myReader = myCommand.ExecuteReader();
                //Force a set password length e.g. 5 or more
                //Force username to be unique
                //Force username to be a length of 3 or more
                while (myReader.Read())
                {
                    
                }
                myConnection.Close();
                return true;
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return false;

        }
        public (string, string) PasswordHash(string password)
        {


            string Password = password;
            int keysize = 32;
            int iterations = 1000;

            RandomNumberGenerator RNG = RandomNumberGenerator.Create();
            byte[] salt = new byte[32];
            RNG.GetBytes(salt);
            string stringSalt = Convert.ToBase64String(salt);
            string hashedPassword = password + stringSalt;
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256); //Takes Password, salt and iterations variables
            byte[] key = pbkdf2.GetBytes(keysize);   
            string HashedKey = Convert.ToBase64String(key);
            return (HashedKey, stringSalt);
        }
        public User LoginHash(User User)
        {
            User users = new User();
            string username = User.getUser();
            string password = User.getPassword();
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = @"SELECT * FROM user WHERE username = @username";
                myCommand.Parameters.AddWithValue("@username", username);
                
                using var myReader = myCommand.ExecuteReader();
                //Force a set password length e.g. 5 or more
                //Force username to be unique
                //Force username to be a length of 3 or more
                while (myReader.Read())
                {
                    
                    string Salt = myReader.GetString("salt");
                    users.setPassword(password);
                    users.setSalt(Salt);
                    users.setName(username);
                }
                myConnection.Close();
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            int keysize = 32;
            int iterations = 1000;

            RandomNumberGenerator RNG = RandomNumberGenerator.Create();
            byte[] salt = Convert.FromBase64String(users.getSalt());
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            byte[] key = pbkdf2.GetBytes(keysize);
            string HashedKey = Convert.ToBase64String(key);
            users.setPassword(HashedKey);
            return users;
        }

        public  List<UserStats> GetUserstats()
        {
            List<UserStats> users = new List<UserStats>();
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = ("SELECT * FROM userstats WHERE battles>1");
                using var myReader = myCommand.ExecuteReader();
                
                while (myReader.Read())
                {
                    int id = myReader.GetInt32("userID");
                    string username = myReader.GetString("username");
                    int wins = myReader.GetInt32("wins");
                    int loses = myReader.GetInt32("loses");
                    int winrate = myReader.GetInt32("winrate");
                    int battles = myReader.GetInt32("battles");
                    UserStats temporaryUser = new UserStats(id, username, wins, loses, winrate,battles);
                    users.Add(temporaryUser);
                }
                myConnection.Close();

            }
            catch
            {

            }
            return users;
        }
        public (Image , byte[] ) SelectBackground(int imageID)
        {
            Image img = null;
            byte[] imgBytes = null;
            string imgID = Convert.ToString(imageID);
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = ("SELECT image_data FROM backgrounds WHERE id =@imgID ");
            myCommand.Parameters.AddWithValue("@imgID", imgID);

            using var myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                imgBytes = (byte[])myReader["image_data"];
                using MemoryStream ms = new MemoryStream(imgBytes); //turns the byte list into a temporary file
                img = Image.FromStream(ms); //takes the temporary file and turns it into an object (image)
                
            }
            
            return (img , imgBytes);
        }
    }
}

