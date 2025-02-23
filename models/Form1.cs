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
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formulario = new FormCadastro();
            formulario.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int idAnimal = Convert.ToInt32(dgvAnimal.SelectedRows[0].Cells["id_animal"].Value);
            AnimalDAO animalDAO = new AnimalDAO();
            Animal animal = animalDAO.BuscarId(idAnimal);

            if (animal != null)
            {
                
                FormEditar formEditar = new FormEditar(animal);
                formEditar.ShowDialog(); 
            }else
            {
                Console.WriteLine("Registro não encontrado no banco!");
            }
        }

        private void dgvAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            List<Animal> animais = animalDAO.List();
            dgvAnimal.DataSource = animais;
        }
    }
}
