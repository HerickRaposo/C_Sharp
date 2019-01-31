using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VA3_Padaria__HerickRaposo.Model;
using VA3_Padaria__HerickRaposo.Control;


namespace VA3_Padaria__HerickRaposo
{
    public partial class MainForm : Form        //OBS: Pedido = Registro
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
            comboBox1.Items.Add("P");
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("G");

            comboBox2.Items.Add("P");
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("G");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            try
            {
                int result;
                registro.Nome = textBoxNome.Text;
                registro.Quantidade = int.Parse(textBoxQuantidade.Text);
                registro.Tamanho = comboBox1.Text;

                result = control.Cadastrar(registro);

                if (result > 0)
                {
                    MessageBox.Show(String.Format("{0} Produto(s) Cadastrado(s)!!", result, "Aviso"));
                    int countPedidos = int.Parse(labelContador.Text);
                    countPedidos++;
                    labelContador.Text = countPedidos.ToString();
                }
                else
                {

                    MessageBox.Show("Nenhuma Produto registrada!!", "Erro de inserção");

                }

                comboBox1.SelectedIndex = -1;
                UpdateDataGrid();
            }

            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos!!", "Impossível cadastrar");
            }
        }

        private void buttonADCCafezinho_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();           

            try
            {
                int result;
                registro.Nome = "Cafezinho";
                registro.Quantidade = int.Parse("1");
                registro.Tamanho = comboBox1.Text;
                result = control.Cadastrar(registro);
                MessageBox.Show(String.Format("{0} Produto cadastrada!!", result, "Aviso"));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonADCPaoDeQueijo_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            try
            {
                int result;
                registro.Nome = "Pao de Queijo";
                registro.Quantidade = int.Parse("1");
                registro.Tamanho = comboBox1.Text;
                result = control.Cadastrar(registro);
                MessageBox.Show(String.Format("Pao de Queijo Adicionado!!"));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonADCPaoComManteiga_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            try
            {
                int result;
                registro.Nome = "Pao com Manteiga";
                registro.Quantidade = int.Parse("1");
                registro.Tamanho = comboBox1.Text;
                result = control.Cadastrar(registro);
                MessageBox.Show(String.Format("Pao com Manteiga adicionado!!"));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                dataGridView1.DataSource = control.ExibePorID(int.Parse(textBoxBuscar.Text));
            }

            else
            {
                MessageBox.Show("Todos os dados serão exibidos\n" +
                                "Para uma busca mais específica, digite o id", "Aviso");
                dataGridView1.DataSource = control.ExibirTudo();

            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            Registro delRegistro = new Registro();

            try
            {
                int result;
                delRegistro.Id = int.Parse(textBoxBuscar.Text);
                result = control.Deletar(delRegistro);

                if (result > 0)
                {

                    MessageBox.Show("ID: " + textBoxBuscar.Text + " excluído com sucesso.",
                                    "Excluir registro");
                    Count();

                }

                else
                {
                    MessageBox.Show("O ID: " + textBoxBuscar.Text + " não existe ou ja foi excluído!!" +
                                    "\nDigite outro id para a exclusão do registro!!", "Erro");
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Digite outro id ", "Impossível excluir registro ");

            }
            finally
            {
                UpdateDataGrid();
            }

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            Registro novoregistro = new  Registro();
            try
            {
                int result;
                novoregistro.Nome = textBoxUpdateNome.Text;
                novoregistro.Quantidade = int.Parse(textBoxUpdateQtd.Text);
                novoregistro.Tamanho = comboBox2.Text;

                result = control.AtualizarRegistro(int.Parse(textBoxBuscar.Text), novoregistro);
                if (result > 0)
                {

                    MessageBox.Show(String.Format("{0} Registro de produto alterado", result));
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

        private void buttonAtualizarGrid_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
            Count();
        }
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

        public void Count()
        {
            labelContador.Font = new Font(labelContador.Font.FontFamily, 10);
            labelContador.Text = control.ExibeContador("Operarias").ToString();           
        }
    }
}
