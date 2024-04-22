using EjercicioLogin.Clases;

namespace EjercicioLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Usuario usuario = new Usuario();
            usuario.NombreUsuario=txtUsuario.Text;
            usuario.Contrasenia=txtContrasenia.Text;

            panel1.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
            panel1.ResetText();
        }
    }
}
