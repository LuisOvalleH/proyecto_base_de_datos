namespace presentacion
{
    partial class frmEmpleados
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
            label2 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOrange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(325, 635);
            label2.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.ForeColor = SystemColors.ActiveBorder;
            btnGuardar.Location = new Point(135, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(135, 512);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(807, 635);
            dataGridView1.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkOrange;
            label5.Location = new Point(104, 178);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 9;
            label5.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkOrange;
            label3.Location = new Point(151, 368);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 11;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOrange;
            label4.Location = new Point(104, 309);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 12;
            label4.Text = "Nombre de usuario";
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOrange;
            label6.Location = new Point(151, 248);
            label6.Name = "label6";
            label6.Size = new Size(45, 28);
            label6.TabIndex = 13;
            label6.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 209);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 27);
            txtNombre.TabIndex = 14;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(87, 269);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(176, 27);
            txtEdad.TabIndex = 15;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(87, 329);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(176, 27);
            txtUsuario.TabIndex = 16;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(87, 390);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(176, 27);
            txtClave.TabIndex = 17;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(858, 672);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmpleados";
            WindowState = FormWindowState.Maximized;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnGuardar;
        private Button btnActualizar;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtUsuario;
        private TextBox txtClave;
    }
}