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

namespace Broker_Management
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
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

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonNewBroker_Click(object sender, EventArgs e)
        {
            NewBroker newBroker = new NewBroker();
            newBroker.ShowDialog();

        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            FixLater fixLater = new FixLater();
            fixLater.ShowDialog();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            FixLater fixLater = new FixLater();
            fixLater.ShowDialog();
        }
    }
}
