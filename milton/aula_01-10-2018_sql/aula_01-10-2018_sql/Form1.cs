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

namespace aula_01_10_2018_sql
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        MySqlConnectionStringBuilder MysqlString;



        private const string USER = "admin";
        private const string PASSWORD = "admin";
        private const string DB = "sistema_01_10";
        private const int PORT = 3306;
        //private const string SERVER = "localhost";

     //   private string Connection() { 
    //    }
        


        public Form1()
        {
            InitializeComponent();

            MysqlString = new MySqlConnectionStringBuilder();

            MysqlString.UserID = USER;
            MysqlString.Password = PASSWORD;
            MysqlString.Database = DB;
            MysqlString.Port = PORT;
            //MysqlString.Server = SERVER;
            MysqlString.SslMode = MySqlSslMode.None;

            conn = new MySqlConnection(MysqlString.ConnectionString);

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO user (nome, senha)" +
                          "VALUES ('" + txtBoxNome.Text + "', '" +
                          txtBoxSenha.Text + "')";
            MySqlCommand command = new MySqlCommand(query, conn);
            
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                command.Connection.Close();
                txtBoxNome.Clear();
                txtBoxSenha.Clear();
            }
           
        }  
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
