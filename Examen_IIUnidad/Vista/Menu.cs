using Entidades;

namespace Vista
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------
        private void HabilitarBotonAgregar()
        {
            Usuario usuario = new Usuario();
            if (usuario.Rol == "Administrador")
            {
                AgregarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Solo el Administrador Puede Ingresar a Esta Opcion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AgregarButton.Enabled = false;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------
        private void MantenimientoButton_Click(object sender, EventArgs e)
        {
            Tipos tipoform = new Tipos();
            tipoform.Show();  
            
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario(); 
            crearUsuario.Show();
        }
    }
}
