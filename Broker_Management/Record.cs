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
    public partial class Record : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");

        string status;
        //Fileds
        private int borderSize = 2;

        //Constructor
        public Record()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //BorderSize
            this.BackColor = Color.FromArgb(255, 255, 255); //BorderColor
            GetClient();
        }

        private void GetClient()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from ClientInfo", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("clientID", typeof(int));
            dt.Load(dr);
            comboBoxClient.ValueMember = "clientID";
            comboBoxClient.DataSource = dt;
            Con.Close();
        }
        private void InsertTransaction()
        {
            string date = DateTime.Now.ToShortDateString();
            int dealAmmount = Int32.Parse(textBoxAmount.Text);
            float fee = Int32.Parse(textBoxFee.Text);
            float profitCal = dealAmmount * (fee / 100);
            string profit = Convert.ToString(profitCal);
            if (checkBoxDone.Checked)
            {
                status = "Complete";
            }
            else
            {
                status = "Incomplete";
            }
           

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into RecordInfo(date,clientName,purpose,dealAmmount,fee,profit,status) values(@date,@clientName,@purpose,@dealAmmount,@fee,@profit,@status)", Con);
            cmd.Parameters.AddWithValue("@date", date.ToString());
            cmd.Parameters.AddWithValue("@clientName", comboBoxClient.Text);
            cmd.Parameters.AddWithValue("@purpose", textBoxPurpose.Text);
            cmd.Parameters.AddWithValue("@dealAmmount", textBoxAmount.Text);
            cmd.Parameters.AddWithValue("@fee", textBoxFee.Text);
            cmd.Parameters.AddWithValue("@profit", profit);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("New Record Added!");
        }

        private string checkboxValue()
        {
            string done = "Complete";
            return done;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //timer eventhandler
       

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

        //Overidden Methods
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0083;
            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
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

        private void addButton_Click(object sender, EventArgs e)
        {
            AddClient obj = new AddClient();
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
        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            TransactionList obj = new TransactionList();
            obj.Show();
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

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void textBoxPurpose_Enter(object sender, EventArgs e)
        {
            if (textBoxPurpose.Text == "Purpose")
            {
                textBoxPurpose.Text = "";
                textBoxPurpose.ForeColor = Color.Black;
            }
        }

        private void textBoxPurpose_Leave(object sender, EventArgs e)
        {
            if (textBoxPurpose.Text == "")
            {
                textBoxPurpose.Text = "Purpose";
                textBoxPurpose.ForeColor = Color.Silver;
            }
        }

        private void textBoxAmount_Enter(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "Dealing Amount")
            {
                textBoxAmount.Text = "";
                textBoxAmount.ForeColor = Color.Black;
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "")
            {
                textBoxAmount.Text = "Dealing Amount";
                textBoxAmount.ForeColor = Color.Silver;
            }
        }

        private void textBoxFee_Enter(object sender, EventArgs e)
        {
            if (textBoxFee.Text == "Fee")
            {
                textBoxFee.Text = "";
                textBoxFee.ForeColor = Color.Black;
            }
        }

        private void textBoxFee_Leave(object sender, EventArgs e)
        {
            if (textBoxFee.Text == "")
            {
                textBoxFee.Text = "Fee";
                textBoxFee.ForeColor = Color.Silver;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            InsertTransaction();
        }

        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDone.Checked)
            {
                status = checkboxValue();
            }
            else
            {
                status = "Incomplete";
            }
            
        }
    }
}
