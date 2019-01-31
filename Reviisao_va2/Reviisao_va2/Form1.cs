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


namespace Reviisao_va2
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataReader dataReader;
        private MySqlCommand comando;

        //MySqlConnection mySqlConexao;

        MySqlConnectionStringBuilder mySqlString;

        private const string DATABASE = "revisao";
        private const string USER = "admin";
        private const string PASSWORD = "admin";
        //private const string SslMode = "none";
        private const int PORT = 3306;

        public Form1()
        {
            InitializeComponent();
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

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string query = "insert into usuario (nome, cpf, rg, usuario, senha) values('" + textBoxNome.Text + "','" + textBoxCPF.Text + "','" + 
                textBoxRG.Text + "','" + textBoxUsuario.Text + "','"+ textBoxSenha.Text +"');";
            

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
                textBoxNome.Clear();
                textBoxCPF.Clear();
                textBoxRG.Clear();
                textBoxUsuario.Clear();
                textBoxSenha.Clear();
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM usuario WHERE " +
               "nome= '" + textBoxBuscar.Text + "'";

            comando = new MySqlCommand(query, connection);

            try
            {
                comando.Connection.Open();
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    labelNome.Text = Convert.ToString(dataReader[4]);
                    labelSenha.Text = Convert.ToString(dataReader[5]);

                    //MessageBox.Show("Bem vindo " + Read["nome"]);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuário Inexistente");
            }

            finally
            {
                comando.Connection.Close();
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
           string query = " UPDATE usuario set nome ='" + textBoxNome.Text + "', cpf= '" + textBoxCPF.Text + "', rg= '" + textBoxRG.Text + "', usuario= '" + textBoxUsuario.Text +  "', senha= '" + textBoxSenha.Text + "'";
           
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

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
             string query = "DELETE FROM usuario WHERE" + "nome= '" + textBoxBuscar.Text + "'";
            ;

            comando = new MySqlCommand(query, connection);

            try
            {
                comando.Connection.Open();
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                comando.Connection.Close();
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string query = "select * from usuario where usuario = '" + textBox6.Text + "' and senha = '" + textBox7.Text + "'";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxRegistro_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
