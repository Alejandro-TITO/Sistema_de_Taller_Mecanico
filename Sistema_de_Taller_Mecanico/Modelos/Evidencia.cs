using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_de_Taller_Mecanico.Modelos
{
    internal class Evidencia
    {
        public static DataTable obtener()
        { Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string query = "SELECT * FROM Evidencia";
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnn.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las evidencias: " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
       
    }
}
