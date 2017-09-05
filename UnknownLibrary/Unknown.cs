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
    }
}
