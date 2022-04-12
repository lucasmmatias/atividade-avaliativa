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
    public partial class CadastrarP : Form
    {
        string emailLog;
        public CadastrarP(string email)
        {
            InitializeComponent();
            this.emailLog = email;
        }
        //Botão para realiza o cadastro de um produto
        private void btnCP_Click(object sender, EventArgs e)
        {
            var p = new Model.Produto();
            var validaP = txtNomeP.Text != "" && txtEstoque.Text != "" && txtPrecoP.Text != "";
            p.nome = txtNomeP.Text;
            p.estoque = txtEstoque.Text;
            p.preco = txtPrecoP.Text;

            if (validaP)
            {
                //Passa as informações dos produtos e o email do usuario logado, e se der certo o cadastro sera realizado
                if (bd.ProdutosDao.CadastrarP(p, emailLog))
                {                   
                    
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Verifique se os dados estão corretos");
                }
            }
            else
            {
                MessageBox.Show("Verifique se os campos estão preenchidos!");
            }

            
        }

        private void dgvProdutosCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadastrarP_Load(object sender, EventArgs e)
        {

        }
    }
}
