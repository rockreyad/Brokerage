using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker_Management
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonUnlockAdmin_Click(object sender, EventArgs e)
        {
            check();
        }


        private void check()
        {
            if (textBoxSKey.Text != string.Empty)
            {
                if(textBoxSKey.Text == "UnlockPlease")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Secret key is not Correct!");
                }
              
            }
            else
            {
                MessageBox.Show("Please Enput Secret Key!");
            }
        }
        private void iconButtonShowPass_Click(object sender, EventArgs e)
        {
            if (textBoxSKey.UseSystemPasswordChar == true)
            {
                textBoxSKey.UseSystemPasswordChar = false;
                iconButtonShowPass.BackgroundImage = Properties.Resources.visiable;
            }
            else
            {
                textBoxSKey.UseSystemPasswordChar = true;
                iconButtonShowPass.BackgroundImage = Properties.Resources.eye;
            }


        }
    }
}
