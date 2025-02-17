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
            string nome = txtNome.Text;
            string especie = txtEspecie.Text;
            string sexo=txtSexo.Text;
            string dataNascimento = txtDataNasc.Text;
            string observacao=txtObservacao.Text;

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.Salvar(nome, especie, sexo, dataNascimento, observacao);
        }
    }
}
