using Datos;
using Entidades;
using MySqlX.XDevAPI;
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
    public partial class Tickets : Syncfusion.Windows.Forms.Office2010Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        List<DetalleTickets> detalles = new List<DetalleTickets>();
        Ticketss tickets;
        Cliente cliente;
        TicketDatos ticketdatos;
        Productos productos = null;

        decimal subtotal = 0;
        decimal isv = 0;
        decimal total = 0;

        private void Tickets_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = VariableLocal.UsuarioLogin;
            DescuentoTextBox.Text = "0.00";
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCliente crearclienteform = new CrearCliente();
            crearclienteform.Show();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ClienteDatos clientedatos = new ClienteDatos();
                Cliente cliente = new Cliente();

                cliente = await clientedatos.GetPorIdentidad(IdentidadTextBox.Text);

                if (cliente.Identidad != null)
                {
                    NombreTextBox.Text = cliente.Nombre;
                    errorProvider1.Clear();
                    CodigoTextBox.Focus();
                }
                else
                {
                    errorProvider1.SetError(NombreTextBox, "No Existe el Cliente");
                }
            }
        }

        private async void CodigoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProductoDatos productodatos = new ProductoDatos();
                Productos productos = new Productos();

                productos = await productodatos.GetPorCodigo(CodigoTextBox.Text);

                if (productos.Codigo != null)
                {
                    TipoTextBox.Text = productos.Tipo;
                    MarcaTextBox.Text = productos.Marca;
                    ModeloTextBox.Text = productos.Modelo;

                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(CodigoTextBox, "No Existe el Producto");
                }
            }

        }

        private void TipoSoporteComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private async void CrearButton_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                errorProvider1.SetError(IdentidadTextBox, "Consulte un Cliente");
                IdentidadTextBox.Focus();
                return;
            }
            tickets = new Ticketss();

            tickets.Fecha = FechaDateTimePicker.Value;
            tickets.CodigoUsuario = UsuarioTextBox.Text;
            tickets.ISV = isv;
            tickets.SubTotal = subtotal;
            tickets.Descuento = Convert.ToDecimal(DescuentoTextBox.Text);
            tickets.Total = total;
            tickets.IdentidadCliente = cliente.Identidad;

            ticketdatos = new TicketDatos();

            bool inserto = await ticketdatos.InsertarAsync(tickets, detalles);
            if (inserto)
            {
                MessageBox.Show("Ticket Ingresado Correctamente");

            }
        }

        private void OpcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                DetalleTickets detalle = new DetalleTickets();
                detalle.CodigoProducto = productos.Codigo;
                detalle.DescripcionRespuesta = DescripcionRespuestaTextBox.Text;
                detalle.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
                detalle.TipoSoporte = TipoSoporteComboBox.Text;
                detalle.Precio = 500.00M;
                detalle.Total = Convert.ToDecimal(OpcionTextBox.Text) * detalle.Precio;

                //A nuestra lista detalles necesitamos pasarle lo que selecionamos en detalle
                detalles.Add(detalle);

                dataGridView1.DataSource = null;

                //A nuestro DataGrid necesitamos ingresarle la lista
                dataGridView1.DataSource = detalle;

                subtotal = subtotal + detalle.Total;


                isv = subtotal * 0.15M;

                total = subtotal + isv - Convert.ToDecimal(DescuentoTextBox.Text);

                ISVTextBox.Text = isv.ToString("0.00");
                SubTotalTextBox.Text = subtotal.ToString("0.00");
                TotalTextBox.Text = total.ToString("0.00");

            }

        }
    }
}
