namespace Sistema_de_Taller_Mecanico
{
    partial class OrdenesFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtFechaI = new System.Windows.Forms.DateTimePicker();
            this.txtFechaE = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioE = new System.Windows.Forms.TextBox();
            this.txtTotalR = new System.Windows.Forms.TextBox();
            this.txtManoO = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtObservacionC = new System.Windows.Forms.TextBox();
            this.txtDiagnosticoI = new System.Windows.Forms.TextBox();
            this.txtNumeroO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtVehiculo);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.txtFechaI);
            this.splitContainer1.Panel1.Controls.Add(this.txtFechaE);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrecioE);
            this.splitContainer1.Panel1.Controls.Add(this.txtTotalR);
            this.splitContainer1.Panel1.Controls.Add(this.txtManoO);
            this.splitContainer1.Panel1.Controls.Add(this.txtEstado);
            this.splitContainer1.Panel1.Controls.Add(this.txtObservacionC);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiagnosticoI);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumeroO);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditar);
            this.splitContainer1.Panel1.Controls.Add(this.btnGuardar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 588);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtFechaI
            // 
            this.txtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaI.Location = new System.Drawing.Point(22, 96);
            this.txtFechaI.Name = "txtFechaI";
            this.txtFechaI.Size = new System.Drawing.Size(136, 20);
            this.txtFechaI.TabIndex = 33;
            // 
            // txtFechaE
            // 
            this.txtFechaE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaE.Location = new System.Drawing.Point(22, 379);
            this.txtFechaE.Name = "txtFechaE";
            this.txtFechaE.Size = new System.Drawing.Size(136, 20);
            this.txtFechaE.TabIndex = 32;
            // 
            // txtPrecioE
            // 
            this.txtPrecioE.Location = new System.Drawing.Point(22, 337);
            this.txtPrecioE.Name = "txtPrecioE";
            this.txtPrecioE.Size = new System.Drawing.Size(222, 20);
            this.txtPrecioE.TabIndex = 31;
            // 
            // txtTotalR
            // 
            this.txtTotalR.Location = new System.Drawing.Point(22, 298);
            this.txtTotalR.Name = "txtTotalR";
            this.txtTotalR.Size = new System.Drawing.Size(222, 20);
            this.txtTotalR.TabIndex = 30;
            // 
            // txtManoO
            // 
            this.txtManoO.Location = new System.Drawing.Point(22, 259);
            this.txtManoO.Name = "txtManoO";
            this.txtManoO.Size = new System.Drawing.Size(222, 20);
            this.txtManoO.TabIndex = 29;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(22, 223);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(222, 20);
            this.txtEstado.TabIndex = 28;
            // 
            // txtObservacionC
            // 
            this.txtObservacionC.Location = new System.Drawing.Point(22, 184);
            this.txtObservacionC.Name = "txtObservacionC";
            this.txtObservacionC.Size = new System.Drawing.Size(222, 20);
            this.txtObservacionC.TabIndex = 27;
            // 
            // txtDiagnosticoI
            // 
            this.txtDiagnosticoI.Location = new System.Drawing.Point(22, 141);
            this.txtDiagnosticoI.Name = "txtDiagnosticoI";
            this.txtDiagnosticoI.Size = new System.Drawing.Size(222, 20);
            this.txtDiagnosticoI.TabIndex = 26;
            // 
            // txtNumeroO
            // 
            this.txtNumeroO.Location = new System.Drawing.Point(22, 51);
            this.txtNumeroO.Name = "txtNumeroO";
            this.txtNumeroO.Size = new System.Drawing.Size(222, 20);
            this.txtNumeroO.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fecha de Entrega";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Precio Estimado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total de Repuestos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mano de Obra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observacion del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Diagnostico Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha de Ingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Numero de Orden";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(44, 516);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 37);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(138, 471);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 39);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(17, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 38);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 588);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(27, 429);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(143, 20);
            this.txtVehiculo.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Vehiculo";
            // 
            // OrdenesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrdenesFrm";
            this.Text = "OrdenesFrm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker txtFechaI;
        private System.Windows.Forms.DateTimePicker txtFechaE;
        private System.Windows.Forms.TextBox txtPrecioE;
        private System.Windows.Forms.TextBox txtTotalR;
        private System.Windows.Forms.TextBox txtManoO;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtObservacionC;
        private System.Windows.Forms.TextBox txtDiagnosticoI;
        private System.Windows.Forms.TextBox txtNumeroO;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label label10;
    }
}