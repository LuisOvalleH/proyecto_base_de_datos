namespace presentacion
{
    partial class frmDetalleVenta
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            txtTotal = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(796, 596);
            label1.TabIndex = 1;
            label1.Text = "HISTORIAL VENTAS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 467);
            dataGridView1.TabIndex = 2;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(585, 580);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 26;
            label11.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ControlLight;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(637, 578);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(94, 27);
            txtTotal.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(585, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 28;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(585, 29);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 29;
            label2.Text = "Buscar por Id:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(719, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 28);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(847, 644);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "frmDetalleVenta";
            Text = "detalleVentas";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label11;
        private TextBox txtTotal;
        public TextBox txtId;
        private Label label2;
        private Button btnBuscar;
    }
}