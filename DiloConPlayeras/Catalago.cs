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



        private void UniformeBar(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u3;

        }



        private void SudNa(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.s4;
        }



        private void sudPers(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.s5;

        }

        private void SudEqu(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.suadera_e;

        }

        private void SudAn(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.s3;

        }

        private void sudN2(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.s8;
        }

        private void sudAmi(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.s7;
        }

        private void PlayeraPa(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p10;
        }

        private void playeraEquipos(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p11;
        }

        private void PlayeraMex(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.p12;

        }

        private void UniformesEqui(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u13;
        }

        private void UniformesB(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u10;
        }



        private void uniformesT(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u12;

        }

        private void UniformeG(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u14;
        }

        private void UniU(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.u15;

        }

        private void Gorra1(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.g1;


        }

        private void g2(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.g2;

        }

        private void g3(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.g3;
        }

        private void g4(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.g4;
        }

        private void g5(object sender, EventArgs e)
        {
            ImageBox.Image = DiloConPlayeras.Properties.Resources.g5;
        }
    }
}
