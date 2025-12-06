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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokemonSelection ps = new PokemonSelection();
            ps.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokemonSelection ps = new PokemonSelection();
            ps.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Leaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Backgrounds_Click(object sender, EventArgs e)
        {
            this.Hide();
            Background background = new Background();
            background.ShowDialog();
            this.Close();
        }
    }
}
