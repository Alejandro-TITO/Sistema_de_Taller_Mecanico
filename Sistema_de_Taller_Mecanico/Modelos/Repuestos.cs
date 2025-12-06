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
    internal class Repuestos
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM repuestos order by id desc";
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

        public static bool Crear(string codigo, string nombre, string descripcion,string stock, string precio, string marca_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "INSERT INTO repuestos(codigo, nombre, descripcion,stock, precio, marca_id) VALUES (@codigo, @nombre, @descripcion, @stock, @precio, @marca_id)";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@precio", precio);
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

        public static bool Editar(int id, string codigo, string nombre, string descripcion, string stock, string precio, string marca_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "UPDATE repuestos SET codigo=@codigo, nombre=@nombre, descripcion=@descripcion, stock=@stock, precio=@precio, marca_id=@marca_id WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta,
                cnn.ObtenerConexion());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@precio", precio);
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
                string consulta = "DELETE FROM repuestos WHERE id=@id";
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
