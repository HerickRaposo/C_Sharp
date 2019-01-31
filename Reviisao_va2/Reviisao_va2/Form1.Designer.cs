namespace Reviisao_va2
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
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxProcurar = new System.Windows.Forms.GroupBox();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.labelBuscaUsuario = new System.Windows.Forms.Label();
            this.labelBuscaRG = new System.Windows.Forms.Label();
            this.labelBuscaCPF = new System.Windows.Forms.Label();
            this.labelBuscaNome = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelLoginUsuario = new System.Windows.Forms.Label();
            this.groupBoxRegistro.SuspendLayout();
            this.groupBoxProcurar.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.groupBoxRegistro.Controls.Add(this.buttonRegistrar);
            this.groupBoxRegistro.Controls.Add(this.textBoxSenha);
            this.groupBoxRegistro.Controls.Add(this.textBoxUsuario);
            this.groupBoxRegistro.Controls.Add(this.textBoxRG);
            this.groupBoxRegistro.Controls.Add(this.textBoxCPF);
            this.groupBoxRegistro.Controls.Add(this.textBoxNome);
            this.groupBoxRegistro.Controls.Add(this.labelSenha);
            this.groupBoxRegistro.Controls.Add(this.labelUsuario);
            this.groupBoxRegistro.Controls.Add(this.labelRG);
            this.groupBoxRegistro.Controls.Add(this.labelCPF);
            this.groupBoxRegistro.Controls.Add(this.labelNome);
            this.groupBoxRegistro.Location = new System.Drawing.Point(13, 13);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(267, 305);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Registro";
            this.groupBoxRegistro.Enter += new System.EventHandler(this.groupBoxRegistro_Enter);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(61, 191);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(97, 40);
            this.buttonRegistrar.TabIndex = 10;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(52, 128);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(170, 20);
            this.textBoxSenha.TabIndex = 9;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(52, 101);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(170, 20);
            this.textBoxUsuario.TabIndex = 8;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(52, 74);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(170, 20);
            this.textBoxRG.TabIndex = 7;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(52, 47);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(170, 20);
            this.textBoxCPF.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(52, 20);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(170, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(7, 131);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(7, 101);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(7, 77);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(26, 13);
            this.labelRG.TabIndex = 2;
            this.labelRG.Text = "RG:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(9, 50);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 27);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // groupBoxProcurar
            // 
            this.groupBoxProcurar.Controls.Add(this.buttonDeletar);
            this.groupBoxProcurar.Controls.Add(this.buttonAtualizar);
            this.groupBoxProcurar.Controls.Add(this.labelBuscaUsuario);
            this.groupBoxProcurar.Controls.Add(this.labelBuscaRG);
            this.groupBoxProcurar.Controls.Add(this.labelBuscaCPF);
            this.groupBoxProcurar.Controls.Add(this.labelBuscaNome);
            this.groupBoxProcurar.Controls.Add(this.buttonBuscar);
            this.groupBoxProcurar.Controls.Add(this.textBoxBuscar);
            this.groupBoxProcurar.Location = new System.Drawing.Point(316, 13);
            this.groupBoxProcurar.Name = "groupBoxProcurar";
            this.groupBoxProcurar.Size = new System.Drawing.Size(441, 144);
            this.groupBoxProcurar.TabIndex = 1;
            this.groupBoxProcurar.TabStop = false;
            this.groupBoxProcurar.Text = "Procurar:";
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(232, 95);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(83, 25);
            this.buttonDeletar.TabIndex = 7;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(29, 96);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(103, 25);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // labelBuscaUsuario
            // 
            this.labelBuscaUsuario.AutoSize = true;
            this.labelBuscaUsuario.Location = new System.Drawing.Point(385, 54);
            this.labelBuscaUsuario.Name = "labelBuscaUsuario";
            this.labelBuscaUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelBuscaUsuario.TabIndex = 5;
            this.labelBuscaUsuario.Text = "Usuario";
            // 
            // labelBuscaRG
            // 
            this.labelBuscaRG.AutoSize = true;
            this.labelBuscaRG.Location = new System.Drawing.Point(240, 54);
            this.labelBuscaRG.Name = "labelBuscaRG";
            this.labelBuscaRG.Size = new System.Drawing.Size(23, 13);
            this.labelBuscaRG.TabIndex = 4;
            this.labelBuscaRG.Text = "RG";
            // 
            // labelBuscaCPF
            // 
            this.labelBuscaCPF.AutoSize = true;
            this.labelBuscaCPF.Location = new System.Drawing.Point(136, 54);
            this.labelBuscaCPF.Name = "labelBuscaCPF";
            this.labelBuscaCPF.Size = new System.Drawing.Size(29, 13);
            this.labelBuscaCPF.TabIndex = 3;
            this.labelBuscaCPF.Text = "lCPF";
            // 
            // labelBuscaNome
            // 
            this.labelBuscaNome.AutoSize = true;
            this.labelBuscaNome.Location = new System.Drawing.Point(26, 54);
            this.labelBuscaNome.Name = "labelBuscaNome";
            this.labelBuscaNome.Size = new System.Drawing.Size(35, 13);
            this.labelBuscaNome.TabIndex = 2;
            this.labelBuscaNome.Text = "Nome";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(345, 17);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(7, 20);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(332, 20);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonEntrar);
            this.groupBoxLogin.Controls.Add(this.labelLoginSenha);
            this.groupBoxLogin.Controls.Add(this.textBox7);
            this.groupBoxLogin.Controls.Add(this.textBox6);
            this.groupBoxLogin.Controls.Add(this.labelLoginUsuario);
            this.groupBoxLogin.Location = new System.Drawing.Point(316, 164);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(441, 154);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(330, 40);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(90, 29);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.Location = new System.Drawing.Point(10, 65);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(41, 13);
            this.labelLoginSenha.TabIndex = 3;
            this.labelLoginSenha.Text = "Senha:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(59, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(204, 20);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(59, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 20);
            this.textBox6.TabIndex = 1;
            // 
            // labelLoginUsuario
            // 
            this.labelLoginUsuario.AutoSize = true;
            this.labelLoginUsuario.Location = new System.Drawing.Point(7, 30);
            this.labelLoginUsuario.Name = "labelLoginUsuario";
            this.labelLoginUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelLoginUsuario.TabIndex = 0;
            this.labelLoginUsuario.Text = "Usuario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 332);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxProcurar);
            this.Controls.Add(this.groupBoxRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            this.groupBoxProcurar.ResumeLayout(false);
            this.groupBoxProcurar.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox groupBoxProcurar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Label labelBuscaUsuario;
        private System.Windows.Forms.Label labelBuscaRG;
        private System.Windows.Forms.Label labelBuscaCPF;
        private System.Windows.Forms.Label labelBuscaNome;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label labelLoginSenha;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelLoginUsuario;
    }
}

