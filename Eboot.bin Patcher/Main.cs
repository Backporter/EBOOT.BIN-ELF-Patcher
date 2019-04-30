using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eboot.bin_Patcher
{
    public partial class Main : Form
    {
        public Main()
        {
           InitializeComponent();
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Credits"] == null)
            {
                Credits form = new Credits();
                form.Show();
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Help"] == null)
            {
                Help form = new Help();
                form.Show();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            
            //Ihis Is Offsets For skyrim
            OpenFileDialog SOFD = new OpenFileDialog();
            SOFD.ShowDialog();
            BinaryReader Sbr = new BinaryReader(File.OpenRead(OFD.FileName));
            string SCCCfile = null;
            for (int i = 0x18ABEBD; i <= 0x18ABEC6; i++)
            {
                Sbr.BaseStream.Position = i;
                SCCCfile += Sbr.ReadByte().ToString("X2");
            }
            ///
            {
                ///And Fallout 4
                OpenFileDialog FOFD = new OpenFileDialog();
                FOFD.ShowDialog();
                BinaryReader Fbr = new BinaryReader(File.OpenRead(OFD.FileName));
                string FCCCfile = null;
                for (int i = 0x18ABEBD; i <= 0x18ABEC4; i++)
                {
                    Fbr.BaseStream.Position = i;
                    FCCCfile += Fbr.ReadByte().ToString("X2");
                }
                Fbr.Close();
                /// and skyrim 1.08
                OpenFileDialog S8OFD = new OpenFileDialog();
                FOFD.ShowDialog();
                BinaryReader S8br = new BinaryReader(File.OpenRead(OFD.FileName));
                string S8CCCfile = null;
                for (int i = 0x18ABA9D; i <= 0x18ABAA6; i++)
                {
                    Fbr.BaseStream.Position = i;
                    S8CCCfile += Fbr.ReadByte().ToString("X2");
                }
                Fbr.Close();
                /// EU skyrim 1.09
                OpenFileDialog EUSOFD = new OpenFileDialog();
                FOFD.ShowDialog();
                BinaryReader EUSbr = new BinaryReader(File.OpenRead(OFD.FileName));
                string EUSCCCfile = null;
                for (int i = 0x18B6F0D; i <= 0x18B6F16; i++)
                {
                    Fbr.BaseStream.Position = i;
                    EUSCCCfile += Fbr.ReadByte().ToString("X2");
                }
                Fbr.Close();
            }
        }

        OpenFileDialog OFD = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
        }

        private void updates_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Updates"] == null)
            {
                Updates form = new Updates();
                form.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Extracted FPKG US skyrim 1.09")
            {
                BinaryWriter Sbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Sbw.BaseStream.Position = 0x18B706D;
                Sbw.Write(0x6D);
                Sbw.BaseStream.Position = 0x18B706E;
                Sbw.Write(0x6F);
                Sbw.BaseStream.Position = 0x18B706F;
                Sbw.Write(0x64);
                Sbw.BaseStream.Position = 0x18B7070;
                Sbw.Write(0x73);
                Sbw.BaseStream.Position = 0x18B7071;
                Sbw.Write(0x2E);
                Sbw.BaseStream.Position = 0x18B7072;
                Sbw.Write(0x74);
                Sbw.BaseStream.Position = 0x18B7073;
                Sbw.Write(0x78);
                Sbw.BaseStream.Position = 0x18B7074;
                Sbw.Write(0x74);
                Sbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "Extracted FPKG US skyrim 1.08")
            {
                BinaryWriter Sbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Sbw.BaseStream.Position = 0x18B6C4D;
                Sbw.Write(0x6D);
                Sbw.BaseStream.Position = 0x18B6C4E;
                Sbw.Write(0x6F);
                Sbw.BaseStream.Position = 0x18B6C4F;
                Sbw.Write(0x64);
                Sbw.BaseStream.Position = 0x18B6C50;
                Sbw.Write(0x73);
                Sbw.BaseStream.Position = 0x18B6C51;
                Sbw.Write(0x2E);
                Sbw.BaseStream.Position = 0x18B6C52;
                Sbw.Write(0x74);
                Sbw.BaseStream.Position = 0x18B6C53;
                Sbw.Write(0x78);
                Sbw.BaseStream.Position = 0x18B6C54;
                Sbw.Write(0x74);
                Sbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "Extracted FPKG EU skyrim 1.09")
            {
                BinaryWriter Sbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Sbw.BaseStream.Position = 0x18B706D;
                Sbw.Write(0x6D);
                Sbw.BaseStream.Position = 0x18B706E;
                Sbw.Write(0x6F);
                Sbw.BaseStream.Position = 0x18B706F;
                Sbw.Write(0x64);
                Sbw.BaseStream.Position = 0x18B7070;
                Sbw.Write(0x73);
                Sbw.BaseStream.Position = 0x18B7071;
                Sbw.Write(0x2E);
                Sbw.BaseStream.Position = 0x18B7072;
                Sbw.Write(0x74);
                Sbw.BaseStream.Position = 0x18B7073;
                Sbw.Write(0x78);
                Sbw.BaseStream.Position = 0x18B7074;
                Sbw.Write(0x74);
                Sbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "Extracted FPKG EU skyrim 1.08")
            {
                MessageBox.Show("where did you get this update?");
            }

            if (textBox1.Text == "US skyrim 1.09")
            {
                BinaryWriter Sbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Sbw.BaseStream.Position = 0x18ABEBD;
                Sbw.Write(0x6D);
                Sbw.BaseStream.Position = 0x18ABEBE;
                Sbw.Write(0x6F);
                Sbw.BaseStream.Position = 0x18ABEBF;
                Sbw.Write(0x64);
                Sbw.BaseStream.Position = 0x18ABEC0;
                Sbw.Write(0x73);
                Sbw.BaseStream.Position = 0x18ABEC1;
                Sbw.Write(0x2E);
                Sbw.BaseStream.Position = 0x18ABEC2;
                Sbw.Write(0x74);
                Sbw.BaseStream.Position = 0x18ABEC3;
                Sbw.Write(0x78);
                Sbw.BaseStream.Position = 0x18ABEC4;
                Sbw.Write(0x74);
                Sbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "EU skyrim 1.09")
            {
                BinaryWriter Sbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Sbw.BaseStream.Position = 0x18B6F0D;
                Sbw.Write(0x6D);
                Sbw.BaseStream.Position = 0x18B6F0E;
                Sbw.Write(0x6F);
                Sbw.BaseStream.Position = 0x18B6F0F;
                Sbw.Write(0x64);
                Sbw.BaseStream.Position = 0x18B6F10;
                Sbw.Write(0x73);
                Sbw.BaseStream.Position = 0x18B6F11;
                Sbw.Write(0x2E);
                Sbw.BaseStream.Position = 0x18B6F12;
                Sbw.Write(0x74);
                Sbw.BaseStream.Position = 0x18B6F13;
                Sbw.Write(0x78);
                Sbw.BaseStream.Position = 0x18B6F14;
                Sbw.Write(0x74);
                Sbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            else if (textBox1.Text == "US skyrim 1.08")
            {
                BinaryWriter S8Sbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                S8Sbw.BaseStream.Position = 0x18ABA9D;
                S8Sbw.Write(0x6D);
                S8Sbw.BaseStream.Position = 0x18ABA9E;
                S8Sbw.Write(0x6F);
                S8Sbw.BaseStream.Position = 0x18ABA9F;
                S8Sbw.Write(0x64);
                S8Sbw.BaseStream.Position = 0x18ABAA0;
                S8Sbw.Write(0x73);
                S8Sbw.BaseStream.Position = 0x18ABAA1;
                S8Sbw.Write(0x2E);
                S8Sbw.BaseStream.Position = 0x18ABAA2;
                S8Sbw.Write(0x74);
                S8Sbw.BaseStream.Position = 0x18ABAA3;
                S8Sbw.Write(0x78);
                S8Sbw.BaseStream.Position = 0x18ABAA4;
                S8Sbw.Write(0x74);
                S8Sbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }


            else if (textBox1.Text == "US skyrim 1.07")
            {
                MessageBox.Show("i couldn't find 1.07's update sorry :(");
            }
            else if (textBox1.Text == "US skyrim 1.06")
            {
                MessageBox.Show("this update is not supported sorry :(");
            }
            else if (textBox1.Text == "US skyrim 1.05")
            {
                MessageBox.Show("this update is not supported sorry :(");
            }
            else if (textBox1.Text == "US skyrim 1.04")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "US skyrim 1.03")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "US skyrim 1.02")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "US skyrim 1.01")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "US skyrim 1.00")
            {
                MessageBox.Show("this can not be patched and does not need patching");
            }
            else if (textBox1.Text == "EU skyrim 1.07")
            {
                MessageBox.Show("i couldn't find 1.07's update sorry :(");
            }
            else if (textBox1.Text == "EU skyrim 1.06")
            {
                MessageBox.Show("this update is not supported sorry :(");
            }
            else if (textBox1.Text == "EU skyrim 1.05")
            {
                MessageBox.Show("this update is not supported sorry :(");
            }
            else if (textBox1.Text == "EU skyrim 1.04")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "EU skyrim 1.03")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "EU skyrim 1.02")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "EU skyrim 1.01")
            {
                MessageBox.Show("where did you get this update?");
            }
            else if (textBox1.Text == "EU skyrim 1.00")
            {
                MessageBox.Show("this can not be patched and does not need patching");
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (textBox1.Text == "Extracted FPKG US fallout 4 1.22")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E57514;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E57515;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E57516;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E57517;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E57518;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E57519;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E5751A;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E5751B;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E5751C;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "Extracted FPKG US fallout 4 1.21")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E57514;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E57515;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E57516;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E57517;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E57518;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E57519;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E5751A;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E5751B;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E5751C;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "US fallout 4 1.22")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E49DE4;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E49DE5;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E49DE6;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E49DE7;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E49DE8;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E49DE9;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E49DEA;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E49DEB;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E49DEC;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "US fallout 4 1.21")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E49DE4;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E49DE5;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E49DE6;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E49DE7;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E49DE8;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E49DE9;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E49DEA;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E49DEB;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E49DEC;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "US fallout 4 1.20")
            {
                MessageBox.Show("i couldn't find 1.20's update sorry :(");
            }

            if (textBox1.Text == "US fallout 4 1.19")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E49784;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E49785;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E49786;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E49787;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E49788;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E49789;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E4978A;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E4978B;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E4978C;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            if (textBox1.Text == "Extracted FPKG US fallout 4 1.19")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E56EB4;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E56EB5;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E56EB6;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E56EB7;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E56EB8;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E56EB9;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E56EBA;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E56EBB;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E56EBC;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            else if (textBox1.Text == "Extracted FPKG EU fallout 4 goty 1.20")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E575B4;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E575B5;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E575B6;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E575B7;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E575B8;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E575B9;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E575BA;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E575BB;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E575BC;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }
            if (textBox1.Text == "EU fallout 4 goty 1.20")
            {
                BinaryWriter Fbw = new BinaryWriter(File.OpenWrite(OFD.FileName));
                Fbw.BaseStream.Position = 0x1E57454;
                Fbw.Write(0x6D);
                Fbw.BaseStream.Position = 0x1E57455;
                Fbw.Write(0x6F);
                Fbw.BaseStream.Position = 0x1E57456;
                Fbw.Write(0x64);
                Fbw.BaseStream.Position = 0x1E57457;
                Fbw.Write(0x73);
                Fbw.BaseStream.Position = 0x1E57458;
                Fbw.Write(0x2E);
                Fbw.BaseStream.Position = 0x1E57459;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E5745A;
                Fbw.Write(0x78);
                Fbw.BaseStream.Position = 0x1E5745B;
                Fbw.Write(0x74);
                Fbw.BaseStream.Position = 0x1E5745C;
                Fbw.Write(0x00);
                Fbw.Close();
                MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt");
            }

            else if (textBox1.Text == "")
            {
                MessageBox.Show("You Don't got anything typed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["list"] == null)
            {
                list form = new list();
                form.Show();
            }
        }
    }
}