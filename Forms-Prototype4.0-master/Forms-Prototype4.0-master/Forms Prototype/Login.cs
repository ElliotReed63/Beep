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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;
            User Hello = new User();
            Hello.setName(username);
            Hello.setPassword(password);
            MessageBox.Show(password);
            
            PokemonDatabase user = new PokemonDatabase();
            Hello = user.LoginHash(Hello);
            string A = Hello.getPassword();
            MessageBox.Show(A);
            password = Hello.getPassword();
            bool Check = user.LoginCheck(username, password);

            if (Check)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password was invalid");
            }
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount CA = new CreateAccount();
            CA.ShowDialog();
            this.Close();
        }
    }
}
