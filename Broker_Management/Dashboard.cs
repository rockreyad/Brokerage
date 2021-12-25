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

//Custom Dependencies


namespace Broker_Management
{
    public partial class Dashboard : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");

        public string GetIncomeText()
        {
            string income;
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(profit) FROM RecordInfo", Con);
            Int32 count = (Int32)cmd.ExecuteScalar();
            income = count.ToString();
            Con.Close();
            return income;
        }
        public string GetTotalClient()
        {
            string income;
            Con.Open();
            SqlCommand totalClient = new SqlCommand("SELECT COUNT(clientID) FROM ClientInfo", Con);
            Int32 count = (Int32)totalClient.ExecuteScalar();
            Int32 clientcount = (Int32)totalClient.ExecuteScalar();
            income = count.ToString();
            Con.Close();
            return income;
        }

        public string GetTransaction()
        {
            string income;
            Con.Open();
            SqlCommand totalClient = new SqlCommand("SELECT COUNT(tracID) FROM RecordInfo", Con);
            Int32 count = (Int32)totalClient.ExecuteScalar();
            Int32 clientcount = (Int32)totalClient.ExecuteScalar();
            income = count.ToString();
            Con.Close();
            return income;
        }
        Timer timer = new Timer();
        //Fileds
        private int borderSize = 2;

        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //BorderSize
            this.BackColor = Color.FromArgb(255, 255, 255); //BorderColor
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            //timer interval
            timer.Interval = 1000; // in milliseconds
            timer.Tick += new EventHandler(this.timer_Tick);

            //start timer when form loads
            timer.Start(); //this will use timer_Tick() method

            //income update from database
            labelincome.Text = GetIncomeText() + " Tk";
            labelTotalClient.Text = GetTotalClient();
            labelTransactions.Text = GetTransaction();
        }

        //timer eventhandler
        private void timer_Tick(object sender,EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if(hh<10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if(mm<10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if(ss<10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //Update label
            labelTimer.Text = time;
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

        //Overidden Methods
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0083;
            if(m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == 1)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            AddClient obj = new AddClient();
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

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonDeveloper_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            obj.Show();
        }

        private void iconButtonEditTrac_Click(object sender, EventArgs e)
        {
            EditTrac editTrac = new EditTrac();
            editTrac.ShowDialog();
        }

        private void iconButtonEditClient_Click(object sender, EventArgs e)
        {
            EditClient editClient = new EditClient();
            editClient.ShowDialog();
        }
    }
}
