using aplicacaoZoologico.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacaoZoologico.models
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formulario = new FormCadastro();
            formulario.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAnimal.SelectedRows.Count > 0)
            {
                try
                {
                    int idAnimal = Convert.ToInt32(dgvAnimal.SelectedRows[0].Cells["id_animal"].Value);
                    DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este animal?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        AnimalDAO animalDAO = new AnimalDAO();
                        animalDAO.Deletar(idAnimal);

                        Form1 form1 = new Form1();
                        form1.CarregarDados();
                        MessageBox.Show("Animal deletado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar animal!" + ex.Message);
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvAnimal.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvAnimal.SelectedRows[0];
                 
                    if (row.Cells["dataNascimento"].Value == null || !(row.Cells["dataNascimento"].Value is DateTime))
                    {
                        MessageBox.Show("O valor da data de nascimento é inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   
                    
                    if (row.Cells["id_animal"].Value == null ||
                           row.Cells["nome_animal"].Value == null ||
                           row.Cells["especie"].Value == null ||
                           row.Cells["dataNascimento"].Value == null ||
                           row.Cells["sexo_animal"].Value == null ||
                           row.Cells["observacao_animal"].Value == null)
                           //row.Cells["id_habitat"].Value == null)
                          
                    {
                        MessageBox.Show("Dados incompletos na linha selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (row.Cells["dataNascimento"].Value == null || !(row.Cells["dataNascimento"].Value is DateTime))
                    {
                        MessageBox.Show("O valor da data de nascimento é inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                

                    Animal animal = new Animal
                    {
                        id_animal = Convert.ToInt32(row.Cells["id_animal"].Value),
                        nome_animal = row.Cells["nome_animal"].Value.ToString(),
                        especie = row.Cells["especie"].Value.ToString(),
                        dataNascimento = (DateTime)row.Cells["dataNascimento"].Value,
                        sexo_animal = row.Cells["sexo_animal"].Value.ToString(),
                        observacao_animal = row.Cells["observacao_animal"].Value.ToString(),
                        //id_habitat = Convert.ToInt32(row.Cells["id_habitat"].Value),

                    };
                  
                    FormEditar formEditar = new FormEditar(animal);
                    formEditar.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Selecione um animal para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception ex)
            {
                 throw new Exception("Erro ao carregar dados!" + ex.Message);
            }
        }

        private void dgvAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDgv();
            CarregarDados();
        }
        private void ConfigurarDgv()
        {
            dgvAnimal.AutoGenerateColumns=false;
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_animal",
                HeaderText = "id_animal",
            });
            
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nome_animal",
                HeaderText = "Nome",
            });
            
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "especie",
                HeaderText = "Especie",
            });
            
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "dataNascimento",
                HeaderText = "Data Nascimento",
            });
            
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sexo_animal",
                HeaderText = "Sexo",
            });
            
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "observacao_animal",
                HeaderText = "Observação",
            });
            
            dgvAnimal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_habitat",
                HeaderText = "Habitat",
            });
        }

        public void CarregarDados()
        {
            try
            {
                dgvAnimal.Rows.Clear();

                List<Animal> animais = new List<Animal>();
                AnimalDAO animalDAO = new AnimalDAO();
                animais = animalDAO.List();

                foreach (var item in animais) 
                {
                    dgvAnimal.Rows.Add(
                    item.id_animal,
                    item.nome_animal,
                    item.especie,
                    item.dataNascimento,
                    item.sexo_animal,
                    item.observacao_animal
                    //item.id_habitat
                    );
                }
                dgvAnimal.Columns["dataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex) 
            {
                throw new Exception("Erro ao carregar dados!" + ex.Message);
            }
        }
        private void dgvAnimal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        private void AtualizarGrid()
        {
            try
            {
              
                dgvAnimal.Rows.Clear();
                List<Animal> animais = new List<Animal>();
                AnimalDAO animalDAO = new AnimalDAO();

                animais = animalDAO.List();
                if (animais.Count == 0)
                {
                    MessageBox.Show("Nenhum animal cadastrado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var item in animais)
                {
                    dgvAnimal.Rows.Add(
                        item.id_animal,
                        item.nome_animal,
                        item.especie,
                        item.dataNascimento,
                        item.sexo_animal,
                        item.observacao_animal
                        //item.id_habitat
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
