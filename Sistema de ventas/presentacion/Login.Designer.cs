namespace presentacion
{
    partial class Login
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
            label2 = new Label();
            txtdocumento = new TextBox();
            txtclave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btningresar = new Button();
            btncancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrange;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 450);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 366);
            label2.Name = "label2";
            label2.Size = new Size(237, 31);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE VENTAS";
            label2.Click += label2_Click;
            // 
            // txtdocumento
            // 
            txtdocumento.BorderStyle = BorderStyle.FixedSingle;
            txtdocumento.Location = new Point(383, 62);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(275, 27);
            txtdocumento.TabIndex = 3;
            // 
            // txtclave
            // 
            txtclave.BorderStyle = BorderStyle.FixedSingle;
            txtclave.Location = new Point(383, 178);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(275, 27);
            txtclave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 39);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btningresar
            // 
            btningresar.BackgroundImageLayout = ImageLayout.Center;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatAppearance.BorderColor = Color.Black;
            btningresar.Location = new Point(383, 282);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(117, 45);
            btningresar.TabIndex = 7;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.ForeColor = SystemColors.ControlText;
            btncancelar.Location = new Point(586, 282);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(103, 45);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Chocolate;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_04_01_a_las_13_04_39_08dae9ee;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtclave);
            Controls.Add(txtdocumento);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtdocumento;
        private TextBox txtclave;
        private Label label3;
        private Label label4;
        private Button btningresar;
        private Button btncancelar;
        private PictureBox pictureBox1;
    }
}