namespace academica {
    partial class frm_usuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.grdDatosUsuario = new System.Windows.Forms.DataGridView();
            this.grbEdicionUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.lblRegistrosUsuario = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmacionUsuario = new System.Windows.Forms.TextBox();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuario)).BeginInit();
            this.grbEdicionUsuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.grbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(417, 22);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarUsuario.TabIndex = 15;
            this.lblBuscarUsuario.Text = "BUSCAR:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(508, 27);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarUsuario.TabIndex = 16;
            this.txtBuscarUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyUp);
            // 
            // grdDatosUsuario
            // 
            this.grdDatosUsuario.AllowUserToAddRows = false;
            this.grdDatosUsuario.AllowUserToDeleteRows = false;
            this.grdDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.usuario,
            this.clave,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosUsuario.Location = new System.Drawing.Point(421, 53);
            this.grdDatosUsuario.Name = "grdDatosUsuario";
            this.grdDatosUsuario.ReadOnly = true;
            this.grdDatosUsuario.Size = new System.Drawing.Size(434, 252);
            this.grdDatosUsuario.TabIndex = 14;
            // 
            // grbEdicionUsuario
            // 
            this.grbEdicionUsuario.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnNuevoUsuario);
            this.grbEdicionUsuario.Location = new System.Drawing.Point(232, 311);
            this.grbEdicionUsuario.Name = "grbEdicionUsuario";
            this.grbEdicionUsuario.Size = new System.Drawing.Size(294, 58);
            this.grbEdicionUsuario.TabIndex = 13;
            this.grbEdicionUsuario.TabStop = false;
            this.grbEdicionUsuario.Text = "Navegacion";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(189, 19);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(87, 19);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(104, 38);
            this.btnModificarUsuario.TabIndex = 5;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(6, 19);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoUsuario.TabIndex = 4;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.lblRegistrosUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(13, 311);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionUsuario.TabIndex = 12;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "Navegacion";
            // 
            // lblRegistrosUsuario
            // 
            this.lblRegistrosUsuario.AutoSize = true;
            this.lblRegistrosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosUsuario.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosUsuario.Name = "lblRegistrosUsuario";
            this.lblRegistrosUsuario.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosUsuario.TabIndex = 10;
            this.lblRegistrosUsuario.Text = "x de n";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            this.btnUltimoUsuario.Click += new System.EventHandler(this.btnUltimoUsuario_Click);
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteUsuario.TabIndex = 2;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuario.Click += new System.EventHandler(this.btnSiguienteUsuario_Click);
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuario.Click += new System.EventHandler(this.btnAnteriorUsuario_Click);
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuario.Click += new System.EventHandler(this.btnPrimeroUsuario_Click);
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.txtConfirmacionUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblClave);
            this.grbDatosUsuario.Controls.Add(this.txtClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtUsuario);
            this.grbDatosUsuario.Enabled = false;
            this.grbDatosUsuario.Location = new System.Drawing.Point(12, 12);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(390, 293);
            this.grbDatosUsuario.TabIndex = 11;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "Datos Alumnos";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(31, 84);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(62, 24);
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "Clave:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(131, 88);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.PasswordChar = '*';
            this.txtClaveUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtClaveUsuario.TabIndex = 8;
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(31, 207);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(90, 24);
            this.lblTelefonoUsuario.TabIndex = 7;
            this.lblTelefonoUsuario.Text = "Telefono:";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(131, 211);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoUsuario.TabIndex = 6;
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUsuario.Location = new System.Drawing.Point(31, 168);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(95, 24);
            this.lblDireccionUsuario.TabIndex = 5;
            this.lblDireccionUsuario.Text = "Direccion:";
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(131, 172);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(251, 20);
            this.txtDireccionUsuario.TabIndex = 4;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(31, 128);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(84, 24);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(131, 132);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(251, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(31, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(131, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtConfirmacionUsuario
            // 
            this.txtConfirmacionUsuario.Location = new System.Drawing.Point(251, 88);
            this.txtConfirmacionUsuario.Name = "txtConfirmacionUsuario";
            this.txtConfirmacionUsuario.PasswordChar = '*';
            this.txtConfirmacionUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmacionUsuario.TabIndex = 10;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
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
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 393);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.grdDatosUsuario);
            this.Controls.Add(this.grbEdicionUsuario);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbDatosUsuario);
            this.Name = "frm_usuario";
            this.Text = "ADMINISTRACION DE USUARIOS";
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuario)).EndInit();
            this.grbEdicionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.DataGridView grdDatosUsuario;
        private System.Windows.Forms.GroupBox grbEdicionUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Label lblRegistrosUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
        private System.Windows.Forms.GroupBox grbDatosUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmacionUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}