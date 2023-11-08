using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ParentalControlSystem
{
    public class ParentalController
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr
        phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name,
        ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        public static void DoExitWin(int flg)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(flg, 0);
        }

        private static int hh = 0;
        private static int mm = 0;
        private static int ss = 0;
        private static string clock = "";
        public static void StartTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;            
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            ss += 1;
            if (ss == 60)
            {
                mm += 1;
                ss = 0;
            }
            if (mm == 60) 
            {
                hh += 1;
                mm = 0;
            }
            clock = hh.ToString("") + ":" + mm.ToString() + ":" + ss.ToString();            
        }

        public static List<string> GetApplications(string path)
        {
            List<string> apps = new List<string>();
            
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode n in root.ChildNodes)
            {
                apps.Add(n.InnerText);
            }
            return apps;
        }
        public static List<string> GetKeywords(string path)
        {
            List<string> keywords = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode n in root.ChildNodes)
            {
                keywords.Append(n.InnerText);
            }
            return keywords;
        }

        public static void BlockApps(string appName)
        {            
            foreach (Process Proc in Process.GetProcesses())
            {
                if (Proc.ProcessName.Contains(appName))
                {
                    Proc.Kill();
                }
            }                        
        }
        public static void RemoveFirewallRules(string RuleName = "InternetPolicy")
        {
            try
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                var currentProfiles = fwPolicy2.CurrentProfileTypes;
                foreach (INetFwRule rule in fwPolicy2.Rules)
                {                 
                    if (rule.Name.IndexOf(RuleName) != -1)
                    {
                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        firewallPolicy.Rules.Remove(rule.Name);
                        Console.WriteLine(rule.Name + " has been deleted from Firewall Policy");
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show("Error delete rule from firewall: " + r.Message);
            }
        }
        public static void AddFirewallRules(string ruleName = "InternetPolicy")
        {
            try
            {
                INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

                firewallRule.Description = "Parental Controll System";
                firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                firewallRule.Enabled = true;
                firewallRule.InterfaceTypes = "All";
                firewallRule.Name = ruleName;

                INetFwPolicy2 firewallPol = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                firewallPol.Rules.Add(firewallRule);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
