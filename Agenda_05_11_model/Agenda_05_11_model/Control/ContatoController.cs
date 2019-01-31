using Agenda_05_11_model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_05_11_model.Control
{
    class ContatoController
    {
        DAOContato dAO = new DAOContato ();
        public int Cadastrar (Contato contato)
        {
            if (contato != null)
            {
                int result = 0;
                dAO = new DAOContato();
                result = dAO.Insert(contato);
                return result;
            }
            return 0;
        }
        public List<Contato> Exibir ()
        {
            return dAO.Select();
        }
        public int Update (int id ,Contato contato)
        {
            int result = 0;
            dAO = new DAOContato();
            result = dAO.Update(id, contato);
            return result;
        }
        public int Delete(Contato contato)
        {
            int result = 0;
            dAO = new DAOContato();
            result = dAO.Delete(contato);
            return result;
        }
    }
}
