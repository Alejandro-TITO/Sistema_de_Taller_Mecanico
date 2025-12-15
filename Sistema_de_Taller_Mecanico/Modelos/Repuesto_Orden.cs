using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Repuesto_Orden
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT ro.*, o.numero_orden, r.nombre FROM Repuesto_Orden ro inner join ordenes o on ro.id_orden = o.id inner join repuestos r on or.id_repuesto = r.id order by id desc";
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
        public static bool Crear(string cantidad, string precio_unitario, string precio_total, int id_orden, int id_repuesto)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO Repuesto_Orden (cantidad, precio_unitario, precio_total, id_orden, id_repuesto) VALUES (@cantidad, @precio_unitario, @precio_total, @id_orden, @id_repuesto)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                comando.Parameters.AddWithValue("@precio_total", precio_total);
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@id_repuesto", id_repuesto);
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
        public static bool Editar(int id, string cantidad, string precio_unitario, string precio_total, int id_orden, int id_repuesto)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE Repuesto_Orden SET cantidad=@cantidad, precio_unitario=@precio_unitario, precio_total=@precio_total, id_orden=@id_orden, id_repuesto=@id_repuesto WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                comando.Parameters.AddWithValue("@precio_total", precio_total);
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@id_repuesto",id_repuesto);
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
                string consulta = "DELETE FROM Repuesto_Orden WHERE id=@id";
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
