using System.Windows.Forms;
using System.Threading;

namespace Unknown_Logger.Forms
{
    public partial class TermsofServiceForm : MetroFramework.Forms.MetroForm
    {
        private static bool Exit = true;

        public TermsofServiceForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void TermsofService_Load(object sender, System.EventArgs e)
        {
            BTN_Accept.Enabled = false;
            CB_Agreed.Visible = false;
            Thread thread = new Thread(Wait10Seconds);
            thread.Start();
        }

        private void TermsofService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Exit)
                System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void BTN_Decline_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Wait10Seconds()
        {
            for (int i = 10; i > -1; i--)
            {
                System.Threading.Thread.Sleep(1000);
                LBL_WaitTime.Text = "WAIT " + i + " SECONDS";
            }
            LBL_WaitTime.Visible = false;
            BTN_Accept.Enabled = true;
            CB_Agreed.Visible = true;
        }

        private void BTN_Accept_Click(object sender, System.EventArgs e)
        {
            if (CB_Agreed.Checked)
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You did not agree with the terms of service.", "Unknown Logger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
