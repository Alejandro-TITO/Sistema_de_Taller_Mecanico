using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Taller_Mecanico.Modelos;

namespace Sistema_de_Taller_Mecanico
{
    public partial class RepuestosFrm : Form
    {
        int repuesto_id = 0;
        public RepuestosFrm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
            txtMarca.Text = dataGridView1.CurrentRow.Cells["marca_id"].Value.ToString();
            repuesto_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string stock = txtStock.Text;
            string precio = txtPrecio.Text;
            string marca_id = txtMarca.Text;
            bool resultado = false;
            if (repuesto_id == 0)
                resultado = Repuestos.Crear(codigo, nombre, descripcion, stock, precio, marca_id);
            {
                // Aquí iría la lógica para actualizar un repuesto existente
            }
            if (resultado)
            {
                MessageBox.Show("Repuesto guardado exitosamente.");
                dataGridView1.DataSource = Repuestos.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el repuesto.");
            }
            dataGridView1.DataSource = Repuestos.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtMarca.Text = "";
            repuesto_id = 0;
            txtCodigo.Focus();
        }
        private void RepuestosFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Repuestos.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Repuestos.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Repuesto eliminado exitosamente.");
                dataGridView1.DataSource = Repuestos.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el repuesto.");
            }
        }
    }
}
