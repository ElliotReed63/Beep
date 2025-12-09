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
        private List<Pokemon> selectedTeam = new List<Pokemon>();

        // Expose a copy of the team so other forms cannot mutate
        // the underlying list accidentally.
        public List<Pokemon> SelectedTeam => new List<Pokemon>(selectedTeam);
        public PokemonSelection()
        {
            InitializeComponent();
        }

        private void PokemonSelection_Load(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (lb_Pokemon.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Pokemon before adding it to your team.");
                return;
            }
            if (selectedTeam.Count >= 6)
            {
                MessageBox.Show("You have already selected 6 Pokemon for your team.");
                return;
            }
            if (pokemons == null || lb_Pokemon.SelectedIndex >= pokemons.Count)
            {
                MessageBox.Show("Please search for a Pokemon and try again.");
                return;
            }

            Pokemon chosenPokemon = pokemons[lb_Pokemon.SelectedIndex];
            if (selectedTeam.Any(p => p.getPokeID() == chosenPokemon.getPokeID()))
            {
                MessageBox.Show("This Pokemon is already in your team.");
                return;
            }

            selectedTeam.Add(chosenPokemon);
            lb_SelectedPokemon.Items.Add(FormatPokemonDisplay(chosenPokemon));
            TeamCountLabel.Text = "Team Size: " + selectedTeam.Count + "/6";
            if (selectedTeam.Count == 6)
            {
                MessageBox.Show("Team complete! You have selected all 6 Pokemon.");
            }
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
                    lb_Pokemon.Items.Add(FormatPokemonDisplay(p));
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

        private void TeamCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void lb_SelectedPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the battle screen with the team collected here. This same
        /// pattern can be reused to pass any other data between forms (for
        /// example, user information or battle settings) by adding extra
        /// parameters to the <see cref="Battle"/> constructor.
        /// </summary>
        private void StartBattle_Click(object sender, EventArgs e)
        {
            if (selectedTeam.Count == 0)
            {
                MessageBox.Show("Select at least one Pokemon before starting a battle.");
                return;
            }

            // Pass a copy so the battle form cannot modify the selection state.
            Battle battle = new Battle(new List<Pokemon>(selectedTeam));
            battle.ShowDialog();
        }

        /// <summary>
        /// Formats Pokemon data for list displays so both forms show the same
        /// text. Adjust this helper to change the presentation everywhere.
        /// </summary>
        private static string FormatPokemonDisplay(Pokemon pokemon)
        {
            return $"{pokemon.getName()} {pokemon.getType()} {pokemon.getHealth()}";
        }
    }
}
