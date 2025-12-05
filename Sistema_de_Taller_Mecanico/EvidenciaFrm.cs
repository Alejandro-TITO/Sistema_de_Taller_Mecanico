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
    public partial class EvidenciaFrm : Form
    {
        int evidencia_id = 0;
        public EvidenciaFrm()
        {
            InitializeComponent();
        }

        private void EvidenciaFrm_Load(object sender, EventArgs e)
        {
            dgDatos.DataSource = Evidencia.Obtener();
            if (dgDatos.Columns.Count > 0)
            {
                dgDatos.Columns["id"].Visible = false;
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Value.ToString("yyyy-MM-dd");
            int id_orden = int.Parse(txtOrden.Text);
            bool resultado = false;
            if (evidencia_id == 0)
            {
                resultado = Evidencia.Crear(descripcion, fecha, id_orden);
            }
            if (resultado)
            {
                MessageBox.Show("Evidencia guardada exitosamente.");
                dgDatos.DataSource = Evidencia.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar la evidencia.");
            }
            dgDatos.DataSource = Evidencia.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
            txtOrden.Text = "";
            evidencia_id = 0;
            txtDescripcion.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = dgDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            txtOrden.Text = dgDatos.CurrentRow.Cells["orden"].Value.ToString();
            evidencia_id = int.Parse(dgDatos.CurrentRow.Cells["id"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgDatos.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Evidencia.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Evidencia eliminada exitosamente.");
                dgDatos.DataSource = Evidencia.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar la evidencia.");
            }
            dgDatos.DataSource = Evidencia.Obtener();
            limpiarCampos();
        }
    }
}
