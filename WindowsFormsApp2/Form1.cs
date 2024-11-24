using cxapi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class hacked : Form
    {
        public hacked()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CoreFunctions.KillRoblox();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
