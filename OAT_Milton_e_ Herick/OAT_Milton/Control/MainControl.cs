using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAT_Milton.Model;

namespace OAT_Milton.Control
{
    class MainControl
    {
        DAORegistro daoRegistro = new DAORegistro();
       


        //=========================== INSERT ============================
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


        //========================== SELECT ALL =========================
        public List<Registro> ExibirTudo()
        {
            return daoRegistro.SelectAll();
        }


        //========================= SELECT ID ===========================
        public List<Registro> ExibePorID(int id)
        {
            return daoRegistro.SelectByID(id);
        }


        //========================== CONTADOR ===========================
        public int ExibeContador(string s)
        {
            
            return daoRegistro.SelectCount(s);
        }


        //========================== UPDATE =============================
        public int AtualizarRegistro(int id, Registro registro)
        {
            int result = 0;
            result = daoRegistro.Update(id, registro);
            return result;
        }


        //========================== DELETE =============================
        public int Deletar(Registro registro)
        {
            int result = 0;
            
            result = daoRegistro.Delete(registro);
            return result;   
        }
    }
}
