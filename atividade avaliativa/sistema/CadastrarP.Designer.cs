namespace atividade_avaliativa.sistema
{
    partial class CadastrarP
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
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.txtPrecoP = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnCP = new System.Windows.Forms.Button();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(28, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(89, 65);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(149, 20);
            this.txtNomeP.TabIndex = 1;
            // 
            // txtPrecoP
            // 
            this.txtPrecoP.Location = new System.Drawing.Point(89, 98);
            this.txtPrecoP.Name = "txtPrecoP";
            this.txtPrecoP.Size = new System.Drawing.Size(149, 20);
            this.txtPrecoP.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(28, 98);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 20);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(89, 133);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(145, 20);
            this.txtEstoque.TabIndex = 7;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(9, 133);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(73, 20);
            this.lblEstoque.TabIndex = 6;
            this.lblEstoque.Text = "Estoque:";
            // 
            // btnCP
            // 
            this.btnCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCP.Location = new System.Drawing.Point(89, 172);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(145, 31);
            this.btnCP.TabIndex = 8;
            this.btnCP.Text = "Cadastrar Produtos";
            this.btnCP.UseVisualStyleBackColor = true;
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.Location = new System.Drawing.Point(65, 25);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(156, 20);
            this.lblCadastroProduto.TabIndex = 9;
            this.lblCadastroProduto.Text = "Cadastrar Produto";
            // 
            // CadastrarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 244);
            this.Controls.Add(this.lblCadastroProduto);
            this.Controls.Add(this.btnCP);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtPrecoP);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastrarP";
            this.Text = "CadastrarP";
            this.Load += new System.EventHandler(this.CadastrarP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.TextBox txtPrecoP;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnCP;
        private System.Windows.Forms.Label lblCadastroProduto;
    }
}