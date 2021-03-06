using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker_Management
{
    public partial class LoginForm : Form
    {
        string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConStr);
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "ENTER USERNAME")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "ENTER USERNAME")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            validCheck();
        }

        private void validCheck()
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string query = @"SELECT 
      [userName]
      ,[userPassword]
  FROM [dbo].[BrokerLoginInfo] Where userName ='" + username+ "' AND userPassword='" + password+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            if (username!= string.Empty)
            {
                if(password != string.Empty)
                {
                   
                    if (dr.Read())
                    {
                            Dashboard obj = new Dashboard();
                            obj.Show();
                            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Creditionals !", "Miss-Match Information");
    
                    }
                }else
                    MessageBox.Show("Password Can't be Empty!", "Miss-Match Information");
            }
            else
                MessageBox.Show("Username Can't be Empty!", "Miss-Match Information");
            con.Close();
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonShowPass_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                iconButtonShowPass.BackgroundImage = Properties.Resources.visiable;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                iconButtonShowPass.BackgroundImage = Properties.Resources.eye;
            }


        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.ShowDialog();
            this.Hide();        }
    }
}
