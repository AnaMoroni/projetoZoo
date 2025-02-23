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
            Animal a = new Animal();
            a.nome_animal = txtNome.Text; 
            a.especie = txtEspecie.Text;
            a.sexo_animal = txtSexo.Text;
            a.dataNascimento = Convert.ToDateTime(txtDataNasc.Text);
            a.observacao_animal=txtObservacao.Text;

            //gerarc objeto animal new animal e recebe animal 

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.Salvar(a);

            MessageBox.Show("Animal salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
