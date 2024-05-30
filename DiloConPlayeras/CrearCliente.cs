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
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                conexion.abrir();
                string query = "INSERT INTO cliente (nombre, dirección, ciudad, telefono, RFC, correo) VALUES (@nombre, @direccion, @ciudad, @telefono, @RFC, @correo)";
                SqlCommand command = new SqlCommand(query, conexion.Conectarbd);
                command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@direccion", txtxDireccion.Text);
                command.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                command.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                command.Parameters.AddWithValue("@RFC", txtRFC.Text);
                command.Parameters.AddWithValue("@correo", txtxCorreo.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado exitosamente");
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtxDireccion.Clear();
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtRFC.Clear();
            txtxCorreo.Clear();

        }
    }
}
