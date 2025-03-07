using aplicacaoZoologico.data;
using aplicacaoZoologico.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacaoZoologico.DAO
{
    internal class AnimalDAO : IDAO
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
                //comando.Parameters.AddWithValue("@id_habitat", animal.id_habitat);

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
                string sql = "DELETE FROM animal WHERE id_animal = @id_animal";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_animal", id);

                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o animal" + ex.Message);
            }
        }
        public void Atualizar(Animal animal)
        {
            try
            {
                
                string sql = "UPDATE animal SET nome_animal = @nome_animal, especie = @especie, dataNascimento = @dataNascimento, sexo_animal = @sexo_animal, observacao_animal =  @observacao_animal WHERE id_animal = @id_animal";
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@nome_animal", animal.nome_animal);
                command.Parameters.AddWithValue("@especie", animal.especie);
                command.Parameters.AddWithValue("@dataNascimento", animal.dataNascimento);
                command.Parameters.AddWithValue("@sexo_animal", animal.sexo_animal);
                command.Parameters.AddWithValue("@observacao_animal", animal.observacao_animal);
                //command.Parameters.AddWithValue("@id_habitat", animal.id_habitat);
                command.Parameters.AddWithValue("@id_animal", animal.id_animal);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar os dados do animal!" + ex.Message);
            }
        }
        public List<Animal> List()
        {
            List<Animal> animais = new List<Animal>();

            try
            {
                var sql = "SELECT * FROM animal ORDER BY nome_animal";
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.ExecuteNonQuery();

                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Animal animal = new Animal
                        {
                            id_animal = dr.IsDBNull(dr.GetOrdinal("id_animal")) ? 0 : dr.GetInt32("id_animal"),
                            nome_animal = dr.IsDBNull(dr.GetOrdinal("nome_animal")) ? string.Empty : dr.GetString("nome_animal"),
                            especie = dr.IsDBNull(dr.GetOrdinal("especie")) ? string.Empty : dr.GetString("especie"),
                            dataNascimento = dr.IsDBNull(dr.GetOrdinal("dataNascimento")) ? DateTime.MinValue : dr.GetDateTime("dataNascimento"),
                            sexo_animal = dr.IsDBNull(dr.GetOrdinal("sexo_animal")) ? string.Empty : dr.GetString("sexo_animal"),
                            observacao_animal = dr.IsDBNull(dr.GetOrdinal("observacao_animal")) ? string.Empty : dr.GetString("observacao_animal"),
                            //id_habitat = dr.IsDBNull(dr.GetOrdinal("id_habitat")) ? 0 : dr.GetInt32("id_habitat")
                        };
                        

                        animais.Add(animal);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar todos os animais cadastrados! " + ex.Message);
            }
          
            return animais;
        }
        public Animal BuscarId(int id)
        {
            Animal animal = null;
            try
            {
                string sql = "SELECT * FROM animal WHERE id_animal = @id_animal";
                MySqlCommand command = new MySqlCommand(sql, Conexao.Conectar());
                command.Parameters.AddWithValue("@id_animal", id); 

                MySqlDataReader dr = command.ExecuteReader();

                if (dr.Read()) 
                {
                    animal = new Animal
                    {
                        id_animal = dr.GetInt32("id_animal"),
                        nome_animal = dr.GetString("nome_animal"),
                        especie = dr.GetString("especie"),
                        dataNascimento = dr.GetDateTime("dataNascimento"),
                        sexo_animal = dr.GetString("sexo_animal"),
                        observacao_animal = dr.GetString("observacao_animal"),
                    };
                }

                dr.Close(); 

                return animal;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar pelo id selecionado: " + ex.Message);
            }
        }

    }   
}
