using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Prototype
{
    internal class Pokemon
    {
        //Pokemon Database
        private int pokeID;
        private string name;
        private string type;
        private string sprite;
        private int health;

        //Constructor to be called
        public Pokemon(int ID, string pokeName, string pokeType, string pokesprite, int pokeHealth)
        {
            pokeID = ID;
            name = pokeName;
            type = pokeType;
            sprite = pokesprite;
            health = pokeHealth;
        }
        public Pokemon()
        {

        }
        public int getPokeID()
        {
            return pokeID;
        }
        public string getName()
        {
            return name;
        }
        public string getType()
        {
            return type;
        }
        public string getSprite()
        {
            return sprite;
        }
        public int getHealth()
        {
            return health;
        }
    }
}
