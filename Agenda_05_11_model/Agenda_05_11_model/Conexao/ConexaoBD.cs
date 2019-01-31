using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Agenda_05_11_model.Conexao
{
    public class ConexaoBD
    {
        public static ConexaoBD conexao;
        private MySqlCommand cmd;
        private MySqlConnection mySql;
        private MySqlDataReader reader;
        private const string DATABASE = "sistema_agenda";
        private const string SERVER = "localhost";
        private const int PORT = 3306;
        private const string USER = "admin";
        private const string PASSWORD = "admin";
        private ConexaoBD()
        {
            mySql = new MySqlConnection(IniciarConexao());
        }
        private string IniciarConexao()
        {
            MySqlConnectionStringBuilder sqlString = new MySqlConnectionStringBuilder();
            sqlString.Database = DATABASE;
            sqlString.UserID = USER;
            sqlString.Password = PASSWORD;
            sqlString.SslMode = MySqlSslMode.None;
            sqlString.Port = PORT;
            return sqlString.ConnectionString;
        }
       public static ConexaoBD GetInsta
       {
            get
            {
                if (conexao == null)
                {
                    conexao = new ConexaoBD();
                }
                return conexao;
            }
        }
        public void OpenConnection()
        {
            try
            {
                if (mySql.State == ConnectionState.Closed)
                {
                    mySql.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (mySql.State == ConnectionState.Open)
                {
                    mySql.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public MySqlConnection GetConnection()
        {
            return mySql;
        }
    }
}
