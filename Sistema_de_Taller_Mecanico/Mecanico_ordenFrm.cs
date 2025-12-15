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
    public partial class Mecanico_ordenFrm : Form
    {
        public Mecanico_ordenFrm()
        {
            InitializeComponent();
        }
        int mecanico_orden_id = 0;
        private void Mecanico_ordenFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Mecanico_Orden.Obtener();
            comboBox1.DataSource = Modelos.Ordene.Obtener();
            comboBox1.DisplayMember = "numero_orden";
            comboBox1.ValueMember = "id";
            comboBox2.DataSource = Modelos.Mecanico.Obtener();
            comboBox2.DisplayMember = "nombres";
            comboBox2.ValueMember = "id";
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["id_mecanico"].Visible = false;
                dataGridView1.Columns["id_orden"].Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //string id_mecanico = txtMecanico.Text;
            int id_orden = Convert.ToInt32(comboBox1.SelectedValue);
            //string id_orden = txtOrden.Text;
            int id_mecanico = Convert.ToInt32(comboBox2.SelectedValue);
            string fecha_inicio = txtFechaI.Value.ToString("yyyy-MM-dd");
            string fecha_fin = txtFechaF.Value.ToString("yyyy-MM-dd");
            string horas_trabajo = txtHoras.Text;
            DataTable resultado = null;
            if (mecanico_orden_id == 0)
            {
                resultado = Modelos.Mecanico_Orden.Crear(fecha_inicio, fecha_fin, horas_trabajo, id_orden, id_mecanico);
            }

        }
        private void limpiarCampos()
        {
            //txtMecanico.Text = "";
            //txtOrden.Text = "";
            txtHoras.Text = "";
            mecanico_orden_id = 0;
            txtHoras.Focus();
        }   

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtFechaI.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["fecha_inicio"].Value.ToString());
            txtFechaF.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["fecha_fin"].Value.ToString());
            txtHoras.Text = dataGridView1.CurrentRow.Cells["horas_trabajo"].Value.ToString();
            //txtOrden.Text = dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString();
            //txtMecanico.Text = dataGridView1.CurrentRow.Cells["id_mecanico"].Value.ToString();
            comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells["id_mecanico"].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Mecanico_Orden.eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Registro eliminado exitosamente.");
                dataGridView1.DataSource = Mecanico_Orden.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
