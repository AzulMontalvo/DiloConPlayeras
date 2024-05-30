using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiloConPlayeras
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            CrearPedido nuevopedido = new CrearPedido();
            nuevopedido.Show();
        }
    }
}
