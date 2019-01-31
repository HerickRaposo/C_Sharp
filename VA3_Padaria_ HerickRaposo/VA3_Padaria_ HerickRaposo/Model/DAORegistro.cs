using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA3_Padaria__HerickRaposo.Connection;
using MySql.Data.MySqlClient;

namespace VA3_Padaria__HerickRaposo.Model
{
    class DAORegistro           //OBS: Pedido = Registro
    {
        string query;

        ConexaoBD con;
        MySqlCommand MysqlCmd;
        MySqlDataReader dataReader;


        //=========================== INSERT ================================
        public int Insert(Registro registro)
        {
            int result = 0;
            con = ConexaoBD.Get_Instance;

            query = String.Format("INSERT INTO produtos (nome, quantidade, tamanho) " +
                "VALUES ('{0}', '{1}', '{2}')", registro.Nome, registro.Quantidade, registro.Tamanho);
            MysqlCmd = new MySqlCommand(query, con.GetConnection());

            try
            {
                con.OpenConnection();
                result = MysqlCmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.CloseConnection();
            }

            return result;
        }


        //=========================== SELECT ================================
        public List<Registro> SelectAll()
        {
            List<Registro> listRegistro = null;
            Registro registro;
            con = ConexaoBD.Get_Instance;

            query = "SELECT * FROM produtos";

            MysqlCmd = new MySqlCommand(query, con.GetConnection());
            try
            {
                con.OpenConnection();
                dataReader = MysqlCmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    listRegistro = new List<Registro>();
                    while (dataReader.Read())
                    {
                        registro = new Registro();
                        registro.Id = (int)dataReader["id"];
                        registro.Nome = (string)dataReader["nome"];
                        registro.Quantidade = (int)dataReader["quantidade"];
                        registro.Tamanho = (string)dataReader["tamanho"];

                        listRegistro.Add(registro);
                    }
                    dataReader.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }
            return listRegistro;
        }


        //======================= SELECT POR ID ============================
        public List<Registro> SelectByID(int id)
        {
            List<Registro> listRegistro = null;
            Registro registroUnico = new Registro();
            con = ConexaoBD.Get_Instance;

            query = "SELECT * FROM produtos WHERE id LIKE '" + id + "'";

            MysqlCmd = new MySqlCommand(query, con.GetConnection());
            try
            {
                con.OpenConnection();
                dataReader = MysqlCmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    listRegistro = new List<Registro>();
                    while (dataReader.Read())
                    {
                        registroUnico = new Registro();
                        registroUnico.Id = (int)dataReader["id"];
                        registroUnico.Nome = (string)dataReader["nome"];
                        registroUnico.Quantidade = (int)dataReader["quantidade"];
                        registroUnico.Tamanho = (string)dataReader["tamanho"];

                        listRegistro.Add(registroUnico);
                    }
                    dataReader.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }
            return listRegistro;
        }


        //======================= SELECT CONTADOR ============================
        public int SelectCount(string s)
        {

            con = ConexaoBD.Get_Instance;

            query = "SELECT COUNT(id) FROM produtos WHERE id = '" + s + "'";

            MysqlCmd = new MySqlCommand(query, con.GetConnection());
            int count = 0;

            try
            {
                con.OpenConnection();
                count = Convert.ToInt32(MysqlCmd.ExecuteScalar());
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }
            return count;
        }


        //=========================== UPDATE ================================
        public int Update(int id, Registro novoRegistro)
        {
            int result = 0;
            con = ConexaoBD.Get_Instance;

            query = String.Format("UPDATE produtos SET nome ='{0}', quantidade = '{1}', tamanho = '{2}'" +
                " WHERE id = {3}", novoRegistro.Nome, novoRegistro.Quantidade, novoRegistro.Tamanho, id);

            MysqlCmd = new MySqlCommand(query, con.GetConnection());

            try
            {
                con.OpenConnection();
                result = MysqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }

            return result;
        }


        //=========================== DELETE ================================
        public int Delete(Registro idPedido)
        {
            con = ConexaoBD.Get_Instance;

            query = "DELETE FROM produtos WHERE id LIKE '" + idPedido.Id + "'";
            MysqlCmd = new MySqlCommand(query, con.GetConnection());
            try
            {

                con.OpenConnection();
                int i = MysqlCmd.ExecuteNonQuery();

                if (i > 0)
                {
                    return i;
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                con.CloseConnection();
            }
            return 0;
        }
    }
}
