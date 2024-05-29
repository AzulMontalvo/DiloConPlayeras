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
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.Image = Properties.Resources.WhatsApp_Image_2024_05_10_at_4_24_43_PM;
            ImageBox.Location = new Point(40, 111);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(598, 474);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(678, 138);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "SUDADERAS";
            // 
            // button1
            // 
            button1.Location = new Point(678, 181);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 2;
            button1.Text = "Personalizada";
            button1.UseVisualStyleBackColor = true;
            button1.MouseHover += sudaderaHover;
            // 
            // button2
            // 
            button2.Location = new Point(678, 231);
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
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(852, 139);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 4;
            label2.Text = "PLAYERAS";
            // 
            // button3
            // 
            button3.Location = new Point(852, 181);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 5;
            button3.Text = "Frases";
            button3.UseVisualStyleBackColor = true;
            button3.MouseHover += PlayeraF;
            // 
            // button4
            // 
            button4.Location = new Point(852, 231);
            button4.Name = "button4";
            button4.Size = new Size(112, 29);
            button4.TabIndex = 6;
            button4.Text = "Combo";
            button4.UseVisualStyleBackColor = true;
            button4.MouseHover += PlayeraC;
            // 
            // button5
            // 
            button5.Location = new Point(852, 287);
            button5.Name = "button5";
            button5.Size = new Size(112, 29);
            button5.TabIndex = 7;
            button5.Text = "Deportiva";
            button5.UseVisualStyleBackColor = true;
            button5.MouseHover += PlayeraD;
            // 
            // button6
            // 
            button6.Location = new Point(852, 341);
            button6.Name = "button6";
            button6.Size = new Size(112, 29);
            button6.TabIndex = 8;
            button6.Text = "Personalizada";
            button6.UseVisualStyleBackColor = true;
            button6.MouseHover += PlayeraP;
            // 
            // button7
            // 
            button7.Location = new Point(852, 396);
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
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1014, 138);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 10;
            label3.Text = "UNIFORMES";
            // 
            // button8
            // 
            button8.Location = new Point(1014, 181);
            button8.Name = "button8";
            button8.Size = new Size(102, 29);
            button8.TabIndex = 11;
            button8.Text = "Balñeario";
            button8.UseVisualStyleBackColor = true;
            button8.MouseHover += UniformeB;
            // 
            // button9
            // 
            button9.Location = new Point(1014, 231);
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
            button10.Location = new Point(1014, 287);
            button10.Name = "button10";
            button10.Size = new Size(102, 29);
            button10.TabIndex = 13;
            button10.Text = "Restaurante";
            button10.UseVisualStyleBackColor = true;
            button10.MouseHover += UniformeR;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1309, 87);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(603, 14);
            label4.Name = "label4";
            label4.Size = new Size(234, 58);
            label4.TabIndex = 0;
            label4.Text = "Catalago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1181, 138);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 15;
            label5.Text = "GORRAS";
            // 
            // Catalago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 678);
            Controls.Add(label5);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label4;
        private Label label5;
    }
}