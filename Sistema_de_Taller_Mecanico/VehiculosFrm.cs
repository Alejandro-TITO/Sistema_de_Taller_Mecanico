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
    public partial class VehiculosFrm : Form
    {
        int vehiculo_id = 0;
        public VehiculosFrm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VehiculosFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Vehiculo.Obtener();
            cbClientes.DataSource = Clientes.Obtener();
            cbClientes.DisplayMember = "nombres";
            cbClientes.ValueMember = "id";

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["id_cliente"].Visible = false;
                dataGridView1.Columns["marca_id"].Visible = false;
            }
        }

        private void get_tipo_motor(string tipo_motor)
        {
            if (tipo_motor == "Gasolina")
            {
                radioButton1.Checked = true;
            }
            else if (tipo_motor == "Diesel")
            {
                radioButton2.Checked = true;
            }
            else if (tipo_motor == "Gas")
            {
                radioButton3.Checked = true;
            }
            else if (tipo_motor == "Electrico")
            {
                radioButton4.Checked = true;
            }
            else if (tipo_motor == "Hibrido")
            {
                radioButton5.Checked = true;
            }
            else
            {
                radioButton6.Checked = true;
            }
        }

        private string set_tipo_motor()
        {
            string tipo_motor;
            if (radioButton1.Checked)
            {
                tipo_motor = "Gasolina";
            }
            else if (radioButton2.Checked)
            {
                tipo_motor = "Diesel";
            }
            else if (radioButton3.Checked)
            {
                tipo_motor = "Gas";
            }
            else if (radioButton4.Checked)
            {
                tipo_motor = "Electrico";
            }
            else if (radioButton5.Checked)
            {
                tipo_motor = "Hibrido";
            }
            else
            {
                tipo_motor = "Otros";
            }

            return tipo_motor;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string modelo = txtModelo.Text;
            string anio = txtAnio.Text;
            string tipo_motor = this.set_tipo_motor();
            string kilometraje = txtkm.Text;
            string fecha_registro = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //string id_cliente = txtCliente.Text;
            int id_cliente = Convert.ToInt32(cbClientes.SelectedValue);
            string marca_id = "";
            //string marca_id = txtMarca.Text;
            bool resultado = false;
            if (vehiculo_id == 0)
                resultado = Vehiculo.Crear(placa, modelo, anio, tipo_motor, kilometraje, fecha_registro, id_cliente, marca_id);
            {
                // Aquí iría la lógica para actualizar un vehiculo existente
            }
            if (resultado)
            {
                MessageBox.Show("Vehículo guardado exitosamente.");
                dataGridView1.DataSource = Vehiculo.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el vehículo.");
            }
            dataGridView1.DataSource = Vehiculo.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtAnio.Text = "";
            groupBox1.Enabled = true;
            txtkm.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            //txtCliente.Text = "";
            //txtMarca.Text = "";
            vehiculo_id = 0;
            txtPlaca.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtPlaca.Text = dataGridView1.CurrentRow.Cells["placa"].Value.ToString();
            txtModelo.Text = dataGridView1.CurrentRow.Cells["modelo"].Value.ToString();
            txtAnio.Text = dataGridView1.CurrentRow.Cells["anio"].Value.ToString();
            string tipo_motor = dataGridView1.CurrentRow.Cells["tipo_motor"].Value.ToString();
            this.get_tipo_motor(tipo_motor);

            
            txtkm.Text = dataGridView1.CurrentRow.Cells["kilometraje"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_registro"].Value.ToString());
            //txtCliente.Text = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
            //txtMarca.Text = dataGridView1.CurrentRow.Cells["marca_id"].Value.ToString();
            vehiculo_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Vehiculo.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Vehículo eliminado exitosamente.");
                dataGridView1.DataSource = Vehiculo.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el vehículo.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
