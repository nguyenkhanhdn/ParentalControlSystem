using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlSystem
{
    public class ParentalController
    {
        public static void BlockApps(bool block, string appName)
        {
            if (block)
            {
                foreach (Process Proc in Process.GetProcesses())
                {
                    if (Proc.ProcessName.Contains(appName))
                    {
                        Proc.Kill();
                    }
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
