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
    }
}
