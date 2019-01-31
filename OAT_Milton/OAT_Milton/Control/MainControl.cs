using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAT_Milton.Model;

namespace OAT_Milton.Control
{
    class MainControl
    {
        DAORegistro daoRegistro = new DAORegistro();
        DataTable Dt = new DataTable();

        public int Cadastrar(Registro registro)
        {
            if (registro != null)
            {
                int result = 0;
                
                result = daoRegistro.Insert(registro);
                
                return result;
            }
            return 0;
        }

        public List<Registro> ExibirTudo()
        {
            return daoRegistro.SelectAll();
        }

        public List<Registro> ExibePorID(int id)
        {
            try
            {
                return daoRegistro.SelectByID(id);
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        
       
        public int Deletar(Registro registro)
        {
            int result = 0;
            
            result = daoRegistro.Delete(registro);
            return result;
            
        }
        public int Update(int id, Registro registro)
        {
            int result = 0;
            daoRegistro = new DAORegistro();
            result = daoRegistro.Update(id, registro);
            return result;
        }

    }
}
