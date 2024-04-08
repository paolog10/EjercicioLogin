using System;
using System.Collections.Generic;
using System.Linq;
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
        #endregion

        #region Propiedades
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

        public Usuario(int pId, string pNombreUsuario, string pContrasenia)
        {
            Id = pId;
            NombreUsuario = pNombreUsuario;
            Contrasenia = pContrasenia;
        }
        #endregion
    }
}
