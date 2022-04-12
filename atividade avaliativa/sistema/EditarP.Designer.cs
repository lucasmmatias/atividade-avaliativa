namespace atividade_avaliativa.sistema
{
    partial class EditarP
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
            this.btnEP = new System.Windows.Forms.Button();
            this.txtEstoqueEdi = new System.Windows.Forms.TextBox();
            this.lblEstoqueEdi = new System.Windows.Forms.Label();
            this.txtPrecoPEdi = new System.Windows.Forms.TextBox();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.txtNomePEdi = new System.Windows.Forms.TextBox();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.lblEdiProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEP
            // 
            this.btnEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEP.Location = new System.Drawing.Point(89, 130);
            this.btnEP.Name = "btnEP";
            this.btnEP.Size = new System.Drawing.Size(128, 35);
            this.btnEP.TabIndex = 15;
            this.btnEP.Text = "Editar Produto";
            this.btnEP.UseVisualStyleBackColor = true;
            this.btnEP.Click += new System.EventHandler(this.btnEP_Click);
            // 
            // txtEstoqueEdi
            // 
            this.txtEstoqueEdi.Location = new System.Drawing.Point(97, 78);
            this.txtEstoqueEdi.Name = "txtEstoqueEdi";
            this.txtEstoqueEdi.Size = new System.Drawing.Size(139, 20);
            this.txtEstoqueEdi.TabIndex = 14;
            // 
            // lblEstoqueEdi
            // 
            this.lblEstoqueEdi.AutoSize = true;
            this.lblEstoqueEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueEdi.Location = new System.Drawing.Point(18, 76);
            this.lblEstoqueEdi.Name = "lblEstoqueEdi";
            this.lblEstoqueEdi.Size = new System.Drawing.Size(73, 20);
            this.lblEstoqueEdi.TabIndex = 13;
            this.lblEstoqueEdi.Text = "Estoque:";
            // 
            // txtPrecoPEdi
            // 
            this.txtPrecoPEdi.Location = new System.Drawing.Point(89, 104);
            this.txtPrecoPEdi.Name = "txtPrecoPEdi";
            this.txtPrecoPEdi.Size = new System.Drawing.Size(147, 20);
            this.txtPrecoPEdi.TabIndex = 12;
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEdi.Location = new System.Drawing.Point(29, 104);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(54, 20);
            this.lblPrecoEdi.TabIndex = 11;
            this.lblPrecoEdi.Text = "Preço:";
            // 
            // txtNomePEdi
            // 
            this.txtNomePEdi.Location = new System.Drawing.Point(89, 52);
            this.txtNomePEdi.Name = "txtNomePEdi";
            this.txtNomePEdi.Size = new System.Drawing.Size(147, 20);
            this.txtNomePEdi.TabIndex = 10;
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdi.Location = new System.Drawing.Point(28, 52);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(55, 20);
            this.lblNomeEdi.TabIndex = 9;
            this.lblNomeEdi.Text = "Nome:";
            // 
            // lblEdiProduto
            // 
            this.lblEdiProduto.AutoSize = true;
            this.lblEdiProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdiProduto.Location = new System.Drawing.Point(60, 20);
            this.lblEdiProduto.Name = "lblEdiProduto";
            this.lblEdiProduto.Size = new System.Drawing.Size(125, 20);
            this.lblEdiProduto.TabIndex = 16;
            this.lblEdiProduto.Text = "Editar Produto";
            // 
            // EditarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 209);
            this.Controls.Add(this.lblEdiProduto);
            this.Controls.Add(this.btnEP);
            this.Controls.Add(this.txtEstoqueEdi);
            this.Controls.Add(this.lblEstoqueEdi);
            this.Controls.Add(this.txtPrecoPEdi);
            this.Controls.Add(this.lblPrecoEdi);
            this.Controls.Add(this.txtNomePEdi);
            this.Controls.Add(this.lblNomeEdi);
            this.Name = "EditarP";
            this.Text = "EditarP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEP;
        private System.Windows.Forms.TextBox txtEstoqueEdi;
        private System.Windows.Forms.Label lblEstoqueEdi;
        private System.Windows.Forms.TextBox txtPrecoPEdi;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.TextBox txtNomePEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.Label lblEdiProduto;
    }
}