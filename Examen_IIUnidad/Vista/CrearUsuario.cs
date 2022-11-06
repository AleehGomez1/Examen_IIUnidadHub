using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class CrearUsuario : Syncfusion.Windows.Forms.Office2010Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }
        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }
        UsuarioDatos userdatos = new UsuarioDatos();
        Usuario user;

        private async void CrearButton_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese su nombre completo");
                NombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(CodigoTextBox.Text))
            {
                errorProvider1.SetError(CodigoTextBox, "Ingrese un usuario");
                CodigoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                errorProvider1.SetError(ClaveTextBox, "Ingrese una clave");
                ClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(RolComboBox.Text))
            {
                errorProvider1.SetError(RolComboBox, "Seleccione un Rol");
                RolComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            user.Nombre = NombreTextBox.Text;
            user.Codigo = CodigoTextBox.Text;
            user.Clave = ClaveTextBox.Text;
            user.Rol = RolComboBox.Text;


            bool inserto = await userdatos.InsertarAsync(user);

            if (inserto)
            {
                
                MessageBox.Show("Usuario Creado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("El Usuario No Se Pudo Crear", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        

    }
}
