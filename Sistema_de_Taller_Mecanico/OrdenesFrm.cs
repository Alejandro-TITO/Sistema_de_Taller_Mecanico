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
    public partial class OrdenesFrm : Form
    {
        int orden_id = 0;
        public OrdenesFrm()
        {
            InitializeComponent();
        }

        private void OrdenesFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ordene.Obtener();
            comboBox1.DataSource = Vehiculo.Obtener();
            comboBox1.DisplayMember = "placa";
            comboBox1.ValueMember = "id_vehiculo";
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["id_vehiculo"].Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string numero_orden = txtNumeroO.Text;
            string fecha_ingreso = txtFechaI.Value.ToString("yyyy-MM-dd");
            string diagnostico_inicial = txtDiagnosticoI.Text;
            string observacion_cliente = txtObservacionC.Text;
            string estado = txtEstado.Text;
            string mano_obra = txtManoO.Text;
            string total_repuestos = txtTotalR.Text;
            string precio_estimado = txtPrecioE.Text;
            string fecha_entrega = txtFechaE.Value.ToString("yyyy-MM-dd");
            //string id_vehiculo = txtVehiculo.Text;
            int id_vehiculo = Convert.ToInt32(comboBox1.SelectedValue);
            bool resultado = false;
            if (orden_id == 0)
                resultado = Ordene.Crear(numero_orden, fecha_ingreso, diagnostico_inicial, observacion_cliente, estado, mano_obra, total_repuestos, precio_estimado, fecha_entrega, id_vehiculo);
            {
                // Aquí iría la lógica para actualizar una orden existente
            }
            if (resultado)
            {
                MessageBox.Show("Orden guardada exitosamente.");
                dataGridView1.DataSource = Ordene.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar la orden.");
            }
            dataGridView1.DataSource = Ordene.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNumeroO.Text = "";
            txtDiagnosticoI.Text = "";
            txtObservacionC.Text = "";
            txtEstado.Text = "";
            txtManoO.Text = "";
            txtTotalR.Text = "";
            txtPrecioE.Text = "";    
            
            orden_id = 0;
            txtNumeroO.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNumeroO.Text = dataGridView1.CurrentRow.Cells["numero_orden"].Value.ToString();
            txtFechaI.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_ingreso"].Value.ToString());
            txtDiagnosticoI.Text = dataGridView1.CurrentRow.Cells["diagnostico_inicial"].Value.ToString();
            txtObservacionC.Text = dataGridView1.CurrentRow.Cells["observacion_cliente"].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            txtManoO.Text = dataGridView1.CurrentRow.Cells["mano_obra"].Value.ToString();
            txtTotalR.Text = dataGridView1.CurrentRow.Cells["total_repuestos"].Value.ToString();
            txtPrecioE.Text = dataGridView1.CurrentRow.Cells["precio_estimado"].Value.ToString();
            txtFechaE.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_entrega"].Value.ToString());
            //txtVehiculo.Text = dataGridView1.CurrentRow.Cells["id_vehiculo"].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells["id_vehiculo"].Value.ToString();
            orden_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Ordene.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Orden eliminada exitosamente.");
                dataGridView1.DataSource = Ordene.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar la orden.");
            }
        }
    }
}
