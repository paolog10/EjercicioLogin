using EjercicioLogin.Clases;

namespace EjercicioLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());

            if (usuario.LoginUsuario())
            {
                MessageBox.Show("Usuario guardado correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
