using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class materias : Form {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public materias() {
            InitializeComponent();
        }
        private void materias_Load(object sender, EventArgs e) {
            actualizarDs();
        }
        private void actualizarDs() {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["materias"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idMateria"] };
            grdDatosMaterias.DataSource = miTabla;
            mostrarDatosMaterias();
        }
        private void mostrarDatosMaterias() {
            if (miTabla.Rows.Count > 0) {
                txtCodigoMaterias.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreMaterias.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtUvMaterias.Text = miTabla.Rows[posicion].ItemArray[3].ToString();

                lblRegistrosMaterias.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteMaterias_Click(object sender, EventArgs e) {
            if (posicion < miTabla.Rows.Count - 1) {
                posicion++;
                mostrarDatosMaterias();
            } else {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMaterias_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                mostrarDatosMaterias();
            } else {
                MessageBox.Show("Esta en el primer registro", "Navegacion de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMaterias_Click(object sender, EventArgs e) {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosMaterias();
        }

        private void btnPrimeroMaterias_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatosMaterias();
        }
        private void estadoControles(Boolean estado) {
            grbDatosMaterias.Enabled = estado;
            grbNavegacionMaterias.Enabled = !estado;
            btnEliminarMaterias.Enabled = !estado;
        }
        private void btnNuevoMaterias_Click(object sender, EventArgs e) {
            if (btnNuevoMaterias.Text == "Nuevo") {
                btnNuevoMaterias.Text = "Guardar";
                btnModificarMaterias.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            } else {//Guardar
                String[] materias = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoMaterias.Text, txtNombreMaterias.Text, txtUvMaterias.Text
                };
                String respuesta = objConexion.administrarMaterias(materias);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error en el registro de materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    btnNuevoMaterias.Text = "Nuevo";
                    btnModificarMaterias.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }
        void limpiarCajas() {
            txtCodigoMaterias.Text = "";
            txtNombreMaterias.Text = "";
            txtUvMaterias.Text = "";
        }
        private void btnModificarMaterias_Click(object sender, EventArgs e) {
            if (btnModificarMaterias.Text == "Modificar") {
                btnNuevoMaterias.Text = "Guardar";
                btnModificarMaterias.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
            } else {//Cancelar
                mostrarDatosMaterias();
                btnNuevoMaterias.Text = "Nuevo";
                btnModificarMaterias.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarMaterias_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMaterias.Text.Trim() + "?", "Eliminar materias", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) {
                String[] materias = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarMaterias(materias);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error en el registro de materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosMaterias();
                }
            }
        }
        private void filtrarDatos(String filtro) {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosMaterias.DataSource = dv;
        }
        private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatos(txtBuscarMaterias.Text);
            seleccionarMateria();
        }
        private void seleccionarMateria() {
            try {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosMaterias.CurrentRow.Cells["idMateria"].Value.ToString()));
                mostrarDatosMaterias();
            } catch (Exception) {
                MessageBox.Show("Error: Registro NO encontrado", "Error en la seleccion de materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
