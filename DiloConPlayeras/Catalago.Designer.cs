namespace DiloConPlayeras
{
    partial class Catalago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImageBox = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.Image = Properties.Resources.WhatsApp_Image_2024_05_10_at_4_24_43_PM;
            ImageBox.Location = new Point(62, 49);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(551, 460);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(694, 49);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "SUDADERAS";
            // 
            // button1
            // 
            button1.Location = new Point(694, 89);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 2;
            button1.Text = "Personalizada";
            button1.UseVisualStyleBackColor = true;
            button1.MouseHover += sudaderaHover;
            // 
            // button2
            // 
            button2.Location = new Point(694, 140);
            button2.Name = "button2";
            button2.Size = new Size(115, 29);
            button2.TabIndex = 3;
            button2.Text = "Familiar";
            button2.UseVisualStyleBackColor = true;
            button2.MouseHover += sudaderaF;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Location = new Point(873, 49);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "PLAYERAS";
            // 
            // button3
            // 
            button3.Location = new Point(852, 89);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 5;
            button3.Text = "Frases";
            button3.UseVisualStyleBackColor = true;
            button3.MouseHover += PlayeraF;
            // 
            // button4
            // 
            button4.Location = new Point(852, 140);
            button4.Name = "button4";
            button4.Size = new Size(112, 29);
            button4.TabIndex = 6;
            button4.Text = "Combo";
            button4.UseVisualStyleBackColor = true;
            button4.MouseHover += PlayeraC;
            // 
            // button5
            // 
            button5.Location = new Point(852, 193);
            button5.Name = "button5";
            button5.Size = new Size(112, 29);
            button5.TabIndex = 7;
            button5.Text = "Deportiva";
            button5.UseVisualStyleBackColor = true;
            button5.MouseHover += PlayeraD;
            // 
            // button6
            // 
            button6.Location = new Point(852, 240);
            button6.Name = "button6";
            button6.Size = new Size(112, 29);
            button6.TabIndex = 8;
            button6.Text = "Personalizada";
            button6.UseVisualStyleBackColor = true;
            button6.MouseHover += PlayeraP;
            // 
            // button7
            // 
            button7.Location = new Point(852, 297);
            button7.Name = "button7";
            button7.Size = new Size(112, 29);
            button7.TabIndex = 9;
            button7.Text = "Animadas";
            button7.UseVisualStyleBackColor = true;
            button7.MouseHover += PlayeraA;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Location = new Point(1004, 50);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 10;
            label3.Text = "UNIFORMES";
            // 
            // button8
            // 
            button8.Location = new Point(1004, 89);
            button8.Name = "button8";
            button8.Size = new Size(102, 29);
            button8.TabIndex = 11;
            button8.Text = "Balñeario";
            button8.UseVisualStyleBackColor = true;
            button8.MouseHover += UniformeB;
            // 
            // button9
            // 
            button9.Location = new Point(1004, 140);
            button9.Name = "button9";
            button9.Size = new Size(102, 29);
            button9.TabIndex = 12;
            button9.Text = "Barberia";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            button9.MouseHover += UniformeBar;
            // 
            // button10
            // 
            button10.Location = new Point(1004, 193);
            button10.Name = "button10";
            button10.Size = new Size(102, 29);
            button10.TabIndex = 13;
            button10.Text = "Restaurante";
            button10.UseVisualStyleBackColor = true;
            button10.MouseHover += UniformeR;
            // 
            // Catalago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 678);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ImageBox);
            Name = "Catalago";
            Text = "Depotiva";
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImageBox;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label3;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}