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
        public Catalago()
        {
            InitializeComponent();
        }

        private void sudaderaHover(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.sp1;

        }

        private void sudaderaF(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.sp2;

        }

        private void PlayeraF(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p1;
        }

        private void PlayeraC(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p5;
        }

        private void PlayeraD(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p3;
        }

        private void PlayeraP(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p4;
        }

        private void PlayeraA(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p2;
        }

        private void UniformeR(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.ima1;
        }

        private void UniformeB(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u2;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void UniformeBar(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u3;

        }
    }
}
