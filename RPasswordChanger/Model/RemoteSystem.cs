using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPasswordChanger.Model
{
    class RemoteSystem
    {
          //Private Members
        private int _id;
        private String _systemName;
        private String _domain;
        private Boolean _ignoreFlag;

        //Constructors
        public RemoteSystem()
        {
        }
        public RemoteSystem(String systemName)
        {
            this._systemName = systemName;
        }
        public RemoteSystem(String systemName, String domain)
        {
            this._systemName = systemName;
            this._domain = domain;
        }
        
        public RemoteSystem(int id, String systemName, String domain)
        {
            this._id = id;
            this._systemName = systemName;
            this._domain = domain;
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

        public String getDomain()
        {
            return this._domain;
        }
        public void setDomain(String domain)
        {
            this._domain = domain;
        }
        public void setIgnoreFlag(Boolean ignoreFlag)
        {
            this._ignoreFlag = ignoreFlag;
        }
        public Boolean isIgnored()
        {

            return this._ignoreFlag;
        }
    }
}
