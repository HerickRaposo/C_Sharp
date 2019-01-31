using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OAT_Milton.Model;
using OAT_Milton.Control;
using OAT_Milton.View;

namespace OAT_Milton
{
    public partial class MainForm : Form
    {
        MainControl control = new MainControl();
        public MainForm()
        {
            InitializeComponent();
            UpdateDataGrid();
            Count();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
     
            comboBoxTipo.Items.Add("Operarias");
            comboBoxTipo.Items.Add("Patrulheiras");
            comboBoxTipo.Items.Add("Rainhas");

            comboBoxNivel.Items.Add("Júnior");
            comboBoxNivel.Items.Add("Pleno");
            comboBoxNivel.Items.Add("Sênior");

        }

        //=========================== INSERT ================================

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            Registro registro = new Registro();
 
            try
            {
                int result;
                registro.Idade = int.Parse(txtBoxIdade.Text);
                registro.Tipo = comboBoxTipo.Text;
                registro.Nivel = comboBoxNivel.Text;

                result = control.Cadastrar(registro);

                if (result > 0)
                {
                    MessageBox.Show(String.Format("{0} Abelha cadastrada!!", result, "Aviso"));
                    
                    if (registro.Tipo == "Operarias")
                    {
                        
                        int countOperarias = int.Parse(lbQtdOperarias.Text);
                        countOperarias++;
                        lbQtdOperarias.Text = countOperarias.ToString();

                    }

                    if (registro.Tipo == "Patrulheiras")
                    {

                        int countRanger = int.Parse(lbQtdRanger.Text);
                        countRanger++;
                        lbQtdRanger.Text = countRanger.ToString();
                    }

                    if (registro.Tipo == "Rainhas")
                    {

                        int countQueen = int.Parse(lbQtdQueen.Text);
                        countQueen++;
                        lbQtdQueen.Text =  countQueen.ToString();

                    }
                }
                else
                {

                    MessageBox.Show("Nenhuma abelha registrada!!", "Erro de inserção");

                }

                txtBoxIdade.Clear();
                comboBoxTipo.SelectedIndex = -1;
                comboBoxNivel.SelectedIndex = -1;
                UpdateDataGrid();
            }

            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos!!", "Impossível cadastrar");
            }
        }


        //=========================== SELECT ================================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text != "")
            {
                
                dataGridView1.DataSource = control.ExibePorID(int.Parse(txtBoxID.Text));
              
            }
          
            else
            {
                MessageBox.Show("Todos os dados serão exibidos\n" +
                                "Para uma busca mais específica, digite o id", "Aviso");
                dataGridView1.DataSource = control.ExibirTudo();

            }
            txtBoxID.Clear();
            
        }


        //=========================== DELETE ================================

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Registro delRegistro = new Registro();
            
            try
            {
                int result;
                delRegistro.Id = int.Parse(txtBoxDeleteId.Text);
                result = control.Deletar(delRegistro);

                if (result > 0)
                {

                    MessageBox.Show("ID: "+ txtBoxDeleteId.Text + " excluído com sucesso.", 
                                    "Excluir registro");
                    Count();
                    
                }
               
                else
                {
                    MessageBox.Show("O ID: "+ txtBoxDeleteId.Text  + " não existe ou ja foi excluído!!" +
                                    "\nDigite outro id para a exclusão do registro!!", "Erro" );
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Digite outro id para a exclusão do registro", "Impossível excluir registro ");

            }
            finally
            {
                UpdateDataGrid();
                txtBoxDeleteId.Clear();
            }

        }


        //=========================== ATUALIZA GRID ================================

        public void UpdateDataGrid()
        {
            if (control.ExibirTudo() == null)
            {
                MessageBox.Show("Nenhum Registro a ser exibido!!", "Registro vázio");
               
            }
            else
            {
                dataGridView1.DataSource = control.ExibirTudo();

                dataGridView1.Update();
            }
        }


        //=================== BOTÃO ABRE JANELA DE ATUALIZAçÃO  ========================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            JanelaAtualizacao abrirUpdate = new JanelaAtualizacao();
            abrirUpdate.ShowDialog();
        }


        //========================== BOTÃO ATUALIZA GRID ===============================
        private void btnAtualizaGrid_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
            Count();
        }


        //================================= CONTADOR ===================================
        public void Count()
        {
            labelOp.Font = new Font(labelOp.Font.FontFamily, 10);
            labelRg.Font = new Font(labelRg.Font.FontFamily, 10);
            labelQn.Font = new Font(labelQn.Font.FontFamily, 10);

            lbQtdOperarias.Font = new Font(lbQtdOperarias.Font.FontFamily, 10);
            lbQtdOperarias.Text = control.ExibeContador("Operarias").ToString();

            lbQtdRanger.Font = new Font(lbQtdRanger.Font.FontFamily, 10);
            lbQtdRanger.Text = control.ExibeContador("Patrulheiras").ToString();

            lbQtdQueen.Font = new Font(lbQtdQueen.Font.FontFamily, 10);
            lbQtdQueen.Text = control.ExibeContador("Rainhas").ToString();
        }

      

    }

}
