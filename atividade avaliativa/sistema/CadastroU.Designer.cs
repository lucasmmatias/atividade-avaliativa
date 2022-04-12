namespace atividade_avaliativa.sistema
{
    partial class CadastroU
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCompletoC = new System.Windows.Forms.TextBox();
            this.btnCadastrarC = new System.Windows.Forms.Button();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtSenhaC = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.mcNascimento = new System.Windows.Forms.MonthCalendar();
            this.lblResultData = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txtNomeCompletoC
            // 
            this.txtNomeCompletoC.Location = new System.Drawing.Point(133, 42);
            this.txtNomeCompletoC.Name = "txtNomeCompletoC";
            this.txtNomeCompletoC.Size = new System.Drawing.Size(164, 20);
            this.txtNomeCompletoC.TabIndex = 1;
            // 
            // btnCadastrarC
            // 
            this.btnCadastrarC.Location = new System.Drawing.Point(106, 365);
            this.btnCadastrarC.Name = "btnCadastrarC";
            this.btnCadastrarC.Size = new System.Drawing.Size(139, 39);
            this.btnCadastrarC.TabIndex = 2;
            this.btnCadastrarC.Text = "Cadastrar";
            this.btnCadastrarC.UseVisualStyleBackColor = true;
            this.btnCadastrarC.Click += new System.EventHandler(this.btnCadastrarC_Click);
            // 
            // txtEmailC
            // 
            this.txtEmailC.Location = new System.Drawing.Point(133, 76);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(166, 20);
            this.txtEmailC.TabIndex = 4;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(73, 77);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 16);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail:";
            // 
            // txtSenhaC
            // 
            this.txtSenhaC.Location = new System.Drawing.Point(133, 108);
            this.txtSenhaC.Name = "txtSenhaC";
            this.txtSenhaC.Size = new System.Drawing.Size(164, 20);
            this.txtSenhaC.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(72, 109);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(19, 166);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(114, 16);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data Nascimento:";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(71, 9);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(115, 25);
            this.lblCadastrar.TabIndex = 9;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // mcNascimento
            // 
            this.mcNascimento.Location = new System.Drawing.Point(18, 191);
            this.mcNascimento.Name = "mcNascimento";
            this.mcNascimento.TabIndex = 10;
            // 
            // lblResultData
            // 
            this.lblResultData.AutoSize = true;
            this.lblResultData.Location = new System.Drawing.Point(518, 259);
            this.lblResultData.Name = "lblResultData";
            this.lblResultData.Size = new System.Drawing.Size(40, 13);
            this.lblResultData.TabIndex = 11;
            this.lblResultData.Text = ".    .    .";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(133, 134);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(166, 20);
            this.txtSenha2.TabIndex = 13;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha2.Location = new System.Drawing.Point(15, 134);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(112, 16);
            this.lblSenha2.TabIndex = 12;
            this.lblSenha2.Text = "Confirmar  Senha:";
            // 
            // CadastroU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 434);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.lblResultData);
            this.Controls.Add(this.mcNascimento);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtSenhaC);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmailC);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnCadastrarC);
            this.Controls.Add(this.txtNomeCompletoC);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroU";
            this.Text = "CadastroU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCompletoC;
        private System.Windows.Forms.Button btnCadastrarC;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtSenhaC;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.MonthCalendar mcNascimento;
        private System.Windows.Forms.Label lblResultData;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblSenha2;
    }
}