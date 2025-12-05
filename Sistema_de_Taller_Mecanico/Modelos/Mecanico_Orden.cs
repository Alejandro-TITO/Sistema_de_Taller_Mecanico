using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Mecanico_Orden
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM mecanico_orden  order by id desc";
                SqlCommand comando = new SqlCommand(consulta, cnn.ObtenerConexion());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static DataTable Crear(string fecha_inicio, string fecha_fin, string horas_trabajo, string id_orden, string id_mecanico)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO mecanico_orden(fecha_inicio,fecha_fin,horas_trabajo,id_orden,id_mecanico) VALUES (@fecha_inicio,@fecha_fin,@horas_trabajo,@id_orden,@id_mecanico)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@horas_trabajo", horas_trabajo);
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@id_mecanico", id_mecanico);
                comando.ExecuteNonQuery();
                return Obtener();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool editar(string fecha_inicio, string fecha_fin, string horas_trabajo, string id_orden, string id_mecanico)
        {
            Conexion conn = new Conexion();
            try
            {
                conn.Conectar();
                string consulta = "UPDATE mecanico_orden SET fecha_inicio=@fecha_inicio, fecha_fin=@fecha_fin, horas_trabajo=@horas_trabajo, id_orden=@id_orden, id_mecanico=@id_mecanico WHERE id_orden=@id_orden AND id_mecanico=@id_mecanico";
                SqlCommand comando = new SqlCommand(consulta, conn.ObtenerConexion());
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@horas_trabajo", horas_trabajo);
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@id_mecanico", id_mecanico);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Desconectar();
            }
        }
        public static bool eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "DELETE FROM mecanico_orden WHERE id=@id";
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
