using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Servicio_orden
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM Servicio_orden Servicio_orden order by id desc";
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
            public static bool Crear(string descripcion, string precio_acordado, string tiempo_estimado, string tiempo_real, string estado_servicio, string orden, string servicio)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO Servicio_orden  SET (Descripcion,Precio acordado, tiempo estimado, tiempo real, estado_servicio, id_orden, id_servicio) values @Descripcion,@Precio acordado, " +
                    "@tiempo estimado, @tiempo real, @estadodeservicio, @orden, @servicio";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Precio acordado", precio_acordado);
                comando.Parameters.AddWithValue("@tiempo estimado", tiempo_estimado);
                comando.Parameters.AddWithValue("@tiempo real", tiempo_real);
                comando.Parameters.AddWithValue("@estadodeservicio", estado_servicio);
                comando.Parameters.AddWithValue("@orden", orden);
                comando.Parameters.AddWithValue("@servicio", servicio);
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
        public static bool Editar(int id, string descripcion, string precio_acordado, string tiempo_estimado, string tiempo_real, string estado_servicio, string orden, string servicio)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE Servicio_orden SET (Descripcion,precio acordado, tiempo_estimado, tiempo_real, estado_servicio, orden, servicio) values @Descripcion,@Precio_acordado, " +
                    "@tiempo_estimado, @tiempo_real, @estado_servicio, @orden, @servicio";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Precio acordado", precio_acordado);
                comando.Parameters.AddWithValue("@tiempo estimado", tiempo_estimado);
                comando.Parameters.AddWithValue("@tiempo real", tiempo_real);
                comando.Parameters.AddWithValue("@estadodeservicio", estado_servicio);
                comando.Parameters.AddWithValue("@orden", orden);
                comando.Parameters.AddWithValue("@servicio", servicio);
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
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "DELETE FROM Servicio_orden WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
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








