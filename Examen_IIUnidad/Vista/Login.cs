using Datos;

namespace Vista
{
    public partial class Login : Syncfusion.Windows.Forms.Office2010Form
    { 
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            VariableLocal.UsuarioLogin = CodigoUsuarioTextBox.Text;
        }

        private async void IngresarButton_Click(object sender, EventArgs e)
        { 

            if (CodigoUsuarioTextBox.Text == String.Empty)
            {
                LoginErrorProvider.SetError(CodigoUsuarioTextBox, "Ingrese un codigo de usuario");
                CodigoUsuarioTextBox.Focus();
                return;
            }
            LoginErrorProvider.Clear();

            if (ClaveUsuarioTextBox.Text == String.Empty)
            {
                LoginErrorProvider.SetError(ClaveUsuarioTextBox, "Ingrese la clave del usuario");
                ClaveUsuarioTextBox.Focus();
                return;
            }
            LoginErrorProvider.Clear();


            //Necesitamos instanciar un objeto de la clase Usuario Datos

            UsuarioDatos userDatos = new UsuarioDatos();

            bool valido = await userDatos.LoginAsync(CodigoUsuarioTextBox.Text, ClaveUsuarioTextBox.Text);
            if (valido)
            {
                Menu formulario = new Menu();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}