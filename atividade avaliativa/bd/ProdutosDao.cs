using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_avaliativa.bd
{
    public class ProdutosDao
    {
        public static DataTable listarProduto()
        {
            // Instanciar o classe de conexão com o bd:
            Banco objBanco = new Banco();
            // Criar a "tabela" que será preenchida com os dados do BD:
            DataTable tabela = new DataTable();
            // Conectar com o banco:
            objBanco.conectar();
            // Criar um objeto do tipo SQLiteCommand:
            var cmd = objBanco.conexao.CreateCommand();
            // Qual comando SQL será executado:
            cmd.CommandText = "SELECT p.codbarras, p.nome, p.preco, p.estoque, u.nome AS Responsavel FROM produtos AS p INNER JOIN usuario AS u ON p.idresponsavel = u.idusuario ";
            // Executar e obter os dados da consulta em um obj SQLiteDA:
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            // Preencher uma "tabela" com os dados retornados do BD:
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();
            // Devolver a tabela preenchida para quem chamar este método:
            return tabela;
        }

        public static bool CadastrarP(Model.Produto p , string email)
        {
            var user = bd.UsuarioDao.buscarPorEmail(email);
            var idresp = user.Rows[0]["idusuario"].ToString();
            Banco objBanco = new Banco();
            objBanco.conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "INSERT INTO produtos (nome, preco, estoque, idresponsavel) VALUES (@nome, @preco, @estoque,@idresponsavel)";
            // Substituir os @ por valores:
            cmd.Parameters.AddWithValue("@preco", p.preco);
            cmd.Parameters.AddWithValue("@nome", p.nome);
            cmd.Parameters.AddWithValue("@estoque", p.estoque);
            cmd.Parameters.AddWithValue("@idresponsavel", idresp);

            // Executar:


            //try
            //{
            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar:
            objBanco.Desconectar();
            return true;
            //}
            //catch
            //{
            //    objBanco.Desconectar();
            //    return false;
            //}
        }

        public static void Remover(string idProd)
        {
            Banco objBanco = new Banco();
            objBanco.conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "DELETE FROM produtos WHERE  codbarras = @idprod";
            // Substituir os @ por valores:
            cmd.Parameters.AddWithValue("@idprod", idProd);

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar:
            objBanco.Desconectar();

        }

        public static bool Editar(int idProd, Model.Produto p)
        {
            Banco objBanco = new Banco();
            objBanco.conectar();
            var cmd = objBanco.conexao.CreateCommand();
            // Verificar se a senha não foi setada:
            
                // Comando SQL para atualizar todos os valores, exceto a senha:
                cmd.CommandText = "UPDATE produtos SET nome = @nome, preco = @preco, estoque = @estoque  WHERE codbarras = @id";
                // Substituir os @ por valores:              
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@preco", p.preco);
                cmd.Parameters.AddWithValue("@estoque",p.estoque);             
                cmd.Parameters.AddWithValue("@id", idProd);
           

              // Executar:
              cmd.ExecuteNonQuery();
              // Desconectar:
              objBanco.Desconectar();
             return true;
        }


    }
}
