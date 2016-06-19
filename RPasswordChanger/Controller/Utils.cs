using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace RPasswordChanger.Model
{
    class Utils
    {
        public static string RandomPassword(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789$!@#%^&*()";
            StringBuilder sb = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];
                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    sb.Append(chars[(int)(num % (uint)chars.Length)]);
                }
            }
            return sb.ToString();
        }
        public static bool isDirWritable(String name,bool isDir=true)
        {
            try
            {
                string directoryName = null;
                if (isDir)
                {
                    directoryName = name;
                }
                else
                {
                    directoryName = Path.GetDirectoryName(name);
                }

                if (!String.IsNullOrEmpty(directoryName))
                {
                    PermissionSet permissionSet = new PermissionSet(PermissionState.None);

                    FileIOPermission writePermission = new FileIOPermission(FileIOPermissionAccess.Write, directoryName);

                    permissionSet.AddPermission(writePermission);

                    if (permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public static void displayError(String msg)
        {
            MessageBox.Show("ERROR! " + msg);
        }
        public static void displayMessage(String msg)
        {
            MessageBox.Show(msg);
        }

        public static List<String> getRemoteAdmins(String target)
        {
            //Get accounts with admin privilege from remote machine
            List<String> adminAccounts = new List<string>();

            try
            {
                using (System.DirectoryServices.DirectoryEntry machine = new System.DirectoryServices.DirectoryEntry("WinNT://" + target))
                {
                    using (new UserImpersonator(AppSession.UserName, AppSession.Domain, AppSession.Password)) //Impersonate as Ad user
                    {
                        using (System.DirectoryServices.DirectoryEntry group = machine.Children.Find("Administrators", "Group")) //Get Administrators Group
                        {
                            object members = group.Invoke("Members", null); //Get Members of Administratos group
                            foreach (object member in (System.Collections.IEnumerable)members)
                            {
                                string accountName = new System.DirectoryServices.DirectoryEntry(member).Name;
                                if (accountName != "Domain Admins")
                                {
                                    adminAccounts.Add(accountName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // TODO Log the Exception
            }
            return adminAccounts;
        }
    }
}
