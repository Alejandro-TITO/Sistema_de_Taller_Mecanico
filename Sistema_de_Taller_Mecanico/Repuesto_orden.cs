using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico
{
    public partial class Repuesto_orden : Form
    {
        int repuesto_orden_id = 0;
        public Repuesto_orden()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cantidad = txtCantidad.Text;
            string precio_unitario = txtPrecioU.Text;
            string precio_total = txtPrecioT.Text;
            string orden = txtOrden.Text;
            string repuesto = txtRepuesto.Text;
            bool resultado = false;
            resultado = Modelos.Repuesto_Orden.Crear(cantidad, precio_unitario, precio_total, orden, repuesto);
            if (resultado)
            {
                MessageBox.Show("Repuesto orden guardado exitosamente.");
                // Actualizar el DataGridView si es necesario
            }
            else
            {
                MessageBox.Show("Error al guardar el repuesto orden.");
            }
        }
        private void limpiarCampos()
        {
            txtCantidad.Text = "";
            txtPrecioU.Text = "";
            txtPrecioT.Text = "";
            txtOrden.Text = "";
            txtRepuesto.Text = "";
            repuesto_orden_id = 0;
            txtCantidad.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
            txtPrecioU.Text = dataGridView1.CurrentRow.Cells["precio_unitario"].Value.ToString();
            txtPrecioT.Text = dataGridView1.CurrentRow.Cells["precio_total"].Value.ToString();
            txtOrden.Text = dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString();
            txtRepuesto.Text = dataGridView1.CurrentRow.Cells["id_repuesto"].Value.ToString();
            repuesto_orden_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Modelos.Repuesto_Orden.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Repuesto orden eliminado exitosamente.");
                dataGridView1.DataSource = Modelos.Repuesto_Orden.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el repuesto orden.");
            }
        }

        private void Repuesto_orden_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelos.Repuesto_Orden.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }
    }
}
