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
    public partial class EditTrac : Form
    {
        //Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");

        public EditTrac()
        {
            InitializeComponent();
            panelSearchData.Visible = false;
            labelMark.Visible = false;
            dataGridViewSearch.Visible = false;
            buttonUpdate.Visible = false;
            checkBoxDone.Visible = false;
        }

        private void textBoxTracID_Enter(object sender, EventArgs e)
        {
            if (textBoxTracID.Text == "Enter Transaction ID")
            {
                textBoxTracID.Text = "";
                textBoxTracID.ForeColor = Color.Black;
            }
            
        }

        private void textBoxTracID_Leave(object sender, EventArgs e)
        {
            if (textBoxTracID.Text == "")
            {
                textBoxTracID.Text = "Enter Transaction ID";
                textBoxTracID.ForeColor = Color.Silver;
            }
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxTracID.Text != string.Empty && textBoxTracID.Text != "Enter Transaction ID")
            {
                int searchTracID = Convert.ToInt32(textBoxTracID.Text);
                fetchData(searchTracID);

            }
            else
            {
                MessageBox.Show("Transaction ID can't be empty!");
            }
        }
        public void fetchData(int searchTracID)
        {
            Con.Open();
            string sql = "select dealAmmount,fee,profit,status From RecordInfo where tracID=" + searchTracID;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewSearch.DataSource = ds.Tables[0];
            Con.Close();

            
            panelSearchData.Visible = true;
            labelMark.Visible = true;
            dataGridViewSearch.Visible = true;
            buttonUpdate.Visible = true;
            checkBoxDone.Visible = true;
            string done = dataGridViewSearch.SelectedRows[0].Cells[3].Value.ToString();
            if (done != "Complete")
            {
                checkBoxDone.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBoxDone.CheckState = CheckState.Checked;
            }
        }
        private void updateStatus(int searchTracID)
        {
            string status;
            if (checkBoxDone.Checked == true)
            {
                status = "Complete";
               
            }
            else
            {
                status = "Incomplete";
            }
            insertProfit(searchTracID);
            Con.Open();
            SqlCommand cmd = new SqlCommand("update RecordInfo set status=@status where tracID="+ searchTracID, Con);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Payment Status Updated!");
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            int searchTracID = Convert.ToInt32(textBoxTracID.Text);
            updateStatus(searchTracID);
            
        }

        private void insertProfit(int searchTracID)
        {
            
            float profitCal = 0;
            string dm = dataGridViewSearch.SelectedRows[0].Cells[0].Value.ToString();
            string f = dataGridViewSearch.SelectedRows[0].Cells[1].Value.ToString();
            int dealAmmount = Int32.Parse(dm);
            float fee = Int32.Parse(f);
            string profit = Convert.ToString(profitCal);

            if (checkBoxDone.Checked == true)
            {
               
                profitCal = dealAmmount * (fee / 100);
                profit = Convert.ToString(profitCal);
            }
            else
            {
                
                
            }

            Con.Open();
            SqlCommand cmd = new SqlCommand("update RecordInfo set profit=@profit where tracID=" + searchTracID, Con);
            cmd.Parameters.AddWithValue("@profit", profit);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
