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
    internal class Garantia
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM garantias  order by id desc";
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
        public static bool Crear(string meses, string condiciones, string fecha_inicio, string fecha_fin, string id_orden)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO garantias(meses,condiciones,fecha_inicio,fecha_fin,id_orden) VALUES (@meses,@condiciones,@fecha_inicio,@fecha_fin,@id_orden)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@meses", meses);
                comando.Parameters.AddWithValue("@condiciones", condiciones);
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@id_orden", id_orden);
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
        public static bool editar(int id, string meses, string condiciones,string fecha_inicio,string fecha_fin,string id_order)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE garantias SET descripcion=@descripcion, condiciones=@condiciones, fecha_inicio=@fecha_inicio,fecha_fin=@fecha_fin WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@meses", meses);
                comando.Parameters.AddWithValue("@condiciones", condiciones);
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@id_order", id_order);
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
        public static bool eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "DELETE FROM garantias WHERE id=@id";
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
