namespace DiloConPlayeras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Catalago_Click(object sender, EventArgs e)
        {
            Catalago catalago = new Catalago();
            catalago.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentpedidos_Click(object sender, EventArgs e)
        {

            // Crea una instancia del formulario Form2
            // CrearPedido pedido = new CrearPedido();

            // Muestra el formulario Form2 como modal
            //pedido.ShowDialog();

            // En el formulario actual (Form1.cs)

            // Crea una instancia del formulario Form2
            CrearPedido pedido = new CrearPedido();

            // Muestra el formulario Form2
            pedido.Show();




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