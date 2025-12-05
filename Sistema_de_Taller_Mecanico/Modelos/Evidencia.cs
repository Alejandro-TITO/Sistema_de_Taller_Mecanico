using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Evidencia
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string query = "SELECT * FROM Evidencia ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnn.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las evidencia: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool Crear(string descripcion, string fecha, int id_orden)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string query = "INSERT INTO Evidencia (Descripcion, Fecha_subida, Orden) VALUES (@Descripcion, @Fecha_subida, @id_orden)";
                SqlCommand cmd = new SqlCommand(query, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fecha_subida", fecha);
                cmd.Parameters.AddWithValue("@id_Orden", id_orden);
                int rowsAffected = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al crear la evidencia: " + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool editar(int id, string descripcion, string fecha, int id_orden)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string query = "UPDATE Evidencia SET Descripcion = @Descripcion, Fecha_subida = @Fecha_subida, Orden = @Orden WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fecha_subida", fecha);
                cmd.Parameters.AddWithValue("@Orden", id_orden);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la evidencia: " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string query = "DELETE FROM Evidencia WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la evidencia: " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}
