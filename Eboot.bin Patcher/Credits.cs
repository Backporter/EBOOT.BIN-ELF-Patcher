using System.Diagnostics;
using System.Windows.Forms;

namespace Eboot.bin_Patcher
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/twpSyYp");
        }
    }
}
