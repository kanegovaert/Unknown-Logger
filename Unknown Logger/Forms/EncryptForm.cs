using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unknown_Logger.Forms
{
    public partial class EncryptForm : MetroFramework.Forms.MetroForm
    {
        public EncryptForm()
        {
            InitializeComponent();
        }

        private void BTN_GetFileLocation_Click(object sender, EventArgs e)
        {
            TB_FileLocation.Text = UnknownLibrary.Unknown.GetFilePath("All Files(*.*)|Exe File (*.exe)");
        }
    }
}
