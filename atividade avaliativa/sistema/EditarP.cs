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
    public partial class EditarP : Form
    {
        // Pega o id do produto que foi passado para EditarP
        int idProd;
        public EditarP(int id)
        {
            InitializeComponent();
            this.idProd = id;
        }
        // Botão que realiza a edição de um produto
        private void btnEP_Click(object sender, EventArgs e)
        {
            var p = new Model.Produto();
            var validaEdit = txtNomePEdi.Text != "" && txtEstoqueEdi.Text != "" && txtPrecoPEdi.Text != "";
            p.nome = txtNomePEdi.Text;
            p.preco = txtPrecoPEdi.Text;
            p.estoque = txtEstoqueEdi.Text;

            if (validaEdit)
            {
                // Passa as informações e o id do produto que sera editado
                if (bd.ProdutosDao.Editar(idProd, p))
                {
                    MessageBox.Show("Produto editado com sucesso!");

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Verifique se os dados estão corretos");
                }
            }
            else
            {
                MessageBox.Show("Verifique se os campos estão Preenchidos!");
            }
            

        }
    }
}
