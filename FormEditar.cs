using aplicacaoZoologico.DAO;
using aplicacaoZoologico.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace aplicacaoZoologico
{

    public partial class FormEditar : Form
    {
        private Animal _animal;
        
        public FormEditar(Animal animal)
            {
            InitializeComponent();
            _animal = animal;

            
            txtNome.Text = _animal.nome_animal;
            txtEspecie.Text = _animal.especie;
            dtpDataNascimento.Value = _animal.dataNascimento;
            txtSexo.Text = _animal.sexo_animal;
            txtObservacao.Text = _animal.observacao_animal;
            //cbHabitat.Text = _animal.id_habitat.ToString();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                _animal.nome_animal = txtNome.Text;
                _animal.especie = txtEspecie.Text;
                _animal.dataNascimento = dtpDataNascimento.Value;
                _animal.sexo_animal = txtSexo.Text;
                _animal.observacao_animal = txtObservacao.Text;
               // _animal.id_habitat = cbHabitat.SelectedIndex + 1;

                // Chama o método para atualizar no banco de dados
                AnimalDAO animalDAO = new AnimalDAO();
                animalDAO.Atualizar(_animal);

                MessageBox.Show("Animal atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 form1 = new Form1();
                form1.CarregarDados();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o animal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
