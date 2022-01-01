using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Broker_Management
{
    public partial class AddClient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");
        private void InsertClient()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into ClientInfo(fullName,fathersName,mothersName,phone,address,postalCode) values(@fullName,@fName,@mName,@phone,@address,@postal)", Con);
            cmd.Parameters.AddWithValue("@fullName", textBoxFullName.Text);
            cmd.Parameters.AddWithValue("@fName", textBoxfName.Text);
            cmd.Parameters.AddWithValue("@mName", textBoxmName.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
            cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
            cmd.Parameters.AddWithValue("@postal", textBoxZip.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("New Client Added!");
        }
        //Fileds
        private int borderSize = 2;

        //Constructor
        public AddClient()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //BorderSize
            this.BackColor = Color.FromArgb(255, 255, 255); //BorderColor
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        //Events Methods
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //Private Methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BtnClickingNew Windows Form Open
        private void iconButtonDasboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
        private void recordButton_Click(object sender, EventArgs e)
        {
            Record obj = new Record();
            obj.Show();
            this.Hide();
        }

        private void clientListButton_Click(object sender, EventArgs e)
        {
            ClientList obj = new ClientList();
            obj.Show();
            this.Hide();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            Finance obj = new Finance();
            obj.Show();
            this.Hide();
        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFullName_Enter(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "Full Name")
            {
                textBoxFullName.Text = "";
                textBoxFullName.ForeColor = Color.Black;
            }
        }

        private void textBoxFullName_Leave(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "")
            {
                textBoxFullName.Text = "Full Name";
                textBoxFullName.ForeColor = Color.Silver;
            }
        }

        private void textBoxfName_Enter(object sender, EventArgs e)
        {
            if (textBoxfName.Text == "Father's Name")
            {
                textBoxfName.Text = "";
                textBoxfName.ForeColor = Color.Black;
            }
        }

        private void textBoxfName_Leave(object sender, EventArgs e)
        {
            if (textBoxfName.Text == "")
            {
                textBoxfName.Text = "Father's Name";
                textBoxfName.ForeColor = Color.Silver;
            }
        }

        private void textBoxmName_Enter(object sender, EventArgs e)
        {
            if (textBoxmName.Text == "Mother's Name")
            {
                textBoxmName.Text = "";
                textBoxmName.ForeColor = Color.Black;
            }
        }

        private void textBoxmName_Leave(object sender, EventArgs e)
        {
            if (textBoxmName.Text == "")
            {
                textBoxmName.Text = "Mother's Name";
                textBoxmName.ForeColor = Color.Silver;
            }
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "Phone")
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = Color.Black;
            }
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                textBoxPhone.Text = "Phone";
                textBoxPhone.ForeColor = Color.Silver;
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Full Address")
            {
                textBoxAddress.Text = "";
                textBoxAddress.ForeColor = Color.Black;
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "")
            {
                textBoxAddress.Text = "Full Address";
                textBoxAddress.ForeColor = Color.Silver;
            }
        }

        private void textBoxZip_Enter(object sender, EventArgs e)
        {
            if (textBoxZip.Text == "Postal Code")
            {
                textBoxZip.Text = "";
                textBoxZip.ForeColor = Color.Black;
            }
        }

        private void textBoxZip_Leave(object sender, EventArgs e)
        {
            if (textBoxZip.Text == "")
            {
                textBoxZip.Text = "Postal Code";
                textBoxZip.ForeColor = Color.Silver;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            InsertClient();
        }
    }
}
