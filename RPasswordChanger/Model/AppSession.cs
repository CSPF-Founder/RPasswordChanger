using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPasswordChanger.Model
{
    static class AppSession
    {
        private static string _domain;
        private static string _userName;
        private static string _password;
        private static string _serverIP;
        private static string _dbFile;
        private static string _appDataFolder;
        public static string Domain
        {
            get { return _domain; }
            set { _domain = value; }
        }
        public static string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public static string ServerIP
        {
            get { return _serverIP; }
            set { _serverIP = value; }
        }
        public static string DBFile
        {
            get { return _dbFile; }
            set { _dbFile = value; }
        }
        public static string AppDataFolder
        {
            get { return _appDataFolder; }
            set { _appDataFolder = value; }
        }
    }
}
