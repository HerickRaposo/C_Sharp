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

namespace aula22_10
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataReader dataReader;
        private MySqlCommand comando;

        //MySqlConnection mySqlConexao;

        MySqlConnectionStringBuilder mySqlString;

        private const string DATABASE = "bd_teste";
        private const string USER = "admin";
        private const string PASSWORD = "admin";
        //private const string SslMode = "none";
        private const int PORT = 3306;

        public Form1()
        {
            InitializeComponent();
            mySqlString = new MySqlConnectionStringBuilder();
            mySqlString.Database = DATABASE;
            mySqlString.UserID = USER;
            mySqlString.Password = PASSWORD;
            mySqlString.SslMode = MySqlSslMode.None;
            mySqlString.Port = PORT;

            connection = new MySqlConnection(mySqlString.ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {
            string query = "select * from users where nome = '" + textBox1_buscar.Text + "'";
            comando = new MySqlCommand(query, connection);

            try
            {
                comando.Connection.Open();
                dataReader = comando.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("Usuário inválido!");
                }
                else
                {
                    dataReader.Read();
                    label1_nome.Text = Convert.ToString(dataReader[1]);
                    label1_senha.Text = Convert.ToString(dataReader[2]);

                }                           

                comando.Connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_deletar_Click(object sender, EventArgs e)
        {
            string query = "delete from users where nome = '" + label1_nome.Text + "'";
            comando = new MySqlCommand(query, connection);

            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Usuário Deletado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button2_atualizar_Click(object sender, EventArgs e)
        {
            string query = " UPDATE users set nome = '" + textBox1_nome_atualizar.Text +
                "', senha= '" + textBox2_senha_atualizar.Text + "'";

            comando = new MySqlCommand(query, connection);

            try
            {
                comando.Connection.Open();
                comando.CommandType = CommandType.Text;

                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message);
            }

            finally
            {
                comando.Connection.Close();
            }
        }
    }
}
