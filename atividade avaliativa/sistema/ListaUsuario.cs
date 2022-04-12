using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_avaliativa.sistema
{
    public partial class ListaProdutos : Form
    {
        string emailLog, idProd, nomeP;
        public  ListaProdutos(string email)
        {
            InitializeComponent();
            this.emailLog = email;
            // Listar Produtos
            dgvLista.DataSource = bd.ProdutosDao.listarProduto();
            
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Botão que redireciona para cadastro de produto
        private void btnCadastrarP_Click(object sender, EventArgs e)
        {
            var frmCadastroP = new sistema.CadastrarP(emailLog);
            // ocultar a janela atual:
            this.Hide();

            // Mostrar a janela de Cadastro:
            frmCadastroP.ShowDialog();

            // Mostrar novamente a janela de login:
            this.Show();
        }

        //Botão que redireciona para editar produto
        private void btnEditarP_Click(object sender, EventArgs e)
        {
            if (idProd != null)
            {
                var frmEditarP = new sistema.EditarP(int.Parse(idProd));
                // ocultar a janela atual:
                this.Hide();

                // Mostrar a janela de Cadastro:
                frmEditarP.ShowDialog();

                // Mostrar novamente a janela de login:
                this.Show();

            }
            else
            {
                MessageBox.Show("Selecione um item para editar!");
            }
            
        }

        //Lista os produtos assim que o ususario retorna à tela de produtos cadastrados 
        private void ListaProdutos_Activated(object sender, EventArgs e)
        {
            dgvLista.DataSource = bd.ProdutosDao.listarProduto();
            //lblItemP.Text = "";
        }

        //Botão para retornar a tela de login
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botão de deletar um produto
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idProd != null)
            {
                var r = MessageBox.Show("Tem certeza que deseja remover o Produto " + nomeP + "?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    bd.ProdutosDao.Remover(idProd);
                    dgvLista.DataSource = bd.ProdutosDao.listarProduto();
                    MessageBox.Show("Item removido com sucesso!", "SUCESSO");
                    lblItemP.Text = "Selecione um item para remover.";
                    idProd = null;
                    nomeP = null;

                }
                else
                {
                    MessageBox.Show("O livro não foi removido!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para remover!");
            }
            
        }

        //Mostra um produto que o usuario clicou
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var numLinha = dgvLista.CurrentCell.RowIndex;
            var linha = dgvLista.Rows[numLinha];
            // Armazena o id  do produto 
            idProd = linha.Cells[0].Value.ToString();
            nomeP = linha.Cells[1].Value.ToString();
            lblItemP.Text = idProd + " - " + nomeP;
        }
    }
}
