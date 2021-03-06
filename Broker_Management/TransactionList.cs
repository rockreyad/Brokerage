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
    public partial class TransactionList : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");

        private void getTracList()
        {

            Con.Open();
            string sql = "select * from RecordInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewTracList.DataSource = ds.Tables[0];
            Con.Close();
        }
        //Fileds
        private int borderSize = 2;

        //Constructor
        public TransactionList()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //BorderSize
            this.BackColor = Color.FromArgb(255, 255, 255); //BorderColor

            getTracList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlertStatus();
        }
        private void AlertStatus()
        {
            int numberOfRows = dataGridViewTracList.Rows.Count;
            string getFee;
            for (int i = 0; i < numberOfRows; i++)
            {
                getFee = dataGridViewTracList.Rows[i].Cells[5].Value.ToString();
                int fee = Convert.ToInt32(getFee);
                //string gg = fee.ToString() + "%";
                //dataGridViewTracList.Rows[i].Cells[5].Value = gg.ToString();

                string getStatus = dataGridViewTracList.Rows[i].Cells[7].Value.ToString();
                if(getStatus == "Incomplete")
                {
                    dataGridViewTracList.Rows[i].Cells[7].Value = getStatus.ToUpper();

                    dataGridViewTracList.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 65, 91);
                }
            }
            
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
            this.Hide();
        }

        //BtnClickingNew Windows Form Open
        private void iconButtonDasboard_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
