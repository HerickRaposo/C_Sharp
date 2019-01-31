namespace OAT_Milton.View
{
    partial class JanelaAtualizacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUpdateId = new System.Windows.Forms.Label();
            this.txtBoxSearchID = new System.Windows.Forms.TextBox();
            this.groupBoxBuscaID = new System.Windows.Forms.GroupBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridBusca = new System.Windows.Forms.DataGridView();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.lbUpdateDias = new System.Windows.Forms.Label();
            this.comboBoxUpdateNivel = new System.Windows.Forms.ComboBox();
            this.comboBoxUpdateTipo = new System.Windows.Forms.ComboBox();
            this.txtBoxUpdateIdade = new System.Windows.Forms.TextBox();
            this.lbUpdateNivel = new System.Windows.Forms.Label();
            this.lbUpdateTipo = new System.Windows.Forms.Label();
            this.lbUpdateIdade = new System.Windows.Forms.Label();
            this.groupBoxBuscaID.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusca)).BeginInit();
            this.groupBoxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUpdateId
            // 
            this.lbUpdateId.AutoSize = true;
            this.lbUpdateId.Location = new System.Drawing.Point(6, 25);
            this.lbUpdateId.Name = "lbUpdateId";
            this.lbUpdateId.Size = new System.Drawing.Size(113, 13);
            this.lbUpdateId.TabIndex = 0;
            this.lbUpdateId.Text = "Digite o id da abelha:  ";
            // 
            // txtBoxSearchID
            // 
            this.txtBoxSearchID.Location = new System.Drawing.Point(117, 22);
            this.txtBoxSearchID.Name = "txtBoxSearchID";
            this.txtBoxSearchID.Size = new System.Drawing.Size(68, 20);
            this.txtBoxSearchID.TabIndex = 1;
            // 
            // groupBoxBuscaID
            // 
            this.groupBoxBuscaID.Controls.Add(this.btnBuscarId);
            this.groupBoxBuscaID.Controls.Add(this.lbUpdateId);
            this.groupBoxBuscaID.Controls.Add(this.txtBoxSearchID);
            this.groupBoxBuscaID.Location = new System.Drawing.Point(58, 12);
            this.groupBoxBuscaID.Name = "groupBoxBuscaID";
            this.groupBoxBuscaID.Size = new System.Drawing.Size(306, 57);
            this.groupBoxBuscaID.TabIndex = 2;
            this.groupBoxBuscaID.TabStop = false;
            this.groupBoxBuscaID.Text = "Buscar por Id";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(205, 14);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(85, 34);
            this.btnBuscarId.TabIndex = 2;
            this.btnBuscarId.Text = "Buscar ID";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(129, 129);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(136, 49);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar registro";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridBusca);
            this.groupBox1.Location = new System.Drawing.Point(23, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da busca";
            // 
            // gridBusca
            // 
            this.gridBusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBusca.Location = new System.Drawing.Point(8, 32);
            this.gridBusca.Name = "gridBusca";
            this.gridBusca.RowHeadersVisible = false;
            this.gridBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridBusca.Size = new System.Drawing.Size(374, 43);
            this.gridBusca.TabIndex = 0;
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.lbUpdateDias);
            this.groupBoxUpdate.Controls.Add(this.comboBoxUpdateNivel);
            this.groupBoxUpdate.Controls.Add(this.comboBoxUpdateTipo);
            this.groupBoxUpdate.Controls.Add(this.txtBoxUpdateIdade);
            this.groupBoxUpdate.Controls.Add(this.lbUpdateNivel);
            this.groupBoxUpdate.Controls.Add(this.lbUpdateTipo);
            this.groupBoxUpdate.Controls.Add(this.lbUpdateIdade);
            this.groupBoxUpdate.Controls.Add(this.btnAtualizar);
            this.groupBoxUpdate.Location = new System.Drawing.Point(23, 200);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(392, 194);
            this.groupBoxUpdate.TabIndex = 5;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Atualizar Registros";
            // 
            // lbUpdateDias
            // 
            this.lbUpdateDias.AutoSize = true;
            this.lbUpdateDias.Location = new System.Drawing.Point(126, 32);
            this.lbUpdateDias.Name = "lbUpdateDias";
            this.lbUpdateDias.Size = new System.Drawing.Size(28, 13);
            this.lbUpdateDias.TabIndex = 9;
            this.lbUpdateDias.Text = "Dias";
            // 
            // comboBoxUpdateNivel
            // 
            this.comboBoxUpdateNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateNivel.FormattingEnabled = true;
            this.comboBoxUpdateNivel.Location = new System.Drawing.Point(271, 69);
            this.comboBoxUpdateNivel.Name = "comboBoxUpdateNivel";
            this.comboBoxUpdateNivel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxUpdateNivel.TabIndex = 8;
            // 
            // comboBoxUpdateTipo
            // 
            this.comboBoxUpdateTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateTipo.FormattingEnabled = true;
            this.comboBoxUpdateTipo.Location = new System.Drawing.Point(87, 69);
            this.comboBoxUpdateTipo.Name = "comboBoxUpdateTipo";
            this.comboBoxUpdateTipo.Size = new System.Drawing.Size(89, 21);
            this.comboBoxUpdateTipo.TabIndex = 8;
            // 
            // txtBoxUpdateIdade
            // 
            this.txtBoxUpdateIdade.Location = new System.Drawing.Point(48, 29);
            this.txtBoxUpdateIdade.Name = "txtBoxUpdateIdade";
            this.txtBoxUpdateIdade.Size = new System.Drawing.Size(61, 20);
            this.txtBoxUpdateIdade.TabIndex = 7;
            // 
            // lbUpdateNivel
            // 
            this.lbUpdateNivel.AutoSize = true;
            this.lbUpdateNivel.Location = new System.Drawing.Point(191, 72);
            this.lbUpdateNivel.Name = "lbUpdateNivel";
            this.lbUpdateNivel.Size = new System.Drawing.Size(74, 13);
            this.lbUpdateNivel.TabIndex = 6;
            this.lbUpdateNivel.Text = "Nivel de Sen.:";
            // 
            // lbUpdateTipo
            // 
            this.lbUpdateTipo.AutoSize = true;
            this.lbUpdateTipo.Location = new System.Drawing.Point(5, 72);
            this.lbUpdateTipo.Name = "lbUpdateTipo";
            this.lbUpdateTipo.Size = new System.Drawing.Size(76, 13);
            this.lbUpdateTipo.TabIndex = 5;
            this.lbUpdateTipo.Text = "Tipo de cargo:";
            // 
            // lbUpdateIdade
            // 
            this.lbUpdateIdade.AutoSize = true;
            this.lbUpdateIdade.Location = new System.Drawing.Point(5, 32);
            this.lbUpdateIdade.Name = "lbUpdateIdade";
            this.lbUpdateIdade.Size = new System.Drawing.Size(37, 13);
            this.lbUpdateIdade.TabIndex = 4;
            this.lbUpdateIdade.Text = "Idade:";
            // 
            // JanelaAtualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 428);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBuscaID);
            this.Name = "JanelaAtualizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de registro da colmeia";
            this.Load += new System.EventHandler(this.JanelaAtualizacao_Load);
            this.groupBoxBuscaID.ResumeLayout(false);
            this.groupBoxBuscaID.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBusca)).EndInit();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUpdateId;
        private System.Windows.Forms.TextBox txtBoxSearchID;
        private System.Windows.Forms.GroupBox groupBoxBuscaID;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Label lbUpdateDias;
        private System.Windows.Forms.ComboBox comboBoxUpdateNivel;
        private System.Windows.Forms.ComboBox comboBoxUpdateTipo;
        private System.Windows.Forms.TextBox txtBoxUpdateIdade;
        private System.Windows.Forms.Label lbUpdateNivel;
        private System.Windows.Forms.Label lbUpdateTipo;
        private System.Windows.Forms.Label lbUpdateIdade;
        private System.Windows.Forms.DataGridView gridBusca;
    }
}