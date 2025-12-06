using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Prototype
{
    public partial class PokemonSelection : Form
    {
        private List<Pokemon> pokemons;
        public PokemonSelection()
        {
            InitializeComponent();
        }

        private void PokemonSelection_Load(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = tb_Pokemon.Text;
            lb_Pokemon.Items.Clear();
            PokemonDatabase db = new PokemonDatabase();
            pokemons = db.getPokemon(search);
            if (pokemons.Count > 0)
            {
                foreach (Pokemon p in pokemons)
                {
                    lb_Pokemon.Items.Add(p.getName() + " " + p.getType() + " " + p.getHealth());
                }
            }
            else
            {
                MessageBox.Show("No Pokemon found. Please try again.");
            }
        }

        private void lb_Pokemon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
