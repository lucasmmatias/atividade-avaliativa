using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_avaliativa
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }

        //Botão para efetuar login no sistema
        private void btnLogar_Click(object sender, EventArgs e)
        {
            var user = new Model.Usuario();

            // Encriptar a senha em SHA256
            user.senha = EasyEncryption.SHA.ComputeSHA256Hash(txtSenha.Text);
            user.email = txtEmail.Text;
            
            if (bd.UsuarioDao.logar(user))
            {
                // Instanciar um objeto da janela Principal:
                var frmPrincipal = new sistema.ListaProdutos(user.email);
                // ocultar a janela atual:
                this.Hide();

                // Mostrar a janela principal:
                frmPrincipal.ShowDialog();

                // Mostrar novamente a janela de login:
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Invalidos");
            }

        }

        //Botão para abrir tela de cadastro
        private void btnCadastrarUU_Click(object sender, EventArgs e)
        {
           

            var frmCadastro = new sistema.CadastroU();
            // ocultar a janela atual:
            this.Hide();

            // Mostrar a janela de Cadastro:
            frmCadastro.ShowDialog();

            // Mostrar novamente a janela de login:
            this.Show();

        }
    }
}
