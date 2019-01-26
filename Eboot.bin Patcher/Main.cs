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

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            //Ihis Is Offsets For Skyrim
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
            }
        }

        OpenFileDialog OFD = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SSE.Checked)
            {
                /// What happends when "Skyrim Special Edition" Is ticked
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
             if (F4.Checked)
            {
                /// What happends when "Fallout 4" Is ticked
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
                /// What happends when "Nothing" Is ticked
                if (NO.Checked)
                {
                    MessageBox.Show("You Don't got anything Selected");
                }

                }
            }
        }
