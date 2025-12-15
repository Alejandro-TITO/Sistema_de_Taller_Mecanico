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
    public partial class Reclamo_GarantiaFrm : Form
    {
        int reclamoGarantia_id=0;
        public Reclamo_GarantiaFrm()
        {
            InitializeComponent();
        }

        private void Reclamo_GarantiaFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelos.Reclamo_Garantia.Obtener();
            comboBox1.DataSource = Modelos.Garantia.Obtener();
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "id";

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["id_garantia"].Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Fecha_reclamo = txtFechaReclamo.Value.ToString("yyyy-MM-dd");
            string Descripcion_problema = txtDescripcionP.Text;
            string Solucion_aplicada = txtxSolucionA.Text;
            string Costo_cubierto = txtCostoC.Text;
            string Estado_reclamo;
            if (radioButton1.Checked)
            {
                Estado_reclamo = "En inicio";
            }
            else if (radioButton2.Checked)
            {
                Estado_reclamo = "En Proceso";
            }
            else
            {
                Estado_reclamo = "Finalizado";
            }
            //string id_garantia = txtGarantia.Text;
            int id_garantia = Convert.ToInt32(comboBox1.SelectedValue);
            bool resultado = false;
            if (reclamoGarantia_id == 0)
            {
                resultado = Reclamo_Garantia.Crear(Fecha_reclamo, Descripcion_problema, Solucion_aplicada,
                    Costo_cubierto, Estado_reclamo, id_garantia);
            }
            if (resultado)
            {
                MessageBox.Show("Reclamo de garantía guardado exitosamente.");
                dataGridView1.DataSource = Modelos.Reclamo_Garantia.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el reclamo de garantía.");
            }
            dataGridView1.DataSource = Modelos.Reclamo_Garantia.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtFechaReclamo.Value = DateTime.Now;
            txtDescripcionP.Text = "";
            txtxSolucionA.Text = "";
            txtCostoC.Text = "";
            txtEstadoR.Text = "";
            reclamoGarantia_id = 0;
            txtDescripcionP.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtFechaReclamo.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha_reclamo"].Value);
            txtDescripcionP.Text = dataGridView1.CurrentRow.Cells["Descripcion_problema"].Value.ToString();
            txtxSolucionA.Text = dataGridView1.CurrentRow.Cells["Solucion_aplicada"].Value.ToString();
            txtCostoC.Text = dataGridView1.CurrentRow.Cells["Costo_cubierto"].Value.ToString();
            string Estado_reclamo = dataGridView1.CurrentRow.Cells["Estado_reclamo"].Value.ToString();
            if (Estado_reclamo == "En inicio")
            {
                radioButton1.Checked = true;
            }
            else if (Estado_reclamo == "En Proceso")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
            //txtGarantia.Text = dataGridView1.CurrentRow.Cells["id_garantia"].Value.ToString();
            comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_garantia"].Value);
            reclamoGarantia_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Modelos.Reclamo_Garantia.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Reclamo de garantía eliminado exitosamente.");
                dataGridView1.DataSource = Modelos.Reclamo_Garantia.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el reclamo de garantía.");
            }
        }
    }
}
