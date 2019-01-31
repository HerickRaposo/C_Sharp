namespace aula27_09_2018
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.BpmCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(86, 6);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatricula.TabIndex = 1;
            this.textBoxMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(86, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoSize = true;
            this.txtMatricula.Location = new System.Drawing.Point(12, 9);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(50, 13);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.Text = "Matricula";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(12, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(35, 13);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome";
            // 
            // BpmCadastrar
            // 
            this.BpmCadastrar.Location = new System.Drawing.Point(15, 87);
            this.BpmCadastrar.Name = "BpmCadastrar";
            this.BpmCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BpmCadastrar.TabIndex = 3;
            this.BpmCadastrar.Text = "Cadastrar";
            this.BpmCadastrar.UseVisualStyleBackColor = true;
            this.BpmCadastrar.Click += new System.EventHandler(this.BpmCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BpmCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label txtMatricula;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button BpmCadastrar;
    }
}

