namespace aula_01_10
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
            this.label1nome = new System.Windows.Forms.Label();
            this.label1_senha = new System.Windows.Forms.Label();
            this.textBox1_nome = new System.Windows.Forms.TextBox();
            this.textBox2_senha = new System.Windows.Forms.TextBox();
            this.button1_login = new System.Windows.Forms.Button();
            this.button1_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1nome
            // 
            this.label1nome.AutoSize = true;
            this.label1nome.Location = new System.Drawing.Point(13, 72);
            this.label1nome.Name = "label1nome";
            this.label1nome.Size = new System.Drawing.Size(38, 13);
            this.label1nome.TabIndex = 0;
            this.label1nome.Text = "Nome:";
            // 
            // label1_senha
            // 
            this.label1_senha.AutoSize = true;
            this.label1_senha.Location = new System.Drawing.Point(13, 110);
            this.label1_senha.Name = "label1_senha";
            this.label1_senha.Size = new System.Drawing.Size(41, 13);
            this.label1_senha.TabIndex = 1;
            this.label1_senha.Text = "Senha:";
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.Location = new System.Drawing.Point(58, 72);
            this.textBox1_nome.Name = "textBox1_nome";
            this.textBox1_nome.Size = new System.Drawing.Size(214, 20);
            this.textBox1_nome.TabIndex = 2;
            // 
            // textBox2_senha
            // 
            this.textBox2_senha.Location = new System.Drawing.Point(60, 110);
            this.textBox2_senha.Name = "textBox2_senha";
            this.textBox2_senha.Size = new System.Drawing.Size(212, 20);
            this.textBox2_senha.TabIndex = 3;
            this.textBox2_senha.UseSystemPasswordChar = true;
            // 
            // button1_login
            // 
            this.button1_login.Location = new System.Drawing.Point(13, 210);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(105, 40);
            this.button1_login.TabIndex = 4;
            this.button1_login.Text = "Login";
            this.button1_login.UseVisualStyleBackColor = true;
            this.button1_login.Click += new System.EventHandler(this.button1_login_Click);
            // 
            // button1_create
            // 
            this.button1_create.Location = new System.Drawing.Point(167, 210);
            this.button1_create.Name = "button1_create";
            this.button1_create.Size = new System.Drawing.Size(105, 40);
            this.button1_create.TabIndex = 5;
            this.button1_create.Text = "Criar Usuário";
            this.button1_create.UseVisualStyleBackColor = true;
            this.button1_create.Click += new System.EventHandler(this.button1_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 259);
            this.Controls.Add(this.button1_create);
            this.Controls.Add(this.button1_login);
            this.Controls.Add(this.textBox2_senha);
            this.Controls.Add(this.textBox1_nome);
            this.Controls.Add(this.label1_senha);
            this.Controls.Add(this.label1nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1nome;
        private System.Windows.Forms.Label label1_senha;
        private System.Windows.Forms.TextBox textBox1_nome;
        private System.Windows.Forms.TextBox textBox2_senha;
        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.Button button1_create;
    }
}

