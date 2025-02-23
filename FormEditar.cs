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
            private Animal a;

            public FormEditar(Animal animal)
            {
            InitializeComponent();
            a = animal;
            CarregarDados(a);

            }
        public void CarregarDados(Animal a)
        {
            try
            {
                txtNome.Text = a.especie;
                txtEspecie.Text = a.especie;
                txtSexo.Text = a.sexo_animal;
                txtDataNasc.Text = a.dataNascimento.ToString("dd/mm/yyyy");
                txtObservacao.Text = a.observacao_animal;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar dados do animal selecionado!" + ex.Message);
            }
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
            Animal a = new Animal();
            a.nome_animal = txtNome.Text;
            a.especie = txtEspecie.Text;
            a.sexo_animal = txtSexo.Text;
            a.dataNascimento = Convert.ToDateTime(txtDataNasc.Text);
            a.observacao_animal = txtObservacao.Text;

            //gerarc objeto animal new animal e recebe animal 

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.Salvar(a);

            MessageBox.Show("Informações do animal editadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
