namespace MyMetasBeta
{
    partial class TelaLogin
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(284, 127);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(201, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(284, 195);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(201, 22);
            this.textBoxSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(284, 240);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(82, 28);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(405, 240);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(80, 28);
            this.btnCadastrarUsuario.TabIndex = 3;
            this.btnCadastrarUsuario.Text = "Concluir";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(284, 107);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 16);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(284, 176);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 497);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
    }
}

