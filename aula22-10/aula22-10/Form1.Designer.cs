namespace aula22_10
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
            this.textBox1_buscar = new System.Windows.Forms.TextBox();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.label1_nome = new System.Windows.Forms.Label();
            this.label1_senha = new System.Windows.Forms.Label();
            this.button1_deletar = new System.Windows.Forms.Button();
            this.groupBox1_atualizar = new System.Windows.Forms.GroupBox();
            this.button2_atualizar = new System.Windows.Forms.Button();
            this.label1_senha_atualizar = new System.Windows.Forms.Label();
            this.label1_nome_atualizar = new System.Windows.Forms.Label();
            this.textBox2_senha_atualizar = new System.Windows.Forms.TextBox();
            this.textBox1_nome_atualizar = new System.Windows.Forms.TextBox();
            this.groupBox1_atualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_buscar
            // 
            this.textBox1_buscar.Location = new System.Drawing.Point(12, 12);
            this.textBox1_buscar.Name = "textBox1_buscar";
            this.textBox1_buscar.Size = new System.Drawing.Size(157, 20);
            this.textBox1_buscar.TabIndex = 0;
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(178, 10);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(94, 22);
            this.button1_buscar.TabIndex = 1;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // label1_nome
            // 
            this.label1_nome.AutoSize = true;
            this.label1_nome.Location = new System.Drawing.Point(12, 55);
            this.label1_nome.Name = "label1_nome";
            this.label1_nome.Size = new System.Drawing.Size(0, 13);
            this.label1_nome.TabIndex = 2;
            // 
            // label1_senha
            // 
            this.label1_senha.AutoSize = true;
            this.label1_senha.Location = new System.Drawing.Point(134, 55);
            this.label1_senha.Name = "label1_senha";
            this.label1_senha.Size = new System.Drawing.Size(0, 13);
            this.label1_senha.TabIndex = 3;
            // 
            // button1_deletar
            // 
            this.button1_deletar.Location = new System.Drawing.Point(178, 49);
            this.button1_deletar.Name = "button1_deletar";
            this.button1_deletar.Size = new System.Drawing.Size(94, 23);
            this.button1_deletar.TabIndex = 4;
            this.button1_deletar.Text = "Deletar";
            this.button1_deletar.UseVisualStyleBackColor = true;
            this.button1_deletar.Click += new System.EventHandler(this.button1_deletar_Click);
            // 
            // groupBox1_atualizar
            // 
            this.groupBox1_atualizar.Controls.Add(this.button2_atualizar);
            this.groupBox1_atualizar.Controls.Add(this.label1_senha_atualizar);
            this.groupBox1_atualizar.Controls.Add(this.label1_nome_atualizar);
            this.groupBox1_atualizar.Controls.Add(this.textBox2_senha_atualizar);
            this.groupBox1_atualizar.Controls.Add(this.textBox1_nome_atualizar);
            this.groupBox1_atualizar.Location = new System.Drawing.Point(15, 111);
            this.groupBox1_atualizar.Name = "groupBox1_atualizar";
            this.groupBox1_atualizar.Size = new System.Drawing.Size(257, 139);
            this.groupBox1_atualizar.TabIndex = 5;
            this.groupBox1_atualizar.TabStop = false;
            this.groupBox1_atualizar.Text = "Atualizar";
            // 
            // button2_atualizar
            // 
            this.button2_atualizar.Location = new System.Drawing.Point(129, 94);
            this.button2_atualizar.Name = "button2_atualizar";
            this.button2_atualizar.Size = new System.Drawing.Size(112, 39);
            this.button2_atualizar.TabIndex = 4;
            this.button2_atualizar.Text = "Atualizar";
            this.button2_atualizar.UseVisualStyleBackColor = true;
            this.button2_atualizar.Click += new System.EventHandler(this.button2_atualizar_Click);
            // 
            // label1_senha_atualizar
            // 
            this.label1_senha_atualizar.AutoSize = true;
            this.label1_senha_atualizar.Location = new System.Drawing.Point(7, 71);
            this.label1_senha_atualizar.Name = "label1_senha_atualizar";
            this.label1_senha_atualizar.Size = new System.Drawing.Size(41, 13);
            this.label1_senha_atualizar.TabIndex = 3;
            this.label1_senha_atualizar.Text = "Senha:";
            // 
            // label1_nome_atualizar
            // 
            this.label1_nome_atualizar.AutoSize = true;
            this.label1_nome_atualizar.Location = new System.Drawing.Point(7, 28);
            this.label1_nome_atualizar.Name = "label1_nome_atualizar";
            this.label1_nome_atualizar.Size = new System.Drawing.Size(38, 13);
            this.label1_nome_atualizar.TabIndex = 2;
            this.label1_nome_atualizar.Text = "Nome:";
            // 
            // textBox2_senha_atualizar
            // 
            this.textBox2_senha_atualizar.Location = new System.Drawing.Point(68, 68);
            this.textBox2_senha_atualizar.Name = "textBox2_senha_atualizar";
            this.textBox2_senha_atualizar.Size = new System.Drawing.Size(173, 20);
            this.textBox2_senha_atualizar.TabIndex = 1;
            // 
            // textBox1_nome_atualizar
            // 
            this.textBox1_nome_atualizar.Location = new System.Drawing.Point(68, 28);
            this.textBox1_nome_atualizar.Name = "textBox1_nome_atualizar";
            this.textBox1_nome_atualizar.Size = new System.Drawing.Size(173, 20);
            this.textBox1_nome_atualizar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1_atualizar);
            this.Controls.Add(this.button1_deletar);
            this.Controls.Add(this.label1_senha);
            this.Controls.Add(this.label1_nome);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.textBox1_buscar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_atualizar.ResumeLayout(false);
            this.groupBox1_atualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_buscar;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.Label label1_nome;
        private System.Windows.Forms.Label label1_senha;
        private System.Windows.Forms.Button button1_deletar;
        private System.Windows.Forms.GroupBox groupBox1_atualizar;
        private System.Windows.Forms.Button button2_atualizar;
        private System.Windows.Forms.Label label1_senha_atualizar;
        private System.Windows.Forms.Label label1_nome_atualizar;
        private System.Windows.Forms.TextBox textBox2_senha_atualizar;
        private System.Windows.Forms.TextBox textBox1_nome_atualizar;
    }
}

