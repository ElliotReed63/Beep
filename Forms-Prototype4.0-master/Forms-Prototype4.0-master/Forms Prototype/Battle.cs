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
    public partial class Battle : Form
    {
        private readonly List<Pokemon> playerTeam;

        /// <summary>
        /// Default constructor kept for the designer; routes to the
        /// team-aware overload with an empty roster.
        /// </summary>
        public Battle() : this(new List<Pokemon>())
        {
        }

        /// <summary>
        /// Receives the player's chosen team so it can be displayed
        /// when the battle form opens.
        /// </summary>
        /// <param name="selectedTeam">Pokémon chosen on the selection form.</param>
        public Battle(List<Pokemon> selectedTeam)
        {
            InitializeComponent();
            playerTeam = selectedTeam ?? new List<Pokemon>();
            PopulateTeamList();
        }

        /// <summary>
        /// Writes the selected team into the battle list box. If you need
        /// to pass different data (e.g., the opponent team or user stats),
        /// add extra constructor parameters and store them in fields the
        /// same way <see cref="playerTeam"/> is handled here.
        /// </summary>
        private void PopulateTeamList()
        {
            // Show both the name and current HP so the player knows what
            // roster they brought into the fight.
            foreach (Pokemon pokemon in playerTeam)
            {
                TeamListBox.Items.Add($"{pokemon.getName()} ({pokemon.getHealth()} HP)");
            }
        }
    }
}
