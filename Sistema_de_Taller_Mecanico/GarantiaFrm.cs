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
    public partial class GarantiaFrm : Form
    {
        int garantia_id = 0;
        public GarantiaFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GarantiaFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Garantia.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string meses = txtMeses.Text;
            string condiciones = txtCondiciones.Text;
            string fecha_inicio = txtFechaI.Text;
            string fecha_fin = txtFechaF.Text;
            string id_orden = txtOrden.Text;
            bool resultado = false;
            if (garantia_id == 0)
            {
                resultado = Garantia.Crear(meses, condiciones, fecha_inicio, fecha_fin, id_orden);
            }
            if (resultado)
            {
                MessageBox.Show("Garantía guardada exitosamente.");
                dataGridView1.DataSource = Garantia.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar la garantía.");
            }
            dataGridView1.DataSource = Modelos.Garantia.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtMeses.Text = "";
            txtCondiciones.Text = "";
            txtFechaI.Text = "";
            txtFechaF.Text = "";
            txtOrden.Text = "";
            garantia_id = 0;
            txtMeses.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMeses.Text = dataGridView1.CurrentRow.Cells["meses"].Value.ToString();
            txtCondiciones.Text = dataGridView1.CurrentRow.Cells["condiciones"].Value.ToString();
            txtFechaI.Text = dataGridView1.CurrentRow.Cells["fecha_inicio"].Value.ToString();
            txtFechaF.Text = dataGridView1.CurrentRow.Cells["fecha_fin"].Value.ToString();
            txtOrden.Text = dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString();
        }

        private  void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Garantia.eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Garantía eliminada exitosamente.");
                dataGridView1.DataSource = Garantia.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar la garantía.");
            }
        }
    }
}
