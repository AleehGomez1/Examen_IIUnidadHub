using Datos;
using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
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
    public partial class RegistrosClientes : Syncfusion.Windows.Forms.Office2010Form
    {
        public RegistrosClientes()
        {
            InitializeComponent();
        }

        ClienteDatos clientedatos = new ClienteDatos();

        Cliente cliente;
        string tipoOperacion = string.Empty;

        private void RegistrosClientes_Load(object sender, EventArgs e)
        {
            LlenarDataGrib();
        }

        private async void LlenarDataGrib()
        {
            RegistroClienteDataGridView.DataSource = await clientedatos.DevolverListaAsync();

        }
        private void HabilitarControles()
        {
            NombreClienteTextBox.Enabled = true;
            IdentidadClienteTextBox.Enabled = true;
            DireccionClienteTextBox.Enabled = true;
            EmailClienteTextBox.Enabled = true;
            TelefonoClienteTextBox.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            NombreClienteTextBox.Enabled = false;
            IdentidadClienteTextBox.Enabled = false;
            DireccionClienteTextBox.Enabled = false;
            EmailClienteTextBox.Enabled = false;
            TelefonoClienteTextBox.Enabled = false;
        }
        private void LimpiarControles()
        {
            NombreClienteTextBox.Clear();
            IdentidadClienteTextBox.Clear();
            DireccionClienteTextBox.Clear();
            EmailClienteTextBox.Clear();
            TelefonoClienteTextBox.Clear();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (RegistroClienteDataGridView.SelectedRows.Count > 0)
            {

                tipoOperacion = "Modificar";
                NombreClienteTextBox.Text = RegistroClienteDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                IdentidadClienteTextBox.Text = RegistroClienteDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                DireccionClienteTextBox.Text = RegistroClienteDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                EmailClienteTextBox.Text = RegistroClienteDataGridView.CurrentRow.Cells["Email"].Value.ToString();
                TelefonoClienteTextBox.Text = RegistroClienteDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();

                HabilitarControles();

                //Deshabilitar el Textbox de codigo para no ser modificado
                IdentidadClienteTextBox.ReadOnly = true;
            }

            else
            {
                MessageBox.Show("Seleccione un Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void GuardarButton_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            if (tipoOperacion == "Modificar")
            {
                
                if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
                {
                    errorProvider1.SetError(NombreClienteTextBox, "Ingrese un nombre");
                    NombreClienteTextBox.Focus();
                    errorProvider1.Clear();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DireccionClienteTextBox.Text))
                {
                    errorProvider1.SetError(DireccionClienteTextBox, "Ingrese una dirección");
                    DireccionClienteTextBox.Focus();
                    errorProvider1.Clear();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(EmailClienteTextBox.Text))
                {
                    errorProvider1.SetError(EmailClienteTextBox, "Seleccione un Rol");
                    EmailClienteTextBox.Focus();
                    errorProvider1.Clear();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(TelefonoClienteTextBox.Text))
                {
                    errorProvider1.SetError(TelefonoClienteTextBox, "Seleccione un Rol");
                    TelefonoClienteTextBox.Focus();
                    errorProvider1.Clear();
                    return;
                }
                errorProvider1.Clear();

                //Declaramos las instancias de la clase usuario en el objeto user
                cliente.Nombre = NombreClienteTextBox.Text;
                cliente.Direccion = DireccionClienteTextBox.Text;
                cliente.Email = EmailClienteTextBox.Text;
                cliente.Telefono = TelefonoClienteTextBox.Text;

                //Mandaremos al metodo de modifico un usuario
                bool modifico = await clientedatos.ActualizarAsync(cliente);

                if (modifico)
                {
                    //Mandamos a llamar la funciones para llenar el DataGrib, Limpiar los Controles y Deshabilitar los mismos.
                    LlenarDataGrib();
                    LimpiarControles();
                    DeshabilitarControles();
                    MessageBox.Show("Usuario Actualizado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario No Se Pudo Actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private async void EliminarButton_Click(object sender, EventArgs e)
        {
            if (RegistroClienteDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = await clientedatos.EliminarAsync(RegistroClienteDataGridView.CurrentRow.Cells["Identidad"].Value.ToString());
                if (elimino)
                {
                    LlenarDataGrib();
                    MessageBox.Show("Producto Eliminado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Producto No Se Pudo Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe De Selecionar Un Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

