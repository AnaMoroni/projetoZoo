using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacaoZoologico.data
{
    internal class Conexao
    {

        static MySqlConnection conexao;
        static string strconexao = "server=localhost;Port=3306;uid=root;pwd=root;database=Zoologico";

        public static MySqlConnection Conectar()
        {
            try
            {
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                Console.WriteLine("Conexão realizada com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar conectar" + ex.Message);
            }
        }
    }
}
