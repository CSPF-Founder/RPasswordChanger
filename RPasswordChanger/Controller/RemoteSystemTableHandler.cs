using RPasswordChanger.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace RPasswordChanger.Controller
{
    class RemoteSystemTableHandler
    {
        //Data Source
        private String dataSource = "DataSource=\"" + AppSession.DBFile + "\"";

        //Table Name
        private const String TABLE_NAME = "RemoteSystems";

        private SqlCeConnection conn = null;

        public RemoteSystemTableHandler()
        {
            
        }

        //Database Connection Establish
        public void connect()
        {
            this.conn = new SqlCeConnection(dataSource);
            this.conn.Open();
            if (this.conn == null)
            {
                throw new Exception("Database Connection Failed");
            }
        }
        //Database Connection Close
        public void disconnect()
        {
            this.conn.Close();
        }

        //Get All Systems from the local database table
        public List<RemoteSystem> getAllSystems()
        {
            this.connect();
            List<RemoteSystem> systemsList = new List<RemoteSystem>();
            String query = "Select * from " + TABLE_NAME;
            SqlCeCommand cmd = new SqlCeCommand(query,this.conn);
            SqlCeDataReader sqlReader = cmd.ExecuteReader();

            while(sqlReader.Read())
            {
                RemoteSystem rSystem = new RemoteSystem();

                if (!DBNull.Value.Equals(sqlReader[0]))
                    rSystem.setID(sqlReader.GetInt32(0));
                if (!DBNull.Value.Equals(sqlReader[1]))
                    rSystem.setSystemName(sqlReader.GetString(1));
                if (!DBNull.Value.Equals(sqlReader[2]))
                    rSystem.setDomain(sqlReader.GetString(2));
                if (!DBNull.Value.Equals(sqlReader[3]))
                    rSystem.setIgnoreFlag(sqlReader.GetBoolean(3));

                systemsList.Add(rSystem);
            }
            this.disconnect();
            return systemsList;
        }
        public int getRowCount()
        {//Get total number of rows in Remote Systems table
            int count = 0;
            this.connect();
            String query = "Select count(*) from " + TABLE_NAME;
            SqlCeCommand cmd = new SqlCeCommand(query, this.conn);
            count =(int) cmd.ExecuteScalar();
            this.disconnect();
            return count;
        }
        public void addSystem(RemoteSystem rSystem)
        {
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = "insert into " + TABLE_NAME + "(system,domain) values('" + rSystem.getSystemName() + "','" + rSystem.getDomain() + "')";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public void deleteSystem(RemoteSystem rSystem)
        {
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = "delete from " + TABLE_NAME + " where system='" + rSystem.getSystemName()+"'";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public void setIgnoreFlag(RemoteSystem rSystem,int ignoreFlag)
        {
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = "update " + TABLE_NAME + " set ignore="+ignoreFlag+" where system='" + rSystem.getSystemName() + "'";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public bool exists(RemoteSystem rSystem)
        {
            //Check whether the entry with the specified System  already exists
            int count = 0;
            this.connect();
            String query = "Select count(*) from " + TABLE_NAME + " where system='" + rSystem.getSystemName() + "'";
            SqlCeCommand cmd = new SqlCeCommand(query, this.conn);
            count = (int)cmd.ExecuteScalar();
            this.disconnect();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
