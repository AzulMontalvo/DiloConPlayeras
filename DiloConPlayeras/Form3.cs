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
    public partial class Catalago : Form
    {
        private System.Windows.Forms.PictureBox picimage = new System.Windows.Forms.PictureBox();

        public Catalago()
        {
            InitializeComponent();
        }

        public static object Properties { get; private set; }

        private void Catalago_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void sudaderaHover(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.ima2;
        }

        
    }
}
