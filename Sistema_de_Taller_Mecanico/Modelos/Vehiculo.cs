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
    internal class Vehiculo
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "select v.*, c.nombres,c.apellidos,m.marca from vehiculos v inner join clientes c on v.id_cliente = c.id inner join marcas m on v.marca_id = m.id\r\norder by id desc";
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

        public static bool Crear(string placa, string modelo, string anio, string tipo_motor, string kilometraje, string fecha_registro, int id_cliente, string marca_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO vehiculos(placa, modelo, anio, tipo_motor, kilometraje,fecha_registro, id_cliente, marca_id) VALUES (@placa, @modelo, @anio, @tipo_motor, @kilometraje,@fecha_registro, @id_cliente, @marca_id)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@placa", placa);
                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters.AddWithValue("@tipo_motor", tipo_motor);
                comando.Parameters.AddWithValue("@kilometraje", kilometraje);
                comando.Parameters.AddWithValue("@fecha_registro", fecha_registro);
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.Parameters.AddWithValue("@marca_id", marca_id);
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

        public static bool Editar(int id, string placa, string modelo, string anio, string tipo_motor, string kilometraje, string fecha_registro, string id_cliente, string marca_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE vehiculos SET placa=@placa, modelo=@modelo, anio=@anio, tipo_motor=@tipo_motor, kilometraje=@kilometraje,fecha_registro=@fecha_registro id_cliente=@id_cliente, marca_id=@marca_id WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@placa", placa);
                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters.AddWithValue("@tipo_motor", tipo_motor);
                comando.Parameters.AddWithValue("@kilometraje", kilometraje);
                comando.Parameters.AddWithValue("@fecha_registro", fecha_registro);
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.Parameters.AddWithValue("@marca_id", marca_id);
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
                string consulta = "DELETE FROM vehiculos WHERE id=@id";
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
