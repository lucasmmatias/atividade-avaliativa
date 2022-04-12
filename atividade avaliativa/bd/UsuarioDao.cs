using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_avaliativa.bd
{

    public static class UsuarioDao
    {
        

        public static bool logar(Model.Usuario user)
        {
            Banco objBanco = new Banco();
            DataTable tabela = new DataTable();
            objBanco.conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "SELECT senha, email FROM usuario WHERE email = @email";

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            //da.SelectCommand.Parameters.AddWithValue("@nome", user.nome);
            //da.SelectCommand.Parameters.AddWithValue("@senha", user.senha);
            da.SelectCommand.Parameters.AddWithValue("@email", user.email);
            //da.SelectCommand.Parameters.AddWithValue("@datanascimento", user.datanascimento);
            da.Fill(tabela);

            objBanco.Desconectar();

            if (tabela.Rows.Count > 0)
            {

                var email = tabela.Rows[0]["email"].ToString();
                var senha = tabela.Rows[0]["senha"].ToString();


                if (user.email == email && user.senha == senha)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }
        }

            public static bool Cadastrar(Model.Usuario u)
        {
            Banco objBanco = new Banco();
            objBanco.conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "INSERT INTO usuario (email, nome, senha, datanascimento) VALUES (@nome, @email, @senha, @datanascimento)";
            // Substituir os @ por valores:
            cmd.Parameters.AddWithValue("@email", u.email);
            cmd.Parameters.AddWithValue("@nome", u.nome);
            cmd.Parameters.AddWithValue("@senha", u.senha);
            cmd.Parameters.AddWithValue("@datanascimento", u.datanascimento);        
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

        public static DataTable buscarPorEmail(string email)
        {
            Banco objBanco = new Banco();
            DataTable tabela = new DataTable();
            objBanco.conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "SELECT idusuario, nome, email, datanascimento FROM usuario WHERE email = @email";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            da.SelectCommand.Parameters.AddWithValue("email", email);
            da.Fill(tabela);
            objBanco.Desconectar();
            return tabela;
        }
    }
    
}
