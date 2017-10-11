using System;


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
            TB_IconLocation.Text = UnknownLibrary.Unknown.GetFilePath("Ico Files(*.ico) | All Files(*.*)");

        }
    }
}
}
