using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula_01_10_2018
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection;
        MySqlConnectionStringBuilder mysqlString;
        private const string DATABASE = "db_test";
        private const string USER = "xablau";
        private const string PASSWORD = "123";
        private const int PORT = 3306;


        public Form1()
        {
            InitializeComponent();
            mysqlString = new MySqlConnectionStringBuilder();
            mysqlString.Database = DATABASE;
            mysqlString.UserID = USER;
            mysqlString.Password = PASSWORD;
            mysqlString.Port = PORT;
            mysqlString.SslMode = MySqlSslMode.None;


            mySqlConnection = new MySqlConnection(mysqlString.ConnectionString);
        }

 
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Banco Conectado!");
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string query = "INSERT into users (nome, senha)" +
                "values ('" + textBoxNome.Text +
                "','" + textBoxSenha.Text + "')";
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
