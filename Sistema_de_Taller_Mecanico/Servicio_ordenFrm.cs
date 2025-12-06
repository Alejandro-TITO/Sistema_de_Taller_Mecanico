using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Taller_Mecanico.Modelos;

namespace Sistema_de_Taller_Mecanico
{
    public partial class Servicio_ordenFrm : Form
    {
        int  servicio_id = 0;
        public Servicio_ordenFrm()
        {
            InitializeComponent();
        }

        private void Servicio_ordenFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servicio_orden.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Descripcion = txtDescripcion.Text;
            string Precioacordado = txtPrecioAcor.Text;
            string Tiempoestimado = txtTiempoEst.Text;
            string Tiemporeal = txtTiempoReal.Text;
            string Estadodelservicio = txtEstadoServ.Text;
            string Orden = txtOrden.Text;
            string Servicio = txtServicio.Text;
            bool resultado = false;
            if (servicio_id == 0)
            {
                resultado = Servicio_orden.Crear (Descripcion, Precioacordado, Tiempoestimado, Tiemporeal, Estadodelservicio, Orden, Servicio);
            }
            if (resultado)
            {
                MessageBox.Show("Cliente guardado exitosamente.");
                dataGridView1.DataSource = Servicio_orden.Obtener();
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente.");
            }
            dataGridView1.DataSource = Servicio_orden.Obtener();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
            txtPrecioAcor.Text = "";
            txtTiempoEst.Text = "";
            txtTiempoReal.Text = "";
            txtEstadoServ.Text = "";
            txtOrden.Text = "";
            txtServicio.Text = "";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            txtPrecioAcor.Text = dataGridView1.CurrentRow.Cells["Precio Acordado"].Value.ToString();
            txtTiempoEst.Text = dataGridView1.CurrentRow.Cells["Tiempo estimado"].Value.ToString();
            txtTiempoReal.Text = dataGridView1.CurrentRow.Cells["Tiempo real en minutos"].Value.ToString();
            txtEstadoServ.Text = dataGridView1.CurrentRow.Cells["Estado del servicio"].Value.ToString();
            txtOrden.Text = dataGridView1.CurrentRow.Cells["Orden"].Value.ToString();
            txtServicio.Text = dataGridView1.CurrentRow.Cells["Servicio"].Value.ToString();
            servicio_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Servicio_orden.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("servicio oden  eliminado exitosamente.");
                dataGridView1.DataSource = Servicio_orden.Obtener();
            }
            else
            {
                MessageBox.Show("Error al eliminar el Servicio orden.");
            }
        }
    }
}

    


        
    
     
