using Agenda_05_11_model.Control;
using Agenda_05_11_model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_05_11_model
{
    public partial class Form1 : Form
    {
        ContatoController contatoController = new ContatoController();
        public Form1()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int result;
            Contato contato = new Contato();
            contato.Nome = textBox1.Text;
            contato.Email = textBox2.Text;
            contato.Telefone = textBox3.Text;
            contato.DataCadastro = DateTime.Now;
            result = contatoController.Cadastrar(contato);
            if (result > 0)
            {
                MessageBox.Show(String.Format("{0} Contato cadastrado", result));
            }
            else
            {
                MessageBox.Show("Nenhum Contato cadastrado");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            if (contatoController.Exibir() == null)
            {
                MessageBox.Show("Nenhum Contato Cadastrado !","Erro sem Cadastro");
            }
            else
            {
                dataGridView1.DataSource = contatoController.Exibir();
                dataGridView1.Update();
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            int result;
            Contato contato = new Contato();
            contato.Nome = textBox_nome_update.Text;
            int id =int.Parse(textBox_id_update.Text);
            result = contatoController.Update(id, contato);
            if (result > 0)
            {
                MessageBox.Show(String.Format("{0} Contato alterado", result));
            }
            else
            {
                MessageBox.Show("Nenhum Contato alterado");
            }
            UpdateDataGrid();
            textBox_nome_update.Clear();
            textBox_id_update.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int result;
            Contato contato = new Contato();
            contato.Id = int.Parse(textBox_delete.Text);
            result = contatoController.Delete(contato);
            if (result > 0)
            {
                MessageBox.Show(String.Format("{0} Contato alterado", result));
            }
            else
            {
                MessageBox.Show("Nenhum Contato alterado");
            }
            UpdateDataGrid();
            textBox_delete.Clear();
        }
    }
}
