using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OAT_Milton.Control;
using OAT_Milton.Model;


namespace OAT_Milton.View
{
    public partial class JanelaAtualizacao : Form
    {

        MainControl control = new MainControl();
        public JanelaAtualizacao()
        {
            InitializeComponent();
        }

        private void JanelaAtualizacao_Load(object sender, EventArgs e)
        {
            comboBoxUpdateTipo.Items.Add("Operarias");
            comboBoxUpdateTipo.Items.Add("Patrulheiras");
            comboBoxUpdateTipo.Items.Add("Rainhas");

            comboBoxUpdateNivel.Items.Add("Junior");
            comboBoxUpdateNivel.Items.Add("Pleno");
            comboBoxUpdateNivel.Items.Add("Senior");

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (txtBoxBusca.Text != "")
            {
                dataGridViewUpdate.DataSource = control.ExibePorID(int.Parse(txtBoxBusca.Text));
            }

            else
            {
                dataGridViewUpdate.DataSource = control.ExibirTudo();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int result;
            Registro registro = new Registro();
            registro.Idade = int.Parse(textBox1.Text);
            registro.Tipo = comboBoxUpdateTipo.Text;
            registro.Nivel = comboBoxUpdateNivel.Text;
            int id = int.Parse(txtBoxBusca.Text);
            result = control.Update(id, registro);
            if (result > 0)
            {
                MessageBox.Show(String.Format(" Registros alterado"));
            }
            else
            {
                MessageBox.Show("Nenhum Registro alterado");
            }

        }
    }
}
