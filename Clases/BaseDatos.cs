using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLogin.Clases
{
    internal class BaseDatos
    {
        static SqlConnection conn = new SqlConnection();

        static private bool Conectar()
        {
            try
            {
                conn.ConnectionString = @"Data Source=DESKTOP-41VCKBR;Initial Catalog=BD_Encriptado;Integrated Security=True";
                conn.Open();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        static private void Desconectar()
        {
            conn.Close();
        }

        static public bool InsertarUsuario(string cadenaSql)
        {
            bool correcto;
            
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(cadenaSql, conn);
                command.ExecuteNonQuery(); // Ejecutar la consulta que no devuelve datos

                correcto = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar usuario: " + ex.Message);

                correcto = false;
            }
            finally
            {
                Desconectar();
            }

            return correcto;
        }
    }
}
