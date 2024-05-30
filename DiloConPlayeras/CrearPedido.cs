using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiloConPlayeras
{
    public partial class CrearPedido : Form
    {
        public CrearPedido()
        {
            InitializeComponent();
            txtidPedido.ReadOnly = true;
            MostrarSiguienteID();
            txttelefonoCliente.KeyDown += new KeyEventHandler(txttelefonoCliente_KeyDown);
        }

        private void CrearPedido_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CrearPedido_Load_1(object sender, EventArgs e)
        {
            txtfechaPedido.Text = DateTime.Now.ToString("yyyy-MM-dd"); ;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            /*ConexionBD conexion = new ConexionBD();
            conexion.abrir();
            string idCliente = txtnombreCliente.Text;
            string direccion = txtdireccionCliente.Text;
            string ciudad = txtciudadCliente.Text;
            string telefono = txttelefonoCliente.Text;
            string RFC = txtRFCCliente.Text;
            string fecha = txtfechaPedido.Text;
            /*string insertar = "insert into cliente";
                string cadena = "insert into articulos(descripcion,precio) values ('" + descri + "'," + precio + ")";
                SqlCommand comando = new SqlCommand(cadena);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                conexion.cerrar();*/
        }

        private void txtidPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefonoCliente_TextChanged(object sender, EventArgs e)
        {
        }
        private void txttelefonoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que el 'Enter' haga el sonido de 'ding'
                BuscarCliente(txttelefonoCliente.Text);
            }

        }
        private void BuscarCliente(string telefono)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                conexion.abrir();
                string query = "SELECT * FROM cliente WHERE TELEFONO = @telefono";
                SqlCommand command = new SqlCommand(query, conexion.Conectarbd);
                command.Parameters.AddWithValue("@telefono", telefono);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Suponiendo que tienes textBoxNombre, textBoxApellido, etc.
                    txtnombreCliente.Text = reader["Nombre"].ToString();
                    txtdireccionCliente.Text = reader["dirección"].ToString();
                    txtciudadCliente.Text = reader["ciudad"].ToString();
                    txtRFCCliente.Text = reader["RFC"].ToString();
                    //txtdireccionCliente.Text = reader["Apellido"].ToString();
                    // Completa con el resto de tus TextBox
                }
                else
                {
                    var result = MessageBox.Show("No se encontró el cliente. ¿Deseas agregar uno nuevo?", "Cliente no encontrado", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Lógica para agregar un nuevo cliente
                        // Por ejemplo, abrir otro formulario para ingresar los datos del nuevo cliente
                        CrearCliente nuevocliente = new CrearCliente();
                        nuevocliente.Show();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }
        private void MostrarSiguienteID()
        {
            int siguienteID = GetProximoId();
            if (siguienteID > -1)
            {
                txtidPedido.Text = siguienteID.ToString();
            }
        }
        private int GetProximoId()
        {
            ConexionBD conexion = new ConexionBD();
            int siguienteID = -1;
            try
            {
                conexion.abrir();
                string query = "SELECT IDENT_CURRENT('pedido') + 1";
                SqlCommand command = new SqlCommand(query, conexion.Conectarbd);

                siguienteID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }

            return siguienteID;
        }
    }
}

