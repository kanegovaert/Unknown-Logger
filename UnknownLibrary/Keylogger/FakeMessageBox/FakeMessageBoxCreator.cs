using System.Windows.Forms;

namespace UnknownLibrary.FakeMessageBox
{
    public static class FakeMessageBoxCreator
    {
        public  static void createMessageBox(string MessageBoxOption, string FakeMessageBoxText, string FakeMessageBoxName, string MessageBoxIcon)
        {
            switch (MessageBoxOption)
            {
                case "AbortRetryIgnore":
                    checkMessageBoxIcon(MessageBoxButtons.AbortRetryIgnore, FakeMessageBoxText, FakeMessageBoxName, MessageBoxIcon);
                    break;
                case "OK":
                    checkMessageBoxIcon(MessageBoxButtons.OK, FakeMessageBoxText, FakeMessageBoxName, MessageBoxIcon);
                    break;
                case "OKCancel":
                    checkMessageBoxIcon(MessageBoxButtons.OKCancel, FakeMessageBoxText, FakeMessageBoxName, MessageBoxIcon);
                    break;
                case "RetryCancel":
                    checkMessageBoxIcon(MessageBoxButtons.RetryCancel, FakeMessageBoxText, FakeMessageBoxName, MessageBoxIcon);
                    break;
                case "YesNo":
                    checkMessageBoxIcon(MessageBoxButtons.YesNo, FakeMessageBoxText, FakeMessageBoxName, MessageBoxIcon);
                    break;
                case "YesNoCancel":
                    checkMessageBoxIcon(MessageBoxButtons.YesNoCancel, FakeMessageBoxText, FakeMessageBoxName, MessageBoxIcon);
                    break;

            }
        }
        private static void checkMessageBoxIcon(MessageBoxButtons messageBoxButton, string FakeMessageBoxText, string FakeMessageBoxName, string MessageBoxIcon)
        {
            switch (MessageBoxIcon)
            {
                case "Asterik":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Asterisk);
                    break;
                case "Error":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
                case "Exclamation":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    break;
                case "Hand":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Hand);
                    break;
                case "Information":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Information);
                    break;
                case "None":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.None);
                    break;
                case "Question":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Question);
                    break;
                case "Stop":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Stop);
                    break;
                case "Warning":
                    MessageBox.Show(FakeMessageBoxText, FakeMessageBoxName, messageBoxButton, System.Windows.Forms.MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
