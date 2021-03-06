using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker_Management
{
    public partial class NewBroker : Form
    {
        public NewBroker()
        {
            InitializeComponent();
        }


        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //Database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void addNewBroker()
        {
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into BrokerLoginInfo(userName,userPassword) values(@userName,@userPassword)", Con);
            cmd.Parameters.AddWithValue("@userName", textBoxUName.Text.ToUpper());
            cmd.Parameters.AddWithValue("@userPassword", textBoxUPass.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("New Broker Has Added!");
        }
        private void buttonNewBroker_Click(object sender, EventArgs e)
        {
            if(textBoxUName.Text != string.Empty && textBoxUName.Text != "User Name")
            {
                if(textBoxUPass.Text != string.Empty && textBoxUPass.Text != "User Password")
                {
                    addNewBroker();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Password Can't Empty!");
                }
            }
            else
            {
                MessageBox.Show("User Name Can't Empty!");
            }
            
        }

        private void textBoxUName_Enter(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "User Name")
            {
                textBoxUName.Text = "";
                textBoxUName.ForeColor = Color.Black;
            }
        }

        private void textBoxUName_Leave(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "")
            {
                textBoxUName.Text = "User Name";
                textBoxUName.ForeColor = Color.Silver;
            }
        }

        private void textBoxUPass_Enter(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "User Password")
            {
                textBoxUPass.Text = "";
                textBoxUPass.ForeColor = Color.Black;
            }
        }

        private void textBoxUPass_Leave(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "")
            {
                textBoxUPass.Text = "User Password";
                textBoxUPass.ForeColor = Color.Silver;
            }
        }


    }
}
