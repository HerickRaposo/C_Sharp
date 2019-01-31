﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace VA3_Padaria__HerickRaposo.Connection
{
    class ConexaoBD
    {
        public static ConexaoBD SingletonConnection;

        private MySqlConnection con;
        private MySqlConnectionStringBuilder MysqlString;

        private const string USER = "herickraposo97";
        private const string PASSWORD = "herickraposo97";
        private const string DATABASE = "va3_padariabd";
        private const int PORT = 3306;

        private ConexaoBD()
        {
            MysqlString = new MySqlConnectionStringBuilder();
            MysqlString.UserID = USER;
            MysqlString.Password = PASSWORD;
            MysqlString.Database = DATABASE;
            MysqlString.Port = PORT;
            MysqlString.SslMode = MySqlSslMode.None;

            con = new MySqlConnection(MysqlString.ConnectionString);
        }

        public static ConexaoBD Get_Instance
        {
            get
            {
                if (SingletonConnection == null)
                {
                    SingletonConnection = new ConexaoBD();
                }
                return SingletonConnection;
            }
        }

        public void OpenConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (MySqlException)
            {

                throw;

            }
        }
        public void CloseConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (MySqlException)
            {

                throw;

            }
        }

        public MySqlConnection GetConnection()
        {
            return con;
        }
    }
}
