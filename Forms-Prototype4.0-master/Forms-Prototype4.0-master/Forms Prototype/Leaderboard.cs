using Google.Protobuf.Compiler;
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
    public partial class Leaderboard : Form
    {
        private List<User> users;
        private List<UserStats> userstats;
        public Leaderboard()
        {
            InitializeComponent();
            BindingList<UserStats> people = new BindingList<UserStats>
    {
        new UserStats { Name = "Bob", Battles = 1, Winrate = 1, UserID = 1, Loses = 1 },
        new UserStats { Name = "Alice", Battles = 2, Winrate = 50, UserID = 2, Loses = 1 }
    };

            dataGridView1.DataSource = people;
            dataGridView1.AutoGenerateColumns = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LeaderboardLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void ShowLeaderboard_Click(object sender, EventArgs e)
        {
            PokemonDatabase db = new PokemonDatabase();
            LeaderboardLB.Items.Clear();
            users = db.getUserWins();

            foreach (User p in users)
            {
                LeaderboardLB.Items.Add(p.getUser() + " " + p.getWins());
            }
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PokemonDatabase db = new PokemonDatabase();
            userstats = db.GetUserstats();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
