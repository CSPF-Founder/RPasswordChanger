using RPasswordChanger.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPasswordChanger.Controller
{
    class AppDBInit
    {
        //Data Source
        private String dataSource = "DataSource=\"" + AppSession.DBFile + "\"";
        private SqlCeConnection conn = null;

        public  AppDBInit()
        {           
            if (!File.Exists(AppSession.DBFile))
            {
                this.createDatabase();
                this.createTables();
            }
        }
        public void createDatabase()
        {
            SqlCeEngine en = new SqlCeEngine(this.dataSource);
            en.CreateDatabase();
        }
        //Database Connection Establish
        public void connect()
        {
            this.conn = new SqlCeConnection(this.dataSource);
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

        public void createTables()
        {
            try
            {
                this.connect();
                SqlCeCommand cmd = this.conn.CreateCommand();
                cmd.CommandText = "create table RemoteSystems(id int NOT NULL PRIMARY KEY IDENTITY (/*seed*/1, /*increment*/1),system nvarchar(100),domain nvarchar(100),ignore bit DEFAULT 0);";
                cmd.ExecuteNonQuery();
                this.disconnect();

                this.connect();
                SqlCeCommand cmd1 = this.conn.CreateCommand();
                cmd1.CommandText = "create table RemoteUsers(id int NOT NULL PRIMARY KEY IDENTITY (/*seed*/1, /*increment*/1),system nvarchar(100),username nvarchar(100),password nvarchar(100),modified_date datetime,status nvarchar(200));";
                cmd1.ExecuteNonQuery();
                this.disconnect();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nEXCEPTION"+e.Message);
            }

        }
    }
}
