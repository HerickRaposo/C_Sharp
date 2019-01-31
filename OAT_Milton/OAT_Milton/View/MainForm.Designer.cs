namespace OAT_Milton
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.txtBoxIdade = new System.Windows.Forms.TextBox();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.comboBoxBuscarNivel = new System.Windows.Forms.ComboBox();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.lbSelectNivel = new System.Windows.Forms.Label();
            this.lbSelectTipo = new System.Windows.Forms.Label();
            this.lbSelectId = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtBoxDeleteId = new System.Windows.Forms.TextBox();
            this.lbDeleteIdade = new System.Windows.Forms.Label();
            this.groupBoxAtualizar = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQtdQueen = new System.Windows.Forms.Label();
            this.lbQtdRanger = new System.Windows.Forms.Label();
            this.lbQtdOperarias = new System.Windows.Forms.Label();
            this.labelQn = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxAtualizar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(9, 26);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(37, 13);
            this.lbIdade.TabIndex = 0;
            this.lbIdade.Text = "Idade:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(9, 60);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(76, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo de cargo:";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(229, 60);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(77, 13);
            this.lbNivel.TabIndex = 3;
            this.lbNivel.Text = "Nivel de Sen. :";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(312, 57);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(108, 21);
            this.comboBoxNivel.TabIndex = 5;
            // 
            // txtBoxIdade
            // 
            this.txtBoxIdade.Location = new System.Drawing.Point(52, 23);
            this.txtBoxIdade.Name = "txtBoxIdade";
            this.txtBoxIdade.Size = new System.Drawing.Size(85, 20);
            this.txtBoxIdade.TabIndex = 6;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.comboBoxBuscarNivel);
            this.groupBoxSelect.Controls.Add(this.comboBoxBuscarTipo);
            this.groupBoxSelect.Controls.Add(this.btnBuscar);
            this.groupBoxSelect.Controls.Add(this.txtBoxID);
            this.groupBoxSelect.Controls.Add(this.lbSelectNivel);
            this.groupBoxSelect.Controls.Add(this.lbSelectTipo);
            this.groupBoxSelect.Controls.Add(this.lbSelectId);
            this.groupBoxSelect.Location = new System.Drawing.Point(12, 153);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(307, 108);
            this.groupBoxSelect.TabIndex = 8;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Buscar registro por:";
            // 
            // comboBoxBuscarNivel
            // 
            this.comboBoxBuscarNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarNivel.FormattingEnabled = true;
            this.comboBoxBuscarNivel.Location = new System.Drawing.Point(89, 67);
            this.comboBoxBuscarNivel.Name = "comboBoxBuscarNivel";
            this.comboBoxBuscarNivel.Size = new System.Drawing.Size(86, 21);
            this.comboBoxBuscarNivel.TabIndex = 13;
            // 
            // comboBoxBuscarTipo
            // 
            this.comboBoxBuscarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarTipo.FormattingEnabled = true;
            this.comboBoxBuscarTipo.Location = new System.Drawing.Point(89, 43);
            this.comboBoxBuscarTipo.Name = "comboBoxBuscarTipo";
            this.comboBoxBuscarTipo.Size = new System.Drawing.Size(86, 21);
            this.comboBoxBuscarTipo.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(190, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 52);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(89, 16);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(67, 20);
            this.txtBoxID.TabIndex = 3;
            // 
            // lbSelectNivel
            // 
            this.lbSelectNivel.AutoSize = true;
            this.lbSelectNivel.Location = new System.Drawing.Point(7, 71);
            this.lbSelectNivel.Name = "lbSelectNivel";
            this.lbSelectNivel.Size = new System.Drawing.Size(76, 13);
            this.lbSelectNivel.TabIndex = 2;
            this.lbSelectNivel.Text = "Nível de Sen.:";
            // 
            // lbSelectTipo
            // 
            this.lbSelectTipo.AutoSize = true;
            this.lbSelectTipo.Location = new System.Drawing.Point(7, 47);
            this.lbSelectTipo.Name = "lbSelectTipo";
            this.lbSelectTipo.Size = new System.Drawing.Size(76, 13);
            this.lbSelectTipo.TabIndex = 1;
            this.lbSelectTipo.Text = "Tipo de cargo:";
            // 
            // lbSelectId
            // 
            this.lbSelectId.AutoSize = true;
            this.lbSelectId.Location = new System.Drawing.Point(7, 20);
            this.lbSelectId.Name = "lbSelectId";
            this.lbSelectId.Size = new System.Drawing.Size(69, 13);
            this.lbSelectId.TabIndex = 0;
            this.lbSelectId.Text = "Id da abelha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(212, 102);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 37);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar abelha";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.btnDeletar);
            this.groupBoxDelete.Controls.Add(this.txtBoxDeleteId);
            this.groupBoxDelete.Controls.Add(this.lbDeleteIdade);
            this.groupBoxDelete.Location = new System.Drawing.Point(339, 153);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(204, 108);
            this.groupBoxDelete.TabIndex = 10;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Deletar registro:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(37, 47);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(131, 48);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Apagar registro";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtBoxDeleteId
            // 
            this.txtBoxDeleteId.Location = new System.Drawing.Point(70, 19);
            this.txtBoxDeleteId.Name = "txtBoxDeleteId";
            this.txtBoxDeleteId.Size = new System.Drawing.Size(67, 20);
            this.txtBoxDeleteId.TabIndex = 1;
            // 
            // lbDeleteIdade
            // 
            this.lbDeleteIdade.AutoSize = true;
            this.lbDeleteIdade.Location = new System.Drawing.Point(6, 23);
            this.lbDeleteIdade.Name = "lbDeleteIdade";
            this.lbDeleteIdade.Size = new System.Drawing.Size(58, 13);
            this.lbDeleteIdade.TabIndex = 0;
            this.lbDeleteIdade.Text = "Digite o Id:";
            // 
            // groupBoxAtualizar
            // 
            this.groupBoxAtualizar.Controls.Add(this.btnOpen);
            this.groupBoxAtualizar.Location = new System.Drawing.Point(564, 152);
            this.groupBoxAtualizar.Name = "groupBoxAtualizar";
            this.groupBoxAtualizar.Size = new System.Drawing.Size(208, 109);
            this.groupBoxAtualizar.TabIndex = 11;
            this.groupBoxAtualizar.TabStop = false;
            this.groupBoxAtualizar.Text = "Atualizar registro:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(40, 48);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(131, 48);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Abrir janela de Atualização";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(92, 57);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(113, 21);
            this.comboBoxTipo.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbQtdQueen);
            this.groupBox1.Controls.Add(this.lbQtdRanger);
            this.groupBox1.Controls.Add(this.lbQtdOperarias);
            this.groupBox1.Controls.Add(this.labelQn);
            this.groupBox1.Controls.Add(this.labelRg);
            this.groupBox1.Controls.Add(this.labelOp);
            this.groupBox1.Location = new System.Drawing.Point(564, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 127);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantidade de abelhas nos cargos de:";
            // 
            // lbQtdQueen
            // 
            this.lbQtdQueen.AutoSize = true;
            this.lbQtdQueen.ForeColor = System.Drawing.Color.Red;
            this.lbQtdQueen.Location = new System.Drawing.Point(116, 102);
            this.lbQtdQueen.Name = "lbQtdQueen";
            this.lbQtdQueen.Size = new System.Drawing.Size(13, 13);
            this.lbQtdQueen.TabIndex = 3;
            this.lbQtdQueen.Text = "0";
            // 
            // lbQtdRanger
            // 
            this.lbQtdRanger.AutoSize = true;
            this.lbQtdRanger.ForeColor = System.Drawing.Color.Green;
            this.lbQtdRanger.Location = new System.Drawing.Point(116, 64);
            this.lbQtdRanger.Name = "lbQtdRanger";
            this.lbQtdRanger.Size = new System.Drawing.Size(13, 13);
            this.lbQtdRanger.TabIndex = 3;
            this.lbQtdRanger.Text = "0";
            // 
            // lbQtdOperarias
            // 
            this.lbQtdOperarias.AutoSize = true;
            this.lbQtdOperarias.ForeColor = System.Drawing.Color.Blue;
            this.lbQtdOperarias.Location = new System.Drawing.Point(116, 28);
            this.lbQtdOperarias.Name = "lbQtdOperarias";
            this.lbQtdOperarias.Size = new System.Drawing.Size(13, 13);
            this.lbQtdOperarias.TabIndex = 3;
            this.lbQtdOperarias.Text = "0";
            // 
            // labelQn
            // 
            this.labelQn.AutoSize = true;
            this.labelQn.Location = new System.Drawing.Point(18, 102);
            this.labelQn.Name = "labelQn";
            this.labelQn.Size = new System.Drawing.Size(49, 13);
            this.labelQn.TabIndex = 2;
            this.labelQn.Text = "Rainhas:";
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.Location = new System.Drawing.Point(18, 64);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(65, 13);
            this.labelRg.TabIndex = 1;
            this.labelRg.Text = "Patrulheiras:";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Location = new System.Drawing.Point(18, 28);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(55, 13);
            this.labelOp.TabIndex = 0;
            this.labelOp.Text = "Operarias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.groupBoxAtualizar);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBoxSelect);
            this.Controls.Add(this.txtBoxIdade);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbIdade);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco das Abelhas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.groupBoxAtualizar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.TextBox txtBoxIdade;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lbSelectNivel;
        private System.Windows.Forms.Label lbSelectTipo;
        private System.Windows.Forms.Label lbSelectId;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtBoxDeleteId;
        private System.Windows.Forms.Label lbDeleteIdade;
        private System.Windows.Forms.GroupBox groupBoxAtualizar;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelQn;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label lbQtdOperarias;
        private System.Windows.Forms.Label lbQtdRanger;
        private System.Windows.Forms.Label lbQtdQueen;
        private System.Windows.Forms.ComboBox comboBoxBuscarTipo;
        private System.Windows.Forms.ComboBox comboBoxBuscarNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

