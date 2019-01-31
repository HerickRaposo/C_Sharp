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

namespace aula_22_10_18_update_delete
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlConnectionStringBuilder MysqlString;
        MySqlCommand cmd;
        MySqlDataReader Read;


        string query;

        private const string USER = "admin";
        private const string PASSWORD = "admin";
        private const string DB = "sistema_01_10";
        private const int PORT = 3306;


        public string Connection()
        {
            MysqlString = new MySqlConnectionStringBuilder();

            MysqlString.UserID = USER;
            MysqlString.Password = PASSWORD;
            MysqlString.Database = DB;
            MysqlString.Port = PORT;
            MysqlString.SslMode = MySqlSslMode.None;

            return MysqlString.ConnectionString;
        }

        public Form1()
        {
            InitializeComponent();

            con = new MySqlConnection(Connection());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM user WHERE " +
                "nome= '" + txtBoxBuscar.Text + "'";

            cmd = new MySqlCommand(query, con);

            try
            {
                cmd.Connection.Open();
                Read = cmd.ExecuteReader();

                while (Read.Read()){

                
               
                labelNome.Text = Convert.ToString(Read[1]) ;
                labelSenha.Text = Convert.ToString(Read[2]);

                    //MessageBox.Show("Bem vindo " + Read["nome"]);
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuário Inexistente");
            }

            finally
            {
                cmd.Connection.Close();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM user WHERE id = id";

            cmd = new MySqlCommand(query, con);

            try
            {
                cmd.Connection.Open();
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
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
                cmd.Connection.Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            query = " UPDATE User set nome = '" + txBoxNome.Text +
                "', senha= '" + txtBoxSenha.Text + "'";

            cmd = new MySqlCommand(query, con);

            try
            {
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;

                int i = cmd.ExecuteNonQuery();
                if(i > 0)
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
                cmd.Connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
