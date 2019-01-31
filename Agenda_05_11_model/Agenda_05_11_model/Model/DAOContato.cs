using Agenda_05_11_model.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda_05_11_model.Model
{
    class DAOContato
    {
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        public int Insert (Contato contato)
        {
            int result = 0;
            ConexaoBD conexao = ConexaoBD.GetInsta;
            string query = String.Format("INSERT INTO contato(nome, email, telefone, data_cadastra) VALUES ('{0}','{1}','{2}','{3}');",
                contato.Nome,contato.Email,contato.Telefone,contato.DataCadastro);
            cmd = new MySqlCommand(query,conexao.GetConnection());
            try
            {
                conexao.OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex){ }
            finally
            {
                conexao.CloseConnection();
            }

            return result;
        }
        public int Update (int id,Contato novoContato)
        {
            int result = 0;
            ConexaoBD conexao = ConexaoBD.GetInsta;
            string query = String.Format("UPDATE contato SET nome ='{0}' WHERE id = {1}",novoContato.Nome,id);
            cmd = new MySqlCommand(query, conexao.GetConnection());
            try
            {
                conexao.OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.CloseConnection();
            }

            return result;
        }
        public int Delete (Contato contato)
        {
            int result = 0;
            ConexaoBD conexao = ConexaoBD.GetInsta;
            string query = String.Format("DELETE FROM contato WHERE id = {0}",contato.Id );
            cmd = new MySqlCommand(query, conexao.GetConnection());
            try
            {
                conexao.OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.CloseConnection();
            }

            return result;
        }
        public List<Contato> Select ()
        {
            List<Contato> contatos = null;
            Contato contato;
            ConexaoBD conexao = ConexaoBD.GetInsta;
            string query = "Select * from contato;";
            cmd = new MySqlCommand(query, conexao.GetConnection());
            try
            {
                conexao.OpenConnection();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    contatos = new List<Contato>();
                    while (reader.Read())
                    {
                        contato = new Contato();
                        contato.Id = (int)reader["id"];
                        contato.Nome = (string)reader["nome"];
                        contato.Email = (string)reader["email"];
                        contato.Telefone = (string)reader["telefone"];
                        //contato.DataCadastro = (DateTime)reader[5];
                        contatos.Add(contato);
                    }
                    reader.Close();
                }
                
            }
            catch (Exception ex)
            { }
            finally
            {
                conexao.CloseConnection();
            }
            return contatos;
        }
    }
}
