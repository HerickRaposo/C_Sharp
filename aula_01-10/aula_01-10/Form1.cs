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

//na hora de criar usuario, verificar se existe, se sim, retorna msg que existe
//se não, criar usuario no banco, e exibir msg que usuario foi cadastrado!

namespace aula_01_10
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataReader dataReader;
        private MySqlCommand comando;

        //MySqlConnection mySqlConexao;

        MySqlConnectionStringBuilder mySqlString;

        private const string DATABASE = "cadastro";
        private const string USER ="admin";
        private const string PASSWORD = "admin";
        //private const string SslMode = "none";
        private const int PORT = 3306;


        public Form1()
        {
           // string conexao = "DATABASE=bd_test; UID=; PASSWORD=; SslMode=none; PORT=3306;";

            InitializeComponent();
            mySqlString = new MySqlConnectionStringBuilder();
            mySqlString.Database = DATABASE;
            mySqlString.UserID = USER;
            mySqlString.Password = PASSWORD;
            mySqlString.SslMode = MySqlSslMode.None;
            mySqlString.Port = PORT;

            connection = new MySqlConnection(mySqlString.ConnectionString);
        }


        private void button1_login_Click(object sender, EventArgs e)
        {

            string query = "select * from user where nome = '" + textBox1_nome.Text + "' and senha = '" + textBox2_senha.Text + "'";
            comando = new MySqlCommand(query, connection);
            //comando.Connection.Open();

            try
            {
                comando.Connection.Open();
                dataReader = comando.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                }
                else
                {
                    dataReader.Read();
                    MessageBox.Show("Bem vindo, " + dataReader["nome"]);
                }

                comando.Connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void button1_create_Click(object sender, EventArgs e)
        {
            string query = "insert into user(nome, senha) values('" + textBox1_nome.Text + "','" + textBox2_senha.Text + "')";

            comando = new MySqlCommand(query, connection);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                comando.Connection.Close();
                textBox1_nome.Clear();
                textBox2_senha.Clear();
            }
        }
    }
}
