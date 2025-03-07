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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal a = new Animal();
                a.nome_animal = txtNome.Text;
                a.especie = txtEspecie.Text;
                a.dataNascimento = dtpDataNascimento.Value;
                a.sexo_animal = txtSexo.Text;
                a.observacao_animal = txtObservacao.Text;
                //a.id_habitat = cbHabitat.Text;


                AnimalDAO animalDAO = new AnimalDAO();
                animalDAO.Salvar(a);

                MessageBox.Show("Animal salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.CarregarDados();
                this.Close(); 


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
