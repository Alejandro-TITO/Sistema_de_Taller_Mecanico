using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Taller_Mecanico;
using Sistema_de_Taller_Mecanico.Modelos;

namespace Sistema_de_Taller_Mecanico
{
    public partial class MarcasFrm : Form
    {
        int marca_id = 0;
        public MarcasFrm()
        {
            InitializeComponent();
        }

        private void MarcasFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Marcas.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;

            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            bool resultado = false;
            if (marca_id == 0)

                resultado = Marcas.Crear(marca);
              
            if (resultado)
            {
                MessageBox.Show("Marca guardada exitosamente.");
                dataGridView1.DataSource = Marcas.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar la Marca.");
            }
            dataGridView1.DataSource = Marcas.Obtener();
            limpiarCampos();
        }
        public void limpiarCampos()
        {
            txtMarca.Text = "";
            marca_id = 0;
            txtMarca.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMarca.Text = dataGridView1.CurrentRow.Cells["marca"].Value.ToString();
            marca_id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Marcas.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Marca eliminada exitosamente.");
                dataGridView1.DataSource = Marcas.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar la Marca.");
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }  }

