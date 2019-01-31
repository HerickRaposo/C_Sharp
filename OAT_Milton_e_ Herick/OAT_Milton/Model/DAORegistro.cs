using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAT_Milton.Connection;
using MySql.Data.MySqlClient;


namespace OAT_Milton.Model
{
    class DAORegistro
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

            query = String.Format("INSERT INTO colmeia (idade, tipo, nivel) " +
                "VALUES ('{0}', '{1}', '{2}')", registro.Idade, registro.Tipo, registro.Nivel);
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

            query = "SELECT * FROM colmeia";

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
                        registro.Idade = (int)dataReader["idade"];
                        registro.Tipo = (string)dataReader["tipo"];
                        registro.Nivel = (string)dataReader["nivel"];

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

            query = "SELECT * FROM colmeia WHERE id LIKE '" + id + "'";

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
                        registroUnico.Idade = (int)dataReader["idade"];
                        registroUnico.Tipo = (string)dataReader["tipo"];
                        registroUnico.Nivel = (string)dataReader["nivel"];

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

            query = "SELECT COUNT(tipo) FROM colmeia WHERE tipo = '" + s + "'";
            //query = SELECT tipo FROM colmeia WHERE tipo = '"+ s + "'";

            MysqlCmd = new MySqlCommand(query, con.GetConnection());
            int count = 0;

            try
            {
                con.OpenConnection();
                count = Convert.ToInt32(MysqlCmd.ExecuteScalar());
                /*dataReader = MysqlCmd.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    
                    while (dataReader.Read())
                    {

                        i++;
                        
                    }
                    dataReader.Close();
                }*/
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

            query = String.Format("UPDATE colmeia SET idade ='{0}', tipo = '{1}', nivel = '{2}'" +
                " WHERE id = {3}", novoRegistro.Idade, novoRegistro.Tipo, novoRegistro.Nivel, id);

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
        public int Delete(Registro idAbelha)
        {
            con = ConexaoBD.Get_Instance;

            query = "DELETE FROM colmeia WHERE id LIKE '" + idAbelha.Id + "'";
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
