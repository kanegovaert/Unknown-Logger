using System;
using System.Windows.Forms;

namespace UnknownLibrary.StubSource
{
    public partial class SourceCodeForm : Form
    {
        public static string StubSourceCodeString;
        public SourceCodeForm()
        {
            InitializeComponent();
        }

        private void SourceCodeForm_Load(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            StubSourceCodeString = TB_Programcs.Text;
        }
    }
}
