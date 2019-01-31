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

namespace aula27_09_2018
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection;
        MySqlConnectionStringBuilder mysqlString;
        private const string DATABASE = "db_test";
        private const string USER = "xablau";
        private const string PASSWORD = "123";
        private const int PORT= 3306;





        public Form1()
        {
            InitializeComponent();
            mysqlString = new MySqlConnectionStringBuilder();
            /// string connection = "Database=db_test; UID=xablau; Password=123; port=3306; sslmode = none";

            mysqlString.Database = DATABASE;
            mysqlString.UserID = USER;
            mysqlString.Password = PASSWORD;
            mysqlString.Port = PORT;
            mysqlString.SslMode = MySqlSslMode.None;


            mySqlConnection = new MySqlConnection(mysqlString.ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BpmCadastrar_Click(object sender, EventArgs e)
        {
            string query = "INSERT into user (Matricula, Nome)" +
                "values (" + textBoxMatricula.Text +
                ",'" + textBoxNome.Text + "')";
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
