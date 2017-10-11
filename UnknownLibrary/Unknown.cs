using System.Windows.Forms;

namespace UnknownLibrary
{
    public static class Unknown
    {
        public static void OpenLink(string URL)
        {
            System.Diagnostics.Process.Start(URL);
        }
        public static void CreateLog(System.Windows.Forms.ListBox listBox, string Item, bool Success)
        {
            if (Success)
            {
                listBox.Items.Add("[+] " + Item);
            } else
            {
                listBox.Items.Add("[-] " + Item);
            }
        }
        public static string GetFilePath(string filter)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = filter;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }
            return null;
        }
    }
}
