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
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.Location = new Point(40, 12);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(568, 482);
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(811, 48);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Sudaderas";
            label1.Click += label1_Click;
            label1.MouseHover += sudaderaHover;
            // 
            // Catalago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 625);
            Controls.Add(label1);
            Controls.Add(ImageBox);
            Name = "Catalago";
            Text = "Catalago";
            Load += Catalago_Load;
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImageBox;
        private Label label1;
    }
}