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
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            ClientesFrm frm = new ClientesFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            VehiculosFrm frm = new VehiculosFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MarcasFrm frm = new MarcasFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            RepuestosFrm frm = new RepuestosFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRepuesto_O_Click(object sender, EventArgs e)
        {
            Repuesto_orden frm = new Repuesto_orden();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            OrdenesFrm frm = new OrdenesFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ServiciosFrm frm = new ServiciosFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            EvidenciaFrm frm = new EvidenciaFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Servicio_ordenFrm frm = new Servicio_ordenFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MecanicosFrm frm = new MecanicosFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Mecanico_ordenFrm frm = new Mecanico_ordenFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            GarantiaFrm frm = new GarantiaFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Reclamo_GarantiaFrm frm = new Reclamo_GarantiaFrm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
