namespace atividade_avaliativa
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTelaLogin = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnCadastrarUU = new System.Windows.Forms.Button();
            this.lblLeo = new System.Windows.Forms.Label();
            this.lblMatias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(68, 105);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(10, 105);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblTelaLogin
            // 
            this.lblTelaLogin.AutoSize = true;
            this.lblTelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaLogin.Location = new System.Drawing.Point(83, 9);
            this.lblTelaLogin.Name = "lblTelaLogin";
            this.lblTelaLogin.Size = new System.Drawing.Size(91, 33);
            this.lblTelaLogin.TabIndex = 6;
            this.lblTelaLogin.Text = "Login";
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(68, 140);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(123, 35);
            this.btnLogar.TabIndex = 7;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCadastrarUU
            // 
            this.btnCadastrarUU.Location = new System.Drawing.Point(68, 192);
            this.btnCadastrarUU.Name = "btnCadastrarUU";
            this.btnCadastrarUU.Size = new System.Drawing.Size(123, 42);
            this.btnCadastrarUU.TabIndex = 8;
            this.btnCadastrarUU.Text = "Cadastrar";
            this.btnCadastrarUU.UseVisualStyleBackColor = true;
            this.btnCadastrarUU.Click += new System.EventHandler(this.btnCadastrarUU_Click);
            // 
            // lblLeo
            // 
            this.lblLeo.AutoSize = true;
            this.lblLeo.Location = new System.Drawing.Point(37, 249);
            this.lblLeo.Name = "lblLeo";
            this.lblLeo.Size = new System.Drawing.Size(25, 13);
            this.lblLeo.TabIndex = 9;
            this.lblLeo.Text = "Leo";
            // 
            // lblMatias
            // 
            this.lblMatias.AutoSize = true;
            this.lblMatias.Location = new System.Drawing.Point(206, 249);
            this.lblMatias.Name = "lblMatias";
            this.lblMatias.Size = new System.Drawing.Size(38, 13);
            this.lblMatias.TabIndex = 10;
            this.lblMatias.Text = "Matias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 282);
            this.Controls.Add(this.lblMatias);
            this.Controls.Add(this.lblLeo);
            this.Controls.Add(this.btnCadastrarUU);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.lblTelaLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTelaLogin;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnCadastrarUU;
        private System.Windows.Forms.Label lblLeo;
        private System.Windows.Forms.Label lblMatias;
    }
}

