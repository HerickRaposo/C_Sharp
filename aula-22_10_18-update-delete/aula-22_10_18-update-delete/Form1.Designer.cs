namespace aula_22_10_18_update_delete
{
    partial class Form1
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.groupBoxAtualizar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txBoxNome = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxAtualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(22, 75);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(160, 75);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(315, 75);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(94, 33);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // groupBoxAtualizar
            // 
            this.groupBoxAtualizar.Controls.Add(this.btnAtualizar);
            this.groupBoxAtualizar.Controls.Add(this.txtBoxSenha);
            this.groupBoxAtualizar.Controls.Add(this.txBoxNome);
            this.groupBoxAtualizar.Controls.Add(this.lbSenha);
            this.groupBoxAtualizar.Controls.Add(this.lbNome);
            this.groupBoxAtualizar.Location = new System.Drawing.Point(55, 133);
            this.groupBoxAtualizar.Name = "groupBoxAtualizar";
            this.groupBoxAtualizar.Size = new System.Drawing.Size(281, 154);
            this.groupBoxAtualizar.TabIndex = 5;
            this.groupBoxAtualizar.TabStop = false;
            this.groupBoxAtualizar.Text = "Atualizar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(92, 105);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 33);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(74, 55);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(155, 20);
            this.txtBoxSenha.TabIndex = 3;
            // 
            // txBoxNome
            // 
            this.txBoxNome.Location = new System.Drawing.Point(74, 26);
            this.txBoxNome.Name = "txBoxNome";
            this.txBoxNome.Size = new System.Drawing.Size(155, 20);
            this.txBoxNome.TabIndex = 2;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(6, 55);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(25, 28);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(259, 20);
            this.txtBoxBuscar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 317);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.groupBoxAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAtualizar.ResumeLayout(false);
            this.groupBoxAtualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.GroupBox groupBoxAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txBoxNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtBoxBuscar;
    }
}

