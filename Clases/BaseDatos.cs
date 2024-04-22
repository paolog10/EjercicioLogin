using System;
using System.Collections.Generic;
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
                conn.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=Mascotas;Integrated Security=True";
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static private void Desconectar()
        {
            conn.Close();
        }

    }
}
