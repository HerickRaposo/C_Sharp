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
        
        MainForm user = new MainForm();
        MainControl control = new MainControl();
        Registro registro = new Registro();

        public JanelaAtualizacao()
        {
            InitializeComponent();
            
        }

        private void JanelaAtualizacao_Load(object sender, EventArgs e)
        {
            comboBoxUpdateTipo.Items.Add("Operarias");
            comboBoxUpdateTipo.Items.Add("Patrulheiras");
            comboBoxUpdateTipo.Items.Add("Rainhas");

            comboBoxUpdateNivel.Items.Add("Júnior");
            comboBoxUpdateNivel.Items.Add("Pleno");
            comboBoxUpdateNivel.Items.Add("Sênior");
        }

        //======================== BUSCAR ID ================================
        private void btnBuscarId_Click(object sender, EventArgs e)
        {

            Busca();
            
        }


        //====================== BOTÃO ATUALIZAR ============================
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int result;

                registro.Idade = int.Parse(txtBoxUpdateIdade.Text);
                registro.Tipo = comboBoxUpdateTipo.Text;
                registro.Nivel = comboBoxUpdateNivel.Text;
                result = control.AtualizarRegistro(int.Parse(txtBoxSearchID.Text), registro);
                if (result > 0)
                {

                    MessageBox.Show(String.Format("{0} Registro de abelha alterada", result));
                    this.Close();

                }

                else
                {

                    MessageBox.Show("Nenhum registro alterado", "Erro");
                    this.Close();

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Impossivel atualizar\n" +
                                "Insira o Id no campo: Digite o id da abelha\n" +
                                "Insira os dados nos campos para à atualização", "Erro ao atualizar");
            }
           
        }


        //=========================== SELECT ================================
        public void Busca()
        {
            try
            {

                gridBusca.DataSource = control.ExibePorID(int.Parse(txtBoxSearchID.Text));

            }

            catch (Exception)
            {

                MessageBox.Show("Campo vazio\n" +
                                "Digite um id para a busca", "Erro de busca");

            }
        }
    }  
}
