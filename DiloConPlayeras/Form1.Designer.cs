namespace DiloConPlayeras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVentpedidos = new Button();
            Inventario = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Catalago = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVentpedidos
            // 
            btnVentpedidos.Location = new Point(537, 3);
            btnVentpedidos.Name = "btnVentpedidos";
            btnVentpedidos.Size = new Size(94, 29);
            btnVentpedidos.TabIndex = 0;
            btnVentpedidos.Text = "Pedidos";
            btnVentpedidos.UseVisualStyleBackColor = true;
            btnVentpedidos.Click += btnVentpedidos_Click_1;
            // 
            // Inventario
            // 
            Inventario.Location = new Point(665, 3);
            Inventario.Name = "Inventario";
            Inventario.Size = new Size(94, 29);
            Inventario.TabIndex = 1;
            Inventario.Text = "Inventario";
            Inventario.UseVisualStyleBackColor = true;
            Inventario.Click += Inventario_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 146);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(164, 39);
            label3.Name = "label3";
            label3.Size = new Size(313, 38);
            label3.TabIndex = 10;
            label3.Text = "DILO CON PLAYERAS ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 52);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 9;
            label2.Text = "639-231-6110";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(589, 16);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 8;
            label1.Text = "Dilo con playeras Delicias ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(555, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(555, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Catalago
            // 
            Catalago.Location = new Point(782, 3);
            Catalago.Name = "Catalago";
            Catalago.Size = new Size(94, 29);
            Catalago.TabIndex = 4;
            Catalago.Text = "Catalago";
            Catalago.UseVisualStyleBackColor = true;
            Catalago.Click += Catalago_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 515);
            Controls.Add(Catalago);
            Controls.Add(panel1);
            Controls.Add(Inventario);
            Controls.Add(btnVentpedidos);
            Name = "Form1";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentpedidos;
        private Button Inventario;
        private Panel panel1;
        private Button Catalago;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}