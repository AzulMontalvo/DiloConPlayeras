namespace DiloConPlayeras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        

        private void Inventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();

        }

        private void btnVentpedidos_Click_1(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
        }

        private void Inventario_Click_1(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void Catalago_Click_1(object sender, EventArgs e)
        {
            Catalago catalago=new Catalago();
            catalago.Show();
        }
    }
}