using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPasswordChanger.Model
{
    class RemoteUser
    {
        //Private Members
        private int _id;
        private String _systemName;
        private String _username;
        private String _password;
        private DateTime _modifiedDate;
        private String _status;

        //Constructors
        public RemoteUser()
        {
        }
        public RemoteUser(String systemName)
        {
            this._systemName = systemName;
        }
        public RemoteUser(String systemName, String username)
        {
            this._systemName = systemName;
            this._username = username;
        }
        public RemoteUser(String systemName, String username, String password)
        {
            this._systemName = systemName;
            this._username = username;
            this._password = password;
        }
        public RemoteUser(int id, String systemName, String username, String password, DateTime modifiedDate)
        {
            this._id = id;
            this._systemName = systemName;
            this._username = username;
            this._password = password;
            this._modifiedDate = modifiedDate;
        }

        //Getters and Setters
        public int getID()
        {
            return this._id;
        }
        public void setID(int id)
        {
            this._id = id;
        }

        public String getSystemName()
        {
            return this._systemName;
        }
        public void setSystemName(String systemName)
        {
            this._systemName = systemName;
        }

        public String getUsername()
        {
            return this._username;
        }
        public void setUsername(String username)
        {
            this._username = username;
        }

        public String getPassword()
        {
            return this._password;
        }
        public void setPassword(String password)
        {
            this._password = password;
        }

        public DateTime getModifiedDate()
        {
            return this._modifiedDate;
        }
        public String getModifiedDateStr()
        {
            return this._modifiedDate.ToString();
        }
        public void setModifiedDate(DateTime modifiedDate)
        {
            this._modifiedDate = modifiedDate;
        }

        public String getStatus()
        {
            return this._status;
        }
        public void setStatus(String status)
        {
            this._status = status;
        }
    }
}
