using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica {
    public partial class frm_usuario : Form {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public frm_usuario() {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e) {
            actualizarDs();
        }
        private void actualizarDs() {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            grdDatosUsuario.DataSource = miTabla;
            mostrarDatosUsuario();
        }
        private void mostrarDatosUsuario() {
            if (miTabla.Rows.Count > 0) {
                txtUsuario.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtClaveUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtConfirmacionUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtNombreUsuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtDireccionUsuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtTelefonoUsuario.Text = miTabla.Rows[posicion].ItemArray[5].ToString();
               
                lblRegistrosUsuario.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e) {
            if (posicion < miTabla.Rows.Count - 1) {
                posicion++;
                mostrarDatosUsuario();
            } else {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e) {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuario();
        }
        private void btnAnteriorUsuario_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                mostrarDatosUsuario();
            } else {
                MessageBox.Show("Esta en el primer registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnPrimeroUsuario_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatosUsuario();
        }
        private void estadoControles(Boolean estado) {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e) {
            if (btnNuevoUsuario.Text == "Nuevo") {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            } else {//Guardar
                if (txtClaveUsuario.Text.Trim() != txtConfirmacionUsuario.Text.Trim()) {
                    MessageBox.Show("La claves y la confirmacion NO coinciden", "Error en el registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    String[] usuario = {
                        accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                        txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text, txtDireccionUsuario.Text, txtTelefonoUsuario.Text
                    };
                    String respuesta = objConexion.administrarUsuarios(usuario);
                    if (respuesta != "1") {
                        MessageBox.Show(respuesta, "Error en el registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        btnNuevoUsuario.Text = "Nuevo";
                        btnModificarUsuario.Text = "Modificar";
                        estadoControles(false);
                        actualizarDs();
                    }
                }
            }
        }
        void limpiarCajas() {
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";     
            txtConfirmacionUsuario.Text = "";     
            txtNombreUsuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e) {
            if (btnModificarUsuario.Text == "Modificar") {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            } else {//Cancelar
                mostrarDatosUsuario();
                btnNuevoUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreUsuario.Text.Trim() + "?", "Eliminar usuarios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) {
                String[] usuarios = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarUsuarios(usuarios);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error en el registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosUsuario();
                }
            }
        }
        private void filtrarDatos(String filtro) {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "usuario like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosUsuario.DataSource = dv;
        }
        private void seleccionarUsuario() {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosUsuario.CurrentRow.Cells["idUsuario"].Value.ToString()));
            mostrarDatosUsuario();
        }

        private void txtBuscarUsuario_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatos(txtBuscarUsuario.Text);
            seleccionarUsuario();
        }
    }
}
