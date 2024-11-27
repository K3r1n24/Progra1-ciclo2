namespace academica {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblDuiAlumno = new System.Windows.Forms.Label();
            this.txtDuiAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblRegistrosAlumnos = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.grdDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumnos = new System.Windows.Forms.Label();
            this.grbDatosAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.lblDuiAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDuiAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Enabled = false;
            this.grbDatosAlumno.Location = new System.Drawing.Point(12, 12);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(390, 258);
            this.grbDatosAlumno.TabIndex = 0;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos Alumnos";
            // 
            // lblDuiAlumno
            // 
            this.lblDuiAlumno.AutoSize = true;
            this.lblDuiAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiAlumno.Location = new System.Drawing.Point(31, 200);
            this.lblDuiAlumno.Name = "lblDuiAlumno";
            this.lblDuiAlumno.Size = new System.Drawing.Size(43, 24);
            this.lblDuiAlumno.TabIndex = 9;
            this.lblDuiAlumno.Text = "Dui:";
            // 
            // txtDuiAlumno
            // 
            this.txtDuiAlumno.Location = new System.Drawing.Point(131, 204);
            this.txtDuiAlumno.Name = "txtDuiAlumno";
            this.txtDuiAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtDuiAlumno.TabIndex = 8;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(31, 155);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(90, 24);
            this.lblTelefonoAlumno.TabIndex = 7;
            this.lblTelefonoAlumno.Text = "Telefono:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(131, 159);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoAlumno.TabIndex = 6;
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(31, 116);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(95, 24);
            this.lblDireccionAlumno.TabIndex = 5;
            this.lblDireccionAlumno.Text = "Direccion:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(131, 120);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(251, 20);
            this.txtDireccionAlumno.TabIndex = 4;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(31, 76);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(84, 24);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(131, 80);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(251, 20);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(31, 37);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoAlumno.TabIndex = 1;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(131, 41);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAlumno.TabIndex = 0;
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblRegistrosAlumnos);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(13, 311);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblRegistrosAlumnos
            // 
            this.lblRegistrosAlumnos.AutoSize = true;
            this.lblRegistrosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosAlumnos.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosAlumnos.Name = "lblRegistrosAlumnos";
            this.lblRegistrosAlumnos.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosAlumnos.TabIndex = 10;
            this.lblRegistrosAlumnos.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnNuevoAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(232, 311);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(294, 58);
            this.grbEdicionAlumno.TabIndex = 2;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Navegacion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(189, 19);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarAlumno.TabIndex = 6;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(87, 19);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(104, 38);
            this.btnModificarAlumno.TabIndex = 5;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.Location = new System.Drawing.Point(6, 19);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoAlumno.TabIndex = 4;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // grdDatosAlumnos
            // 
            this.grdDatosAlumnos.AllowUserToAddRows = false;
            this.grdDatosAlumnos.AllowUserToDeleteRows = false;
            this.grdDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosAlumnos.Location = new System.Drawing.Point(421, 53);
            this.grdDatosAlumnos.Name = "grdDatosAlumnos";
            this.grdDatosAlumnos.ReadOnly = true;
            this.grdDatosAlumnos.Size = new System.Drawing.Size(434, 252);
            this.grdDatosAlumnos.TabIndex = 3;
            this.grdDatosAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosAlumnos_CellClick);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(508, 27);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarAlumnos.TabIndex = 10;
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);
            // 
            // lblBuscarAlumnos
            // 
            this.lblBuscarAlumnos.AutoSize = true;
            this.lblBuscarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAlumnos.Location = new System.Drawing.Point(417, 22);
            this.lblBuscarAlumnos.Name = "lblBuscarAlumnos";
            this.lblBuscarAlumnos.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarAlumnos.TabIndex = 10;
            this.lblBuscarAlumnos.Text = "BUSCAR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 397);
            this.Controls.Add(this.lblBuscarAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.grdDatosAlumnos);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "Form1";
            this.Text = "ADMINISTRACION DE ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblDuiAlumno;
        private System.Windows.Forms.TextBox txtDuiAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Label lblRegistrosAlumnos;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.DataGridView grdDatosAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.Label lblBuscarAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}

