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
    public partial class EditClient : Form
    {
        public EditClient()
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
        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public void fetchData(int searchClientID)
        {
            Con.Open();
            string sql = "select fullName,fathersName,mothersName,phone,address From ClientInfo where clientID=" + searchClientID;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewSearch.DataSource = ds.Tables[0];
            Con.Close();

            string done = dataGridViewSearch.SelectedRows[0].Cells[0].Value.ToString();
            textBoxfullName.Text = done;
            done = dataGridViewSearch.SelectedRows[0].Cells[1].Value.ToString();
            textBoxfName.Text = done;
            done = dataGridViewSearch.SelectedRows[0].Cells[2].Value.ToString();
            textBoxmName.Text = done;
            done = dataGridViewSearch.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPhone.Text = done;
            done = dataGridViewSearch.SelectedRows[0].Cells[4].Value.ToString();
            textBoxAddress.Text = done;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchClientID = Convert.ToInt32(textBoxClientID.Text);
            fetchData(searchClientID);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int searchClientID = Convert.ToInt32(textBoxClientID.Text);
            string fullName = textBoxfullName.Text;
            string fathersName = textBoxfName.Text;
            string mothersName = textBoxmName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;

            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ClientInfo set fullName=@fullName, fathersName@fathersName, mothersName@mothersName, phone@phone, address@address where clientID=" + searchClientID, Con);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@fathersName", fathersName);
            cmd.Parameters.AddWithValue("@mothersName", mothersName);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
