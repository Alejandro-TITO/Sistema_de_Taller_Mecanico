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
    public partial class ClientesFrm : Form
    {
        int cliente_id = 0;
        public ClientesFrm()
        {
            InitializeComponent();
        }

        private void ClientesFrm_Load(object sender, EventArgs e)
        {
            dgdatos.DataSource = Clientes.Obtener();
            if (dgdatos.Columns.Count >0)
            {
                dgdatos.Columns["id"].Visible = false;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            //string fecha_registro = txtFechaRegistro.Text;
            string fecha_registro = txtFechaRegistro.Value.ToString("yyyy-MM-dd");
            bool resultado = false;
            if (cliente_id == 0)

                resultado = Clientes.Crear(dni, nombres, apellidos, telefono, correo, fecha_registro);
            {
                // Aquí iría la lógica para actualizar un cliente existente
            }
            if (resultado)
            {
                MessageBox.Show("Cliente guardado exitosamente.");
                dgdatos.DataSource = Clientes.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente.");
            }
            dgdatos.DataSource = Clientes.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtDni.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtFechaRegistro.Text = "";
            cliente_id = 0;
            txtDni.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = dgdatos.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgdatos.CurrentRow.Cells["Apellidos"].Value.ToString();
            txtDni.Text = dgdatos.CurrentRow.Cells["DNI"].Value.ToString();
            txtTelefono.Text = dgdatos.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dgdatos.CurrentRow.Cells["Correo"].Value.ToString();
            //txtFechaRegistro.Text = dgdatos.CurrentRow.Cells["Fecha_Registro"].Value.ToString();
            txtFechaRegistro.Value = Convert.ToDateTime(dgdatos.CurrentRow.Cells["Fecha_Registro"].Value.ToString());
            cliente_id = Convert.ToInt32(dgdatos.CurrentRow.Cells["ID"].Value.ToString());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgdatos.CurrentRow.Cells["ID"].Value.ToString());
            bool resultado = Clientes.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente eliminado exitosamente.");
                dgdatos.DataSource = Clientes.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.");
            }

        }

        private void txtFechaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
