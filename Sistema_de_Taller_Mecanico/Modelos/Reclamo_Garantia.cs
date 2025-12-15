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
    internal class Reclamo_Garantia
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT rg.*, g.meses FROM Reclamo_Garantia rg inner join garantias g on rg.id_garantia= g.id order by id desc";
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

        public static bool Crear(string fecha_reclamo, string descripcion_problema, string solucion_aplicada,string costo_cubierto,string estado_reclamo, int id_garantia)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO Reclamo_Garantia(Fecha_reclamo, Descripcion_problema, Solucion_aplicada, Costo_cubierto, Estado_reclamo, id_garantia) " +
                    "VALUES (@Fecha_reclamo, @Descripcion_problema, @Solucion_aplicada, @Costo_cubierto, @Estado_reclamo, @id_garantia)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@Fecha_reclamo", fecha_reclamo);
                comando.Parameters.AddWithValue("@Descripcion_problema", descripcion_problema);
                comando.Parameters.AddWithValue("@Solucion_aplicada", solucion_aplicada);
                comando.Parameters.AddWithValue("@Costo_cubierto", costo_cubierto);
                comando.Parameters.AddWithValue("@Estado_reclamo", estado_reclamo);
                comando.Parameters.AddWithValue("@id_garantia", id_garantia);
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
        public static bool Editar(int id, string fecha_reclamo, string descripcion_problema, string solucion_aplicada,
            string costo_cubierto, string estado_reclamo, int id_garantia)
        {
           Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE Reclamo_Garantia SET Fecha_reclamo=@Fecha_reclamo, Descripcion_problema=@Descripcion_problema, " +
                    "Solucion_aplicada=@Solucion_aplicada, Costo_cubierto=@Costo_cubierto, Estado_reclamo=@Estado_reclamo, id_garantia=@id_garantia WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@Fecha_reclamo", fecha_reclamo);
                comando.Parameters.AddWithValue("@Descripcion_problema", descripcion_problema);
                comando.Parameters.AddWithValue("@Solucion_aplicada", solucion_aplicada);
                comando.Parameters.AddWithValue("@Costo_cubierto", costo_cubierto);
                comando.Parameters.AddWithValue("@Estado_reclamo", estado_reclamo);
                comando.Parameters.AddWithValue("@id_garantia", id_garantia);
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
                string consulta = "DELETE FROM Reclamo_Garantia WHERE id=@id";
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
