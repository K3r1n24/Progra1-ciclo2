using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta libreria nos servira para conectarnos a la BD.
using System.Data.SqlClient; //Libreria necesaria para conectarnos a SQL Server.


namespace academica {
    internal class Conexion {
        SqlConnection miConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand misComandos = new SqlCommand();//ejecutar SQL en la BD.
        SqlDataAdapter miAdaptador = new SqlDataAdapter();//Intermediario entre mi BD y la aplicacion.
        DataSet ds = new DataSet();//es la representacion grafica de la BD en memoria RAM.

        public Conexion() {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public DataSet obtenerDatos() {
            ds.Clear();
            misComandos.Connection = miConexion;

            miAdaptador.SelectCommand = misComandos;
            misComandos.CommandText = "SELECT * FROM alumnos";
            miAdaptador.Fill(ds, "alumnos");

            misComandos.CommandText = "SELECT * FROM materias";
            miAdaptador.Fill(ds, "materias");

            misComandos.CommandText = "SELECT * FROM usuarios";
            miAdaptador.Fill(ds, "usuarios");
            return ds;
        }
        public String administrarAlumnos(String[] datos) {
            String sql = "";
            if (datos[0] == "nuevo") {
                sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono, dui) VALUES('" + 
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }else if (datos[0] == "modificar") {
                sql = "UPDATE alumnos SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + 
                    datos[5] + "', dui='" + datos[6] + "' WHERE idAlumno=" + datos[1];
            } else if (datos[0] == "eliminar") {
                sql = "DELETE FROM alumnos WHERE idAlumno=" + datos[1];
            }
            return ejecutarSQL(sql);
        }
        public String administrarMaterias(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo"){
                sql = "INSERT INTO materias(codigo, nombre, uv) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "')";
            }else if (datos[0] == "modificar"){
                sql = "UPDATE materias SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', uv='" + datos[4] +
                    "' WHERE idMateria=" + datos[1];
            }else if (datos[0] == "eliminar"){
                sql = "DELETE FROM materias WHERE idMateria=" + datos[1];
            }
            return ejecutarSQL(sql);
        }
        public String administrarUsuarios(String[] datos) {
            String sql = "";
            if (datos[0] == "nuevo") {
                sql = "INSERT INTO usuarios (usuario, clave, nombre, direccion, telefono) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";

            } else if (datos[0] == "modificar") {
                sql = "UPDATE usuarios SET usuario='" + datos[2] + "', clave='" + datos[3] + "', nombre='" + datos[4] + "', direccion='" + datos[5] + "', telefono='" +
                    datos[6] + "' WHERE idUsuario=" + datos[1];

            } else if (datos[0] == "eliminar") {
                sql = "DELETE FROM usuarios WHERE idUsuario=" + datos[1];
            }            return ejecutarSQL(sql);
        }
        private String ejecutarSQL(String sql) {
            try {
                misComandos.Connection = miConexion;
                misComandos.CommandText = sql;
                return misComandos.ExecuteNonQuery().ToString();
            } catch (Exception ex) {
                return "Error: " + ex.Message;
            }
        }
    }
}
