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
    public partial class Form1 : Form {
        /*
        TAREA: Miercoles 02 de Octubre.
        1. Crear el formulario de docentes.
            Campos:
                * codigo, 
                * nombre, 
                * direccion, 
                * telefono, 
                * dui,
                * email, 
                * especialidad. > ComboBox ("Informatico, Contador, Matematico, Abogado, Salud, etc.")
         */
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            actualizarDs();
        }
        private void actualizarDs() {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["alumnos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idAlumno"] };
            grdDatosAlumnos.DataSource = miTabla;
            mostrarDatosAlumno();
        }
        private void mostrarDatosAlumno() {
            if (miTabla.Rows.Count > 0) {
                txtCodigoAlumno.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreAlumno.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionAlumno.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoAlumno.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtDuiAlumno.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosAlumnos.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e) {
            if (posicion < miTabla.Rows.Count - 1) {
                posicion++;
                mostrarDatosAlumno();
            } else {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e) {
            if( posicion>0) {
                posicion--;
                mostrarDatosAlumno();
            } else {
                MessageBox.Show("Esta en el primer registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e) {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosAlumno();
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatosAlumno();
        }
        private void estadoControles(Boolean estado) {
            grbDatosAlumno.Enabled = estado;
            grbNavegacionAlumno.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e) {
            if (btnNuevoAlumno.Text == "Nuevo") {
                btnNuevoAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            } else {//Guardar
                String[] alumnos = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text, txtDuiAlumno.Text
                };
                String respuesta = objConexion.administrarAlumnos(alumnos);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error en el registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    btnNuevoAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }
        void limpiarCajas() {
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
            txtDuiAlumno.Text = "";
        }
        private void btnModificarAlumno_Click(object sender, EventArgs e) {
            if (btnModificarAlumno.Text == "Modificar") {
                btnNuevoAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
                
            } else {//Cancelar
                mostrarDatosAlumno();
                btnNuevoAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e) {
            if( MessageBox.Show("Esta seguro de eliminar a "+ txtNombreAlumno.Text.Trim() +"?", "Eliminar alumnos", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question)==DialogResult.Yes) {
                String[] alumnos = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarAlumnos(alumnos);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error en el registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosAlumno();
                }
            }
        }
        private void filtrarDatos(String filtro) {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%"+ filtro +"%' OR nombre like '%" + filtro + "%'";
            grdDatosAlumnos.DataSource = dv;
        }
        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatos(txtBuscarAlumnos.Text);
            //if (e.KeyValue == 13) {//tecla enter
                seleccionarAllumno();
            //}
        }
        private void seleccionarAllumno() {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosAlumnos.CurrentRow.Cells["idAlumno"].Value.ToString()));
            mostrarDatosAlumno();
        }
        private void grdDatosAlumnos_CellClick(object sender, DataGridViewCellEventArgs e) {
            seleccionarAllumno();
        }
    }
}
