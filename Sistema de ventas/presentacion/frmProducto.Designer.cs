﻿namespace presentacion
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            label2 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label7 = new Label();
            pictureBox23 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            txtCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOrange;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(325, 644);
            label2.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.ForeColor = SystemColors.ActiveBorder;
            btnGuardar.Location = new Point(125, 399);
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
            btnActualizar.Location = new Point(125, 446);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(343, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(895, 524);
            dataGridView1.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.Orange;
            label5.Location = new Point(87, 72);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 9;
            label5.Text = "Codigo";
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.Location = new Point(87, 287);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 11;
            label3.Text = "Descripcion";
            // 
            // label6
            // 
            label6.BackColor = Color.Orange;
            label6.Location = new Point(87, 182);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 213);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 27);
            txtNombre.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(87, 318);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(176, 27);
            txtDescripcion.TabIndex = 17;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.Location = new Point(46, 19);
            label1.Name = "label1";
            label1.Size = new Size(271, 596);
            label1.TabIndex = 19;
            // 
            // label7
            // 
            label7.BackColor = Color.Orange;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(74, 30);
            label7.Name = "label7";
            label7.Size = new Size(215, 29);
            label7.TabIndex = 20;
            label7.Text = "REGISTRO PRODUCTO";
            // 
            // pictureBox23
            // 
            pictureBox23.BackColor = Color.Orange;
            pictureBox23.Image = (Image)resources.GetObject("pictureBox23.Image");
            pictureBox23.Location = new Point(207, 136);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(35, 35);
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox23.TabIndex = 35;
            pictureBox23.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, 373);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Orange;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Orange;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(161, 249);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.AppWorkspace;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(343, 8);
            label8.Name = "label8";
            label8.Size = new Size(895, 110);
            label8.TabIndex = 40;
            label8.Text = "Lista de Productos:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Click += label8_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(87, 103);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(176, 27);
            txtCodigo.TabIndex = 41;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1311, 672);
            Controls.Add(txtCodigo);
            Controls.Add(label8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox23);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmpleados";
            WindowState = FormWindowState.Maximized;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private TextBox txtDescripcion;
        private Label label1;
        private Label label7;
        private PictureBox pictureBox23;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label8;
        private TextBox txtCodigo;
    }
}