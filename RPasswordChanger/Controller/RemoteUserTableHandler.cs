using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using RPasswordChanger.Model;
using System.Collections;

namespace RPasswordChanger.Controller
{
    class RemoteUserTableHandler
    {
        //Data Source
        private String dataSource = "DataSource=\"" + AppSession.DBFile + "\"";

        //Table Name
        private const String TABLE_NAME = "RemoteUsers";

        private SqlCeConnection conn = null;

        public RemoteUserTableHandler()
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

        //Get All Users from the local database table
        public List<RemoteUser> getAllRemoteUsers()
        {
            this.connect();
            List<RemoteUser> usersList = new List<RemoteUser>();
            String query = "Select * from " + TABLE_NAME;
            SqlCeCommand cmd = new SqlCeCommand(query,this.conn);
            SqlCeDataReader sqlReader = cmd.ExecuteReader();

            while(sqlReader.Read())
            {
                RemoteUser rUser = new RemoteUser();

                if (!DBNull.Value.Equals(sqlReader[0]))
                    rUser.setID(sqlReader.GetInt32(0));
                if (!DBNull.Value.Equals(sqlReader[1]))
                    rUser.setSystemName(sqlReader.GetString(1));
                if (!DBNull.Value.Equals(sqlReader[2]))
                    rUser.setUsername(sqlReader.GetString(2));
                if (!DBNull.Value.Equals(sqlReader[3]))
                    rUser.setPassword(sqlReader.GetString(3));
                if(! DBNull.Value.Equals(sqlReader[4]))
                    rUser.setModifiedDate(sqlReader.GetDateTime(4));
                if (!DBNull.Value.Equals(sqlReader[5]))
                    rUser.setStatus(sqlReader.GetString(5));

                usersList.Add(rUser);
            }
            this.disconnect();
            return usersList;
        }

        public void addUser(RemoteUser rUser)
        {//add new user
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            DateTime currentTime = DateTime.Now;
            cmd.CommandText = "insert into " + TABLE_NAME + "(system,username,password,modified_date,status) values('" + rUser.getSystemName() + "','" + rUser.getUsername() + "','" + rUser.getPassword() + "','" + currentTime.ToString() + "','" + rUser.getStatus() + "')";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public void updatePassword(RemoteUser rUser)
        {//change user password
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            DateTime currentTime = DateTime.Now;
            cmd.CommandText = "update " + TABLE_NAME + " set password='" + rUser.getPassword() + "',status='',modified_date='" + currentTime.ToString() + "' where username='" + rUser.getUsername() + "' and system='" + rUser.getSystemName() + "'";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public void deleteUser(RemoteUser rUser)
        {//Remove user from the local table
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = "delete from " + TABLE_NAME + "  where username='" + rUser.getUsername() + "' and system='" + rUser.getSystemName() + "'";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public void updateStatus(RemoteUser rUser)
        {//Set status 
            this.connect();
            SqlCeCommand cmd = this.conn.CreateCommand();
            cmd.CommandText = "update " + TABLE_NAME + " set status='" + rUser.getStatus() + "'  where username='" + rUser.getUsername() + "' and system='" + rUser.getSystemName() + "'";
            cmd.ExecuteNonQuery();
            this.disconnect();
        }

        public bool exists(RemoteUser rUser)
        {
            //Check whether the entry with the specified System & Username already exists
            int count = 0;
            this.connect();
            String query = "Select count(*) from " + TABLE_NAME + " where system='" + rUser.getSystemName() + "' and username='" + rUser.getUsername() + "'" ;
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

        /*
       public RemoteUser getUser(int id)
       {//Get All Users from the local database table
           this.connect();
           RemoteUser rUser = new RemoteUser();
           String query = "Select * from " + TABLE_NAME + " where id="+id;
           SqlCeCommand cmd = new SqlCeCommand(query, this.conn);
           SqlCeDataReader sqlReader = cmd.ExecuteReader();

           if(sqlReader.Read())
           {
               if (!DBNull.Value.Equals(sqlReader[0]))
                   rUser.setID(sqlReader.GetInt32(0));
               if (!DBNull.Value.Equals(sqlReader[1]))
                   rUser.setSystemName(sqlReader.GetString(1));
               if (!DBNull.Value.Equals(sqlReader[2]))
                   rUser.setUsername(sqlReader.GetString(2));
               if (!DBNull.Value.Equals(sqlReader[3]))
                   rUser.setPassword(sqlReader.GetString(3));
               if (!DBNull.Value.Equals(sqlReader[4]))
                   rUser.setModifiedDate(sqlReader.GetDateTime(4));
           }
           this.disconnect();
           return rUser;
       }
       */

    }
}
