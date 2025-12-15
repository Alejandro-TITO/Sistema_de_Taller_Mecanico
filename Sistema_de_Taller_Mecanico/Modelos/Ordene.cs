using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Ordene
    {
        // Obtener todos los registros de la tabla Ordenes
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT o.*, v.placa FROM ordenes o inner join vehiculos v on o.id_vehiculo = v.id order by id desc";
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

        // Crear un nuevo registro en la tabla Ordenes
        public static bool Crear(string numero_orden, string fecha_ingreso, string diagnostico_inicial, string observacion_cliente, string estado, string mano_obra, string total_repuestos, string precio_estimado, string fecha_entrega, int id_vehiculo)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO ordenes(numero_orden, fecha_ingreso, diagnostico_inicial, observacion_cliente, estado, mano_obra, total_repuestos, precio_estimado, fecha_entrega, id_vehiculo) VALUES (@numero_orden, @fecha_ingreso, @diagnostico_inicial, @observacion_cliente, @estado, @mano_obra, @total_repuestos, @precio_estimado, @fecha_entrega, @id_vehiculo)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@numero_orden", numero_orden);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@diagnostico_inicial", diagnostico_inicial);
                comando.Parameters.AddWithValue("@observacion_cliente", observacion_cliente);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@mano_obra", mano_obra);
                comando.Parameters.AddWithValue("@total_repuestos", total_repuestos);
                comando.Parameters.AddWithValue("@precio_estimado", precio_estimado);
                comando.Parameters.AddWithValue("@fecha_entrega", fecha_entrega);
                comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
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

        // Editar un registro existente en la tabla Ordenes
        public static bool Editar(int id, string numero_orden, string fecha_ingreso, string diagnostico_inicial, string observacion_cliente, string estado, string mano_obra, string total_repuestos, string precio_estimado, string fecha_entrega, int id_vehiculo)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE ordenes SET numero_orden=@numero_orden, fecha_ingreso=@fecha_ingreso, diagnostico_inicial=@diagnostico_inicial, observacion_cliente=@observacion_cliente, estado=@estado, mano_obra=@mano_obra, total_repuestos=@total_repuestos, precio_estimado=@precio_estimado, fecha_entrega=@fecha_entrega, id_vehiculo=@id_vehiculo WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@numero_orden", numero_orden);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@diagnostico_inicial", diagnostico_inicial);
                comando.Parameters.AddWithValue("@observacion_cliente", observacion_cliente);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@mano_obra", mano_obra);
                comando.Parameters.AddWithValue("@total_repuestos", total_repuestos);
                comando.Parameters.AddWithValue("@precio_estimado", precio_estimado);
                comando.Parameters.AddWithValue("@fecha_entrega", fecha_entrega);
                comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
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

        // Eliminar un registro de la tabla Ordenes
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "DELETE FROM ordenes WHERE id=@id";
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
