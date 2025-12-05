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
    public partial class MecanicosFrm : Form
    {
        int mecanico_id = 0;
        public MecanicosFrm()
        {
            InitializeComponent();
        }

        private void MecanicosFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelos.Mecanico.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string fecha_ingreso = txtFechaI.Value.ToString("yyyy-MM-dd");
            string estado;
            if (radioButtonActivo.Checked)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
            }

            string especialidades = txtEspecialidades.Text;
            bool resultado = false;
            if (mecanico_id == 0)
            {
                resultado = Modelos.Mecanico.Crear(nombres, apellidos, telefono, fecha_ingreso, estado, especialidades);
            }
            if (resultado)
            {
                MessageBox.Show("Mecánico guardado exitosamente.");
                dataGridView1.DataSource = Modelos.Mecanico.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el mecánico.");
            }
            dataGridView1.DataSource = Modelos.Mecanico.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtFechaI.Value = DateTime.Now;
            groupBox1.Text = "";
            txtEspecialidades.Text = "";
            mecanico_id = 0;
            txtNombres.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = dataGridView1.CurrentRow.Cells["nombres"].Value.ToString();
            txtApellidos.Text = dataGridView1.CurrentRow.Cells["apellidos"].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            txtFechaI.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["fecha_ingreso"].Value.ToString());
            string estado = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            if (estado == "Activo")
            {
                radioButtonActivo.Checked = true;
            }
            else
            {
                radioButtonInactivo.Checked = true;
            }
            txtEspecialidades.Text = dataGridView1.CurrentRow.Cells["especialidades"].Value.ToString();
            txtNombres.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Modelos.Mecanico.eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Mecánico eliminado exitosamente.");
                dataGridView1.DataSource = Modelos.Mecanico.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el mecánico.");
            }
        }
    }
}
