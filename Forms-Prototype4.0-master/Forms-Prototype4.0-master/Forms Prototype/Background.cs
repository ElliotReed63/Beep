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
    public partial class Background : BaseGUI
    {
        public Background()
        {
            InitializeComponent();
            this.Shown += LeaderboardForm_Shown;
        }
        private void LeaderboardForm_Shown(object sender, EventArgs e)
        {
            // OPTIONAL: Only if you need the background on startup.
            // LoadBackground();
        }


        private void Background_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBackground();
        }
        private void LoadBackground()
        {
            int ImageID = 1;
            PokemonDatabase database = new PokemonDatabase();
            (Image img, byte[] beep) = database.SelectBackground(ImageID);

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int ImageID = 2;
            PokemonDatabase database = new PokemonDatabase();
            (Image img, byte[] beep) = database.SelectBackground(ImageID);

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int ImageID = 2;
            PokemonDatabase database = new PokemonDatabase();
            (Image img, byte[] beep) = database.SelectBackground(ImageID);

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
