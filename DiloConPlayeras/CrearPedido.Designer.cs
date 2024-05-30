namespace DiloConPlayeras
{
    partial class CrearPedido
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
            System.Windows.Forms.Label TitCrearPedido;
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidPedido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombreCliente = new System.Windows.Forms.TextBox();
            this.txtdireccionCliente = new System.Windows.Forms.TextBox();
            this.txtciudadCliente = new System.Windows.Forms.TextBox();
            this.txtfechaPedido = new System.Windows.Forms.TextBox();
            this.txttelefonoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.txtRestante = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.txtRFCCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxBordado = new System.Windows.Forms.CheckBox();
            this.checkBoxSerigrafia = new System.Windows.Forms.CheckBox();
            this.checkBoxVinil = new System.Windows.Forms.CheckBox();
            this.checkBoxConfeccion = new System.Windows.Forms.CheckBox();
            this.checkBoxSublimado = new System.Windows.Forms.CheckBox();
            this.checkBoxDTF = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            TitCrearPedido = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitCrearPedido
            // 
            TitCrearPedido.AutoSize = true;
            TitCrearPedido.Font = new System.Drawing.Font("Carlito", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TitCrearPedido.Location = new System.Drawing.Point(206, 9);
            TitCrearPedido.Name = "TitCrearPedido";
            TitCrearPedido.Size = new System.Drawing.Size(318, 61);
            TitCrearPedido.TabIndex = 4;
            TitCrearPedido.Text = "Pedido Nuevo";
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Location = new System.Drawing.Point(669, 999);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(94, 29);
            this.btnGuardarPedido.TabIndex = 0;
            this.btnGuardarPedido.Text = "Guardar";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orden de Pedido No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtidPedido
            // 
            this.txtidPedido.Location = new System.Drawing.Point(245, 136);
            this.txtidPedido.Name = "txtidPedido";
            this.txtidPedido.Size = new System.Drawing.Size(457, 27);
            this.txtidPedido.TabIndex = 2;
            this.txtidPedido.TextChanged += new System.EventHandler(this.txtidPedido_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(TitCrearPedido);
            this.panel1.Location = new System.Drawing.Point(39, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 79);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "RFC";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtnombreCliente
            // 
            this.txtnombreCliente.Location = new System.Drawing.Point(245, 183);
            this.txtnombreCliente.Name = "txtnombreCliente";
            this.txtnombreCliente.Size = new System.Drawing.Size(457, 27);
            this.txtnombreCliente.TabIndex = 10;
            this.txtnombreCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdireccionCliente
            // 
            this.txtdireccionCliente.Location = new System.Drawing.Point(245, 232);
            this.txtdireccionCliente.Name = "txtdireccionCliente";
            this.txtdireccionCliente.Size = new System.Drawing.Size(457, 27);
            this.txtdireccionCliente.TabIndex = 11;
            // 
            // txtciudadCliente
            // 
            this.txtciudadCliente.Location = new System.Drawing.Point(245, 283);
            this.txtciudadCliente.Name = "txtciudadCliente";
            this.txtciudadCliente.Size = new System.Drawing.Size(457, 27);
            this.txtciudadCliente.TabIndex = 12;
            // 
            // txtfechaPedido
            // 
            this.txtfechaPedido.Location = new System.Drawing.Point(245, 425);
            this.txtfechaPedido.Name = "txtfechaPedido";
            this.txtfechaPedido.Size = new System.Drawing.Size(457, 27);
            this.txtfechaPedido.TabIndex = 13;
            // 
            // txttelefonoCliente
            // 
            this.txttelefonoCliente.Location = new System.Drawing.Point(245, 331);
            this.txttelefonoCliente.Name = "txttelefonoCliente";
            this.txttelefonoCliente.Size = new System.Drawing.Size(457, 27);
            this.txttelefonoCliente.TabIndex = 14;
            this.txttelefonoCliente.TextChanged += new System.EventHandler(this.txttelefonoCliente_TextChanged);
            this.txttelefonoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttelefonoCliente_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 784);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Anticipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 784);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Restante";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(180, 784);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(211, 27);
            this.txtAnticipo.TabIndex = 17;
            this.txtAnticipo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtRestante
            // 
            this.txtRestante.Location = new System.Drawing.Point(486, 784);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Size = new System.Drawing.Size(211, 27);
            this.txtRestante.TabIndex = 18;
            this.txtRestante.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(486, 831);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(211, 27);
            this.txtHora.TabIndex = 19;
            this.txtHora.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(223, 831);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(168, 27);
            this.txtFechaEntrega.TabIndex = 20;
            this.txtFechaEntrega.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtRFCCliente
            // 
            this.txtRFCCliente.Location = new System.Drawing.Point(245, 378);
            this.txtRFCCliente.Name = "txtRFCCliente";
            this.txtRFCCliente.Size = new System.Drawing.Size(457, 27);
            this.txtRFCCliente.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 831);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha de entrega";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 831);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Hora";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 718);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "IVA";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(599, 718);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(98, 27);
            this.txtIVA.TabIndex = 26;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(599, 685);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(98, 27);
            this.txtSubtotal.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(521, 685);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Subtotal";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(521, 751);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(599, 751);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(98, 27);
            this.txtTotal.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(83, 885);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Observaciones";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // checkBoxBordado
            // 
            this.checkBoxBordado.AutoSize = true;
            this.checkBoxBordado.Location = new System.Drawing.Point(86, 918);
            this.checkBoxBordado.Name = "checkBoxBordado";
            this.checkBoxBordado.Size = new System.Drawing.Size(89, 24);
            this.checkBoxBordado.TabIndex = 31;
            this.checkBoxBordado.Text = "Bordado";
            this.checkBoxBordado.UseVisualStyleBackColor = true;
            // 
            // checkBoxSerigrafia
            // 
            this.checkBoxSerigrafia.AutoSize = true;
            this.checkBoxSerigrafia.Location = new System.Drawing.Point(195, 918);
            this.checkBoxSerigrafia.Name = "checkBoxSerigrafia";
            this.checkBoxSerigrafia.Size = new System.Drawing.Size(95, 24);
            this.checkBoxSerigrafia.TabIndex = 32;
            this.checkBoxSerigrafia.Text = "Serigrafía";
            this.checkBoxSerigrafia.UseVisualStyleBackColor = true;
            // 
            // checkBoxVinil
            // 
            this.checkBoxVinil.AutoSize = true;
            this.checkBoxVinil.Location = new System.Drawing.Point(308, 918);
            this.checkBoxVinil.Name = "checkBoxVinil";
            this.checkBoxVinil.Size = new System.Drawing.Size(60, 24);
            this.checkBoxVinil.TabIndex = 33;
            this.checkBoxVinil.Text = "Vinil";
            this.checkBoxVinil.UseVisualStyleBackColor = true;
            this.checkBoxVinil.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxConfeccion
            // 
            this.checkBoxConfeccion.AutoSize = true;
            this.checkBoxConfeccion.Location = new System.Drawing.Point(394, 918);
            this.checkBoxConfeccion.Name = "checkBoxConfeccion";
            this.checkBoxConfeccion.Size = new System.Drawing.Size(105, 24);
            this.checkBoxConfeccion.TabIndex = 34;
            this.checkBoxConfeccion.Text = "Confección";
            this.checkBoxConfeccion.UseVisualStyleBackColor = true;
            // 
            // checkBoxSublimado
            // 
            this.checkBoxSublimado.AutoSize = true;
            this.checkBoxSublimado.Location = new System.Drawing.Point(594, 918);
            this.checkBoxSublimado.Name = "checkBoxSublimado";
            this.checkBoxSublimado.Size = new System.Drawing.Size(103, 24);
            this.checkBoxSublimado.TabIndex = 35;
            this.checkBoxSublimado.Text = "Sublimado";
            this.checkBoxSublimado.UseVisualStyleBackColor = true;
            // 
            // checkBoxDTF
            // 
            this.checkBoxDTF.AutoSize = true;
            this.checkBoxDTF.Location = new System.Drawing.Point(521, 918);
            this.checkBoxDTF.Name = "checkBoxDTF";
            this.checkBoxDTF.Size = new System.Drawing.Size(56, 24);
            this.checkBoxDTF.TabIndex = 36;
            this.checkBoxDTF.Text = "DTF";
            this.checkBoxDTF.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(615, 170);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CrearPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxDTF);
            this.Controls.Add(this.checkBoxSublimado);
            this.Controls.Add(this.checkBoxConfeccion);
            this.Controls.Add(this.checkBoxVinil);
            this.Controls.Add(this.checkBoxSerigrafia);
            this.Controls.Add(this.checkBoxBordado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRFCCliente);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtRestante);
            this.Controls.Add(this.txtAnticipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefonoCliente);
            this.Controls.Add(this.txtfechaPedido);
            this.Controls.Add(this.txtciudadCliente);
            this.Controls.Add(this.txtdireccionCliente);
            this.Controls.Add(this.txtnombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtidPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarPedido);
            this.Name = "CrearPedido";
            this.Text = "CrearPedido";
            this.Load += new System.EventHandler(this.CrearPedido_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardarPedido;
        private Label label1;
        private TextBox txtidPedido;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtnombreCliente;
        private TextBox txtdireccionCliente;
        private TextBox txtciudadCliente;
        private TextBox txtfechaPedido;
        private TextBox txttelefonoCliente;
        private Label label8;
        private Label label9;
        private TextBox txtAnticipo;
        private TextBox txtRestante;
        private TextBox txtHora;
        private TextBox txtFechaEntrega;
        private TextBox txtRFCCliente;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtIVA;
        private TextBox txtSubtotal;
        private Label label13;
        private Label label14;
        private TextBox txtTotal;
        private Label label15;
        private CheckBox checkBoxBordado;
        private CheckBox checkBoxSerigrafia;
        private CheckBox checkBoxVinil;
        private CheckBox checkBoxConfeccion;
        private CheckBox checkBoxSublimado;
        private CheckBox checkBoxDTF;
        private DataGridView dataGridView1;
    }
}