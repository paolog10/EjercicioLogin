using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioLogin.Clases
{
    internal class Usuario
    {
        #region Atributos
        private int id;
        private string nombreUsuario;
        private string contrasenia;
        private readonly string patron = "prgpassword"; // Propiedad de solo lectura con valor predeterminado
        #endregion

        #region Propiedades
        public string Patron
        {
            get { return patron; }
        }
        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Constructores
        public Usuario()
        {
            
        }

        public Usuario(string pNombreUsuario, string pContrasenia)
        {
            NombreUsuario = pNombreUsuario;
            Contrasenia = pContrasenia;
        }
        #endregion

        #region Métodos
        public bool LoginUsuario()
        {
            bool correcto;

            string consulta = $"EXEC BD_Encriptado.dbo.SP_AgregarUsuario {NombreUsuario}, {Contrasenia}, {Patron}";
            correcto = BaseDatos.InsertarUsuario(consulta);

            return correcto;
        }
        #endregion
    }
}
