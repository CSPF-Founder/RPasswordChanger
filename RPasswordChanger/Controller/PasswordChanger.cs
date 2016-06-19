using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using RPasswordChanger.Model;
using System.IO;
using System.Net;
using System.Management;
using System.Security.Principal;
using System.Globalization;

namespace RPasswordChanger.Controller
{
    class PasswordChanger
    {
        private String _error;
        
        string adUser = AppSession.Domain + "\\" + AppSession.UserName;
        string adPassword = AppSession.Password;
        string target = null; 
        public PasswordChanger()
        {
            this._error = "";
        }
        public PasswordChanger(string computer)
        {
            this.target = computer;
        }

        public bool change(string username,string newpassword)
        {//Method to change the password of the remote machine
            DirectoryEntry dirEntry = null;
            string computerName = @"WinNT://" + this.target + "/" + username + ",user";
            try
            { 
                dirEntry = new DirectoryEntry(computerName, this.adUser, this.adPassword);
                dirEntry.Invoke("SetPassword", new Object[] { newpassword});
                dirEntry.CommitChanges();

                try
                {
                    this.displayPopupInRemote();
                }
                catch (Exception e)
                {
                    this.setError("Unable to Display Message in Remote Machine - " +e.Message);
                }
                return true;
            }
            catch (Exception Ex)
            {
                this.setError(Ex.Message);
            }
            finally
            {
                if (dirEntry != null)
                    dirEntry.Dispose();
            }
            return false;

        }

        private DateTime getLocalTime()
        {
            //Get local time of the target machine
            String localTime = null;
            var connection1 = new ConnectionOptions();
            connection1.Username = this.adUser;
            connection1.Password = this.adPassword;

            var wmiScope1 = new ManagementScope(String.Format("\\\\{0}\\root\\cimv2", this.target), connection1);

            SelectQuery selectQuery = new SelectQuery("select * from win32_localtime");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiScope1, selectQuery);
            int i = 0;
            foreach (ManagementObject mo in searcher.Get())
            {
                localTime = "" + (mo["Hour"]) + ":"+ mo["Minute"] +":00";
            }
            DateTime dateTime = DateTime.Parse(localTime,
                                        CultureInfo.InvariantCulture);
            dateTime = dateTime.AddMinutes(2);
           
            return dateTime;
        }

        private void displayPopupInRemote()
        {
            string msgFile = Path.Combine(AppSession.AppDataFolder, "msg.vbs");
            if (!File.Exists(msgFile))
            {
                using (StreamWriter file = new StreamWriter(msgFile))
                {
                    file.WriteLine("MsgBox \"The local administrator's password has been changed\"");
                }
            }

            String destFile = "\\\\" + this.target + "\\Admin$\\Temp\\" + "msg.vbs";
   
            //Here we set the the credential information to the Webclient
            using (new UserImpersonator(AppSession.UserName, AppSession.Domain,AppSession.Password))
            {
                File.Copy(msgFile, destFile, true);
            }
            
            String remoteMsgFileLocation = "C:\\Windows\\Temp\\msg.vbs";
            DateTime dateTime = this.getLocalTime();
            remoteProcessScheduler(dateTime, remoteMsgFileLocation);

            dateTime = dateTime.AddMinutes(2);
            remoteProcessScheduler(dateTime, "cmd /c /hid \"\"del "+remoteMsgFileLocation+"\"\"");

        }
        public void remoteProcessScheduler(DateTime dateTime,String cmd)
        {
            string time = dateTime.ToString("HH:mm");
            string at_cmd = "at " + time + " /interactive  "+cmd;
            var processToRun = new[] { cmd };
            var connection = new ConnectionOptions();
            connection.Username = this.adUser;
            connection.Password = this.adPassword;
            var wmiScope = new ManagementScope(String.Format("\\\\{0}\\root\\cimv2", this.target), connection);
            var wmiProcess = new ManagementClass(wmiScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());
            wmiProcess.InvokeMethod("Create", processToRun);
        }
        public String getError()
        {
            return this._error;
        }
        public void setError(String message)
        {
            this._error = message;
        }

    }
}
