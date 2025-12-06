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
    internal class Servicio
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM servicios order by id desc";
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

        public static bool Crear(string codigo, string nombre, string descripcion, string precio_sugerido, string tiempo_estimado, string activo, string tipo_servicio)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO servicios(codigo, nombre, descripcion, precio_sugerido, tiempo_estimado, activo, tipo_servicio) VALUES (@codigo, @nombre, @descripcion, @precio_sugerido, @tiempo_estimado, @activo, @tipo_servicio)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio_sugerido", precio_sugerido);
                comando.Parameters.AddWithValue("@tiempo_estimado", tiempo_estimado);
                comando.Parameters.AddWithValue("@activo", activo);
                comando.Parameters.AddWithValue("@tipo_servicio", tipo_servicio);
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

        public static bool Editar(int id, string codigo, string nombre, string descripcion, string precio_sugerido, string tiempo_estimado, string activo, string tipo_servicio)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE servicios SET codigo=@codigo, nombre=@nombre, descripcion=@descripcion, precio_sugerido=@precio_sugerido, tiempo_estimado=@tiempo_estimado, activo=@activo, tipo_servicio=@tipo_servicio WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio_sugerido", precio_sugerido);
                comando.Parameters.AddWithValue("@tiempo_estimado", tiempo_estimado);
                comando.Parameters.AddWithValue("@activo", activo);
                comando.Parameters.AddWithValue("@tipo_servicio", tipo_servicio);
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
                string consulta = "DELETE FROM servicios WHERE id=@id";
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
