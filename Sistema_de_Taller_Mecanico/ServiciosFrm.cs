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
    public partial class ServiciosFrm : Form
    {
        int servicio_id = 0;
        public ServiciosFrm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string precio_sugerido = txtPrecioS.Text;
            string tiempo_estimado = txtTiempoEst.Text;
            string activo;
            if (radioButton4.Checked)
            {
                activo = "Si";
            }
            else
            {
                activo = "No";
            }
            string tipo_servicio;
            if (radioButton1.Checked)
            {
                tipo_servicio = "Estandar";
            }
            else
            {
                tipo_servicio = "Personalizado";
            }
            bool resultado = false;
            if (servicio_id == 0)
                resultado = Servicio.Crear(codigo, nombre, descripcion, precio_sugerido, tiempo_estimado, activo, tipo_servicio);
            {
                // Aquí iría la lógica para actualizar un servicio existente
            }
            if (resultado)
            {
                MessageBox.Show("Servicio guardado exitosamente.");
                dataGridView1.DataSource = Servicio.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el servicio.");
            }
            dataGridView1.DataSource = Servicio.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioS.Text = "";
            txtTiempoEst.Text = "";
            gruActivo.Enabled = true;
            gruTipoServ.Enabled = true;
            servicio_id = 0;
            txtCodigo.Focus();
        }

        private void ServiciosFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servicio.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            txtPrecioS.Text = dataGridView1.CurrentRow.Cells["precio_sugerido"].Value.ToString();
            txtTiempoEst.Text = dataGridView1.CurrentRow.Cells["tiempo_estimado"].Value.ToString();
            string activo = dataGridView1.CurrentRow.Cells["activo"].Value.ToString();
            if (activo == "Si")
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
            string tipo_servicio = dataGridView1.CurrentRow.Cells["tipo_servicio"].Value.ToString();
            if (tipo_servicio == "Estandar")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            servicio_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Servicio.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Servicio eliminado exitosamente.");
                dataGridView1.DataSource = Servicio.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el servicio.");
            }
        }
    }
}
