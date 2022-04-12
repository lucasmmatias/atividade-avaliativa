namespace atividade_avaliativa.sistema
{
    partial class ListaProdutos
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnCadastrarP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblItemP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(63, 27);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(678, 236);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // btnCadastrarP
            // 
            this.btnCadastrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarP.Location = new System.Drawing.Point(63, 293);
            this.btnCadastrarP.Name = "btnCadastrarP";
            this.btnCadastrarP.Size = new System.Drawing.Size(162, 43);
            this.btnCadastrarP.TabIndex = 1;
            this.btnCadastrarP.Text = "Cadastrar Produto";
            this.btnCadastrarP.UseVisualStyleBackColor = true;
            this.btnCadastrarP.Click += new System.EventHandler(this.btnCadastrarP_Click);
            // 
            // btnEditarP
            // 
            this.btnEditarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.Location = new System.Drawing.Point(313, 293);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(159, 43);
            this.btnEditarP.TabIndex = 2;
            this.btnEditarP.Text = "Editar Produtos";
            this.btnEditarP.UseVisualStyleBackColor = true;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(563, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar Produto";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblItemP
            // 
            this.lblItemP.AutoSize = true;
            this.lblItemP.Location = new System.Drawing.Point(563, 353);
            this.lblItemP.Name = "lblItemP";
            this.lblItemP.Size = new System.Drawing.Size(158, 13);
            this.lblItemP.TabIndex = 4;
            this.lblItemP.Text = "Selecione um item para remover";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(566, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(162, 40);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblItemP);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.btnCadastrarP);
            this.Controls.Add(this.dgvLista);
            this.Name = "ListaProdutos";
            this.Text = "ListaProdutos";
            this.Activated += new System.EventHandler(this.ListaProdutos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnCadastrarP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblItemP;
        private System.Windows.Forms.Button btnSair;
    }
}