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

        public static readonly byte[] Fallout4Find = new byte[12]
        {
            70, 97, 108, 108, 111, 117, 116, 52, 46, 99, 99, 99
        };

        public static readonly byte[] Fallout4Replaces = new byte[12]
        {
            109, 111, 100, 115, 46, 116, 120, 116, 0, 0, 0, 0
        };

        public static readonly byte[] SkyrimFind = new byte[10]
        {
            83, 107, 121, 114, 105, 109, 46, 99, 99, 99
        };

        public static readonly byte[] SkyrimReplaces = new byte[10]
        {
            109, 111, 100, 115, 46, 116, 120, 116, 0, 0
        };

        private static bool Fallout4DetectPatch(byte[] sequence, int position)
        {
            if (position + Fallout4Find.Length > sequence.Length)
            {
                return false;
            }
            for (int i = 0; i < Fallout4Find.Length; i++)
            {
                if (Fallout4Find[i] != sequence[position + i])
                {
                    return false;
                }
            }
            return true;
        }

        private static void Fallout4PatchFile(string originalFile, string patchedFile)
        {
            string directoryName = Path.GetDirectoryName(patchedFile);
            if (directoryName != null)
            {
                Directory.CreateDirectory(directoryName);
                byte[] array = File.ReadAllBytes(originalFile);
                for (int i = 0; i < array.Length; i++)
                {
                    if (Fallout4DetectPatch(array, i))
                    {
                        for (int j = 0; j < Fallout4Find.Length; j++)
                        {
                            array[i + j] = Fallout4Replaces[j];
                        }
                    }
                }
                File.WriteAllBytes(patchedFile, array);
            }
        }

        private static bool SkyrimDetectPatch(byte[] sequence, int position)
        {
            if (position + SkyrimFind.Length > sequence.Length)
            {
                return false;
            }
            for (int i = 0; i < SkyrimFind.Length; i++)
            {
                if (SkyrimFind[i] != sequence[position + i])
                {
                    return false;
                }
            }
            return true;
        }

        private static void SkyrimPatchFile(string originalFile, string patchedFile)
        {
            string directoryName = Path.GetDirectoryName(patchedFile);
            if (directoryName != null)
            {
                Directory.CreateDirectory(directoryName);
                byte[] array = File.ReadAllBytes(originalFile);
                for (int i = 0; i < array.Length; i++)
                {
                    if (SkyrimDetectPatch(array, i))
                    {
                        for (int j = 0; j < SkyrimFind.Length; j++)
                        {
                            array[i + j] = SkyrimReplaces[j];
                        }
                    }
                }
                File.WriteAllBytes(patchedFile, array);
            }
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Credits"] == null)
            {
                Credits form = new Credits();
                form.Show();
            }
        }

        OpenFileDialog OFD = new OpenFileDialog();

        private void OPEN_ELF_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
        }

        private void PATCH_ELF_Click(object sender, EventArgs e)
        {
            string[] array = (OFD.FileNames);
            foreach (string text in array)
            {
                if (comboBox1.SelectedIndex == 0 && File.Exists(text))
                {
                    SkyrimPatchFile(text, text);
                }
                if (comboBox1.SelectedIndex == 1 && File.Exists(text))
                {
                    Fallout4PatchFile(text, text);
                }
            }
            MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string text in array)
            {
                if (comboBox1.SelectedIndex == 0 && File.Exists(text))
                {
                    SkyrimPatchFile(text, text);
                }
                if (comboBox1.SelectedIndex == 1 && File.Exists(text))
                {
                    Fallout4PatchFile(text, text);
                }
            }
            MessageBox.Show("Your eboot.bin has been patched and will now look for mods.txt", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}