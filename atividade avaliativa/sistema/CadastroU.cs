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
    public partial class CadastroU : Form
    {
       
        public CadastroU()
        {
            InitializeComponent();
            
        }
         
        //Realiza o cadastro do usuario
        private void btnCadastrarC_Click(object sender, EventArgs e)
        {
            var user = new Model.Usuario();
            var valida = txtNomeCompletoC.Text != "" && txtSenhaC.Text != "" && txtEmailC.Text != "" ;
            // Variavel dataano recebe o ano de nascimento
            var dataano = int.Parse(mcNascimento.SelectionStart.ToString("yyyy"));
            // Variavel dataatual recebe a dataatual
            var dataatual = int.Parse(DateTime.Now.ToString("yyyy"));
            user.nome = txtNomeCompletoC.Text;
            user.senha = EasyEncryption.SHA.ComputeSHA256Hash(txtSenhaC.Text); 
            user.email = txtEmailC.Text;
            user.datanascimento = mcNascimento.SelectionStart.ToString("dd/MM/yyyy");

            //Se os campos não estiverem vazios se a senha1 for == a senha2, e se a idade for maior ou igual a 16 e menor que 120 o cadastro será realizado 
            if (valida && txtSenhaC.Text == txtSenha2.Text)
                {
               
                    if (dataatual - dataano >= 16 && dataatual - dataano < 120)
                    {
                        if (bd.UsuarioDao.Cadastrar(user))
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
                        MessageBox.Show(" A Idade não atende aos requisitos de cadastro!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique se os campos estão preenchidos");
                }
            
            
            
        }
    }
}
