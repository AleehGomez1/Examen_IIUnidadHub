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
    public partial class Tipos : Syncfusion.Windows.Forms.Office2010Form    
    {
        public Tipos()
        {
            InitializeComponent();
        }

        private void Tipos_Load(object sender, EventArgs e)
        {

        }

        private void SoporteCelularButton_Click(object sender, EventArgs e)
        {
            Tickets ticketsform = new Tickets();
            ticketsform.Show(); 
        }

        private void SoporteComputoButton_Click(object sender, EventArgs e)
        {
            Tickets ticketsform = new Tickets();
            ticketsform.Show();
        }
    }
}
