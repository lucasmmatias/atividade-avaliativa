using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_avaliativa.bd
{
    internal class Banco
    {
        public SQLiteConnection conexao;
        public Banco()
        {
            //var caminhoAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            // Caminho do arquivo:
            var caminho = "banco.sqlite3";
            // String de conexão:
            conexao = new SQLiteConnection("Data Source= " + caminho);


        }
        public void conectar()
        {
            // Verificar se já não está conectado:
            if (conexao.State != ConnectionState.Open)
            {
                // Conectar
                conexao.Open();
            }
        }

        public void Desconectar()
        {
            // Verificar se já não está desconectado:
            if (conexao.State != ConnectionState.Closed)
            {
                // Desconectar:
                conexao.Close();
            }
        }
    }
}
