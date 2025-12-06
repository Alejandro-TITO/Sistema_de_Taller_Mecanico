using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Mecanico
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM mecanicos  order by id desc";
                SqlCommand comando = new SqlCommand(consulta, cnn.ObtenerConexion());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool Crear(string nombres, string apellidos, string telefono, string fecha_ingreso, string estado, string especialidades)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO mecanicos(nombres,apellidos,especialidades,telefono,estado,fecha_ingreso) VALUES (@nombres, @apellidos, @especialidades, @telefono, @estado, @fecha_ingreso)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@nombres", nombres);
                comando.Parameters.AddWithValue("@apellidos", apellidos);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@especialidades", especialidades);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
            finally
            {
                cnn.Desconectar();                                                                                                                           
            }
        }
        private void editar(int id, string nombres, string apellidos, string telefono, string fecha_ingreso, string estado, string especialidades)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE mecanicos SET nombres=@nombres, apellidos=@apellidos, telefono=@telefono, fecha_ingreso=@fecha_ingreso, estado=@estado, especialidades=@especialidades WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta, cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombres", nombres);
                comando.Parameters.AddWithValue("@apellidos", apellidos);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@especialidades", especialidades);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "DELETE FROM mecanicos WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta, cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

    }
}
