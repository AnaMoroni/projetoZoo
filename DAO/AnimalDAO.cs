using aplicacaoZoologico.data;
using aplicacaoZoologico.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacaoZoologico.DAO
{
    internal class AnimalDAO
    {
        public void Salvar(Animal animal)
        {
            try
            {
                string sql = "INSERT INTO animal (nome_animal, especie, dataNascimento, sexo_animal, observacao_animal) VALUES (@nome_animal, @especie, @dataNascimento, @sexo_animal, @observacao_animal)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nome_animal", animal.nome_animal);
                comando.Parameters.AddWithValue("@especie", animal.especie);
                comando.Parameters.AddWithValue("@dataNascimento", animal.dataNascimento);
                comando.Parameters.AddWithValue("@sexo_animal", animal.sexo_animal);
                comando.Parameters.AddWithValue("@observacao_animal", animal.observacao_animal);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar o animal" + ex.Message);
            }

        }

        public void Deletar(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o animal" + ex.Message);
            }
        }
    }
}
