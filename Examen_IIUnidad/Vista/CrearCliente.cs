using Datos;
using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CrearCliente : Syncfusion.Windows.Forms.Office2010Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }

        ClienteDatos clientedatos = new ClienteDatos();
        Cliente cliente;
        private async void CrearButton_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
            {
                errorProvider1.SetError(NombreClienteTextBox, "Ingrese el nombre completo del cliente");
                NombreClienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(IdentidadClienteTextBox.Text))
            {
                errorProvider1.SetError(IdentidadClienteTextBox, "Ingrese el numero de identidad");
                IdentidadClienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(DireccionClienteTextBox.Text))
            {
                errorProvider1.SetError(DireccionClienteTextBox, "Ingrese la direccion donde reside el cliente");
                DireccionClienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(EmailClienteTextBox.Text))
            {
                errorProvider1.SetError(EmailClienteTextBox, "Ingrese El Email del Cliente");
                EmailClienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            if (string.IsNullOrEmpty(TelefonoClienteTextBox.Text))
            {
                errorProvider1.SetError(TelefonoClienteTextBox, "Ingrese El Email del Cliente");
                TelefonoClienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            cliente.Nombre = NombreClienteTextBox.Text;
            cliente.Identidad = IdentidadClienteTextBox.Text;
            cliente.Direccion = DireccionClienteTextBox.Text;
            cliente.Email = EmailClienteTextBox.Text;
            cliente.Telefono = TelefonoClienteTextBox.Text;

            bool inserto = await clientedatos.InsertarAsync(cliente);

            if (inserto)
            {

                MessageBox.Show("Usuario Creado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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
