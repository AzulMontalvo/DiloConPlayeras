using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiloConPlayeras
{
    internal class ConexionBD
    {
        string cadena = "data source = LAPTOP-NFPFVF06\\SQLPRACTICAS; initial catalog = dcp; user id = sa; password = 16akmc26?";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public ConexionBD()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                MessageBox.Show("Conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir BD " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}
