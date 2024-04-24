namespace presentacion
{
    partial class frmRegistroCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCompra));
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnProveedor = new Button();
            txtProveedor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            txtContacto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnProducto = new Button();
            label10 = new Label();
            txtCantidad = new TextBox();
            label8 = new Label();
            txtVenta = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtCompra = new TextBox();
            txtProducto = new TextBox();
            label9 = new Label();
            txtCodigo = new TextBox();
            pictureBox7 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnConfirmar = new Button();
            txtTotal = new TextBox();
            label11 = new Label();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(834, 543);
            label1.TabIndex = 0;
            label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnProveedor);
            groupBox1.Controls.Add(txtProveedor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(46, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion General";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(16, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2024, 4, 23, 0, 37, 40, 0);
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(272, 42);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(62, 28);
            btnProveedor.TabIndex = 4;
            btnProveedor.Text = "Buscar";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // txtProveedor
            // 
            txtProveedor.BackColor = SystemColors.ControlLight;
            txtProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtProveedor.Location = new Point(190, 73);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(125, 27);
            txtProveedor.TabIndex = 10;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(554, 48);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 9;
            label5.Text = "Direccion:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(391, 48);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 8;
            label4.Text = "Contacto:";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.ControlLight;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(554, 73);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 7;
            // 
            // txtContacto
            // 
            txtContacto.BackColor = SystemColors.ControlLight;
            txtContacto.BorderStyle = BorderStyle.FixedSingle;
            txtContacto.Location = new Point(391, 73);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 46);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 4;
            label3.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnProducto);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtVenta);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCompra);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(46, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(707, 127);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Producto";
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(49, 91);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(62, 28);
            btnProducto.TabIndex = 5;
            btnProducto.Text = "Buscar";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click_1;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(621, 33);
            label10.Name = "label10";
            label10.Size = new Size(80, 22);
            label10.TabIndex = 24;
            label10.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ControlLight;
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Location = new Point(621, 58);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(80, 27);
            txtCantidad.TabIndex = 23;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(484, 33);
            label8.Name = "label8";
            label8.Size = new Size(125, 22);
            label8.TabIndex = 22;
            label8.Text = "Precio Venta:";
            // 
            // txtVenta
            // 
            txtVenta.BackColor = SystemColors.ControlLight;
            txtVenta.BorderStyle = BorderStyle.FixedSingle;
            txtVenta.Location = new Point(484, 58);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(125, 27);
            txtVenta.TabIndex = 21;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(342, 33);
            label6.Name = "label6";
            label6.Size = new Size(125, 22);
            label6.TabIndex = 9;
            label6.Text = "Precio Compra:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(165, 33);
            label7.Name = "label7";
            label7.Size = new Size(87, 22);
            label7.TabIndex = 8;
            label7.Text = "Producto:";
            // 
            // txtCompra
            // 
            txtCompra.BackColor = SystemColors.ControlLight;
            txtCompra.BorderStyle = BorderStyle.FixedSingle;
            txtCompra.Location = new Point(342, 58);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(125, 27);
            txtCompra.TabIndex = 7;
            // 
            // txtProducto
            // 
            txtProducto.BackColor = SystemColors.ControlLight;
            txtProducto.BorderStyle = BorderStyle.FixedSingle;
            txtProducto.Location = new Point(165, 58);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(160, 27);
            txtProducto.TabIndex = 6;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 33);
            label9.Name = "label9";
            label9.Size = new Size(107, 22);
            label9.TabIndex = 2;
            label9.Text = "Cod.Producto:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ControlLight;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(16, 58);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(221, 346);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 224);
            dataGridView1.TabIndex = 21;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(759, 486);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 49);
            btnConfirmar.TabIndex = 23;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ControlLight;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(759, 453);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(94, 27);
            txtTotal.TabIndex = 24;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(763, 428);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 25;
            label11.Text = "Total:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(759, 234);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 49);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // frmRegistroCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(895, 587);
            Controls.Add(btnAgregar);
            Controls.Add(label11);
            Controls.Add(txtTotal);
            Controls.Add(btnConfirmar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox7);
            Name = "frmRegistroCompra";
            Text = "frmRegistroVenta";
            Load += frmRegistroCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        public TextBox txtDireccion;
        public TextBox txtContacto;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private TextBox txtCompra;
        public TextBox txtProducto;
        private Label label9;
        public TextBox txtCodigo;
        public TextBox txtProveedor;
        private PictureBox pictureBox7;
        private Label label8;
        private TextBox txtVenta;
        private Button btnProveedor;
        private Label label10;
        private TextBox txtCantidad;
        private Button btnProducto;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button btnConfirmar;
        private TextBox txtTotal;
        private Label label11;
        private Button btnAgregar;
    }
}