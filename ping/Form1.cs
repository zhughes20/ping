using System;
using System.Windows.Forms;
using System.Diagnostics;
namespace ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string ping = "";
            ping = txtInput.Text;
            ping = "/K cd c:/ && ping " + ping;
            Process.Start("CMD.exe", ping);            
        }
    }
}
