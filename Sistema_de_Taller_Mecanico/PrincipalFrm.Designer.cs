namespace Sistema_de_Taller_Mecanico
{
    partial class PrincipalFrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnVehiculos = new System.Windows.Forms.ToolStripButton();
            this.btnMarcas = new System.Windows.Forms.ToolStripButton();
            this.btnRepuestos = new System.Windows.Forms.ToolStripButton();
            this.btnOrdenes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnRepuesto_O = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnVehiculos,
            this.btnMarcas,
            this.btnRepuestos,
            this.btnOrdenes,
            this.toolStripButton3,
            this.btnRepuesto_O,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(69, 22);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculos.Image")));
            this.btnVehiculos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(77, 22);
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(65, 22);
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnRepuestos.Image")));
            this.btnRepuestos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(81, 22);
            this.btnRepuestos.Text = "Repuestos";
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(71, 22);
            this.btnOrdenes.Text = "Ordenes";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton3.Text = "Servicios";
            // 
            // btnRepuesto_O
            // 
            this.btnRepuesto_O.Image = ((System.Drawing.Image)(resources.GetObject("btnRepuesto_O.Image")));
            this.btnRepuesto_O.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepuesto_O.Name = "btnRepuesto_O";
            this.btnRepuesto_O.Size = new System.Drawing.Size(112, 22);
            this.btnRepuesto_O.Text = "Repuesto Orden";
            this.btnRepuesto_O.Click += new System.EventHandler(this.btnRepuesto_O_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "PrincipalFrm";
            this.Text = "Sistemas del Taller Mecanico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnVehiculos;
        private System.Windows.Forms.ToolStripButton btnMarcas;
        private System.Windows.Forms.ToolStripButton btnRepuestos;
        private System.Windows.Forms.ToolStripButton btnOrdenes;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnRepuesto_O;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

