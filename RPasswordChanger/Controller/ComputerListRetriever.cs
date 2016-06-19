using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using RPasswordChanger.Model;


namespace RPasswordChanger.Controller
{
    class ComputersListRetriever
    {
        private String _error;
        public ComputersListRetriever()
        {
            this.setError("");
        }
        public void setError(String msg)
        {
            this._error = msg;
        }
        public String getError()
        {
            return this._error;
        }
        public void retrieve()
        {
            //Retrieve computers from the AD server and store in the application database
            DirectoryEntry dirEntry = null;
            try
            {
                dirEntry = new DirectoryEntry("LDAP://" + AppSession.ServerIP, AppSession.UserName, AppSession.Password);
                DirectorySearcher finder = new DirectorySearcher(dirEntry);
                finder.Filter = "(objectClass=computer)";
                SearchResultCollection results = finder.FindAll();
                RemoteSystemTableHandler rSystemHandler = new RemoteSystemTableHandler();
                foreach (SearchResult sr in results)
                {
                    DirectoryEntry computerEntry = sr.GetDirectoryEntry();
                    String computerName = computerEntry.Name.Replace("CN=", "");
                    if (computerName != "")
                    {
                        RemoteSystem rSystem = new RemoteSystem();
                        rSystem.setSystemName(computerName);

                        if (!rSystemHandler.exists(rSystem))
                        {
                            rSystemHandler.addSystem(rSystem);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                this.setError("Unable to Retrieve ComputerList " + e.Message);
            }
            finally
            {
                if (dirEntry != null)
                {
                    dirEntry.Dispose();
                }
            }
        }
    }
}
