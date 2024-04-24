namespace presentacion
{
    partial class Qnacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qnacho));
            menu = new MenuStrip();
            gestionDeProductoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeVentasToolStripMenuItem = new ToolStripMenuItem();
            registrarVentaToolStripMenuItem = new ToolStripMenuItem();
            detalleVentasToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeComprasToolStripMenuItem = new ToolStripMenuItem();
            registrarCompraToolStripMenuItem = new ToolStripMenuItem();
            detalleCompraToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            label2 = new Label();
            labelusuario = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            menu.SuspendLayout();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(255, 128, 0);
            menu.Dock = DockStyle.None;
            menu.Font = new Font("Segoe UI", 10F);
            menu.ImageScalingSize = new Size(25, 25);
            menu.Items.AddRange(new ToolStripItem[] { gestionDeProductoToolStripMenuItem, gestionDeVentasToolStripMenuItem, gestionDeClientesToolStripMenuItem, gestionDeComprasToolStripMenuItem, gestionDeEmpleadosToolStripMenuItem, gestionDeProveedoresToolStripMenuItem });
            menu.Location = new Point(0, 50);
            menu.Name = "menu";
            menu.Padding = new Padding(20, 3, 30, 3);
            menu.RenderMode = ToolStripRenderMode.System;
            menu.Size = new Size(1285, 37);
            menu.TabIndex = 0;
            menu.Text = "menu";
            menu.ItemClicked += menu_ItemClicked;
            // 
            // gestionDeProductoToolStripMenuItem
            // 
            gestionDeProductoToolStripMenuItem.Image = Properties.Resources.bienes1;
            gestionDeProductoToolStripMenuItem.Name = "gestionDeProductoToolStripMenuItem";
            gestionDeProductoToolStripMenuItem.Size = new Size(206, 31);
            gestionDeProductoToolStripMenuItem.Text = "Gestion de producto";
            gestionDeProductoToolStripMenuItem.Click += gestionDeProductoToolStripMenuItem_Click;
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            gestionDeVentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarVentaToolStripMenuItem, detalleVentasToolStripMenuItem });
            gestionDeVentasToolStripMenuItem.Image = Properties.Resources.beneficio_financiero;
            gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            gestionDeVentasToolStripMenuItem.Size = new Size(185, 31);
            gestionDeVentasToolStripMenuItem.Text = "Gestion de ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            registrarVentaToolStripMenuItem.Size = new Size(224, 28);
            registrarVentaToolStripMenuItem.Text = "Registrar venta";
            registrarVentaToolStripMenuItem.Click += registrarVentaToolStripMenuItem_Click;
            // 
            // detalleVentasToolStripMenuItem
            // 
            detalleVentasToolStripMenuItem.Name = "detalleVentasToolStripMenuItem";
            detalleVentasToolStripMenuItem.Size = new Size(224, 28);
            detalleVentasToolStripMenuItem.Text = "Detalle Ventas";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Image = Properties.Resources.objetivo;
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(193, 31);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            gestionDeClientesToolStripMenuItem.Click += gestionDeClientesToolStripMenuItem_Click;
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            gestionDeComprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarCompraToolStripMenuItem, detalleCompraToolStripMenuItem });
            gestionDeComprasToolStripMenuItem.Image = Properties.Resources.metodo_de_pago;
            gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            gestionDeComprasToolStripMenuItem.Size = new Size(201, 31);
            gestionDeComprasToolStripMenuItem.Text = "Gestion de compras";
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(227, 28);
            registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            registrarCompraToolStripMenuItem.Click += registrarCompraToolStripMenuItem_Click;
            // 
            // detalleCompraToolStripMenuItem
            // 
            detalleCompraToolStripMenuItem.Name = "detalleCompraToolStripMenuItem";
            detalleCompraToolStripMenuItem.Size = new Size(227, 28);
            detalleCompraToolStripMenuItem.Text = "Detalle Compras";
            detalleCompraToolStripMenuItem.Click += detalleCompraToolStripMenuItem_Click;
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            gestionDeEmpleadosToolStripMenuItem.Image = Properties.Resources.empleo;
            gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            gestionDeEmpleadosToolStripMenuItem.Size = new Size(219, 31);
            gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados";
            gestionDeEmpleadosToolStripMenuItem.Click += gestionDeEmpleadosToolStripMenuItem_Click;
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            gestionDeProveedoresToolStripMenuItem.Image = Properties.Resources.bienes1;
            gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            gestionDeProveedoresToolStripMenuItem.Size = new Size(230, 31);
            gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            gestionDeProveedoresToolStripMenuItem.Click += gestionDeProveedoresToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(labelusuario);
            panelPrincipal.Controls.Add(pictureBox5);
            panelPrincipal.Controls.Add(pictureBox4);
            panelPrincipal.Controls.Add(pictureBox3);
            panelPrincipal.Controls.Add(pictureBox2);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(pictureBox7);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1246, 744);
            panelPrincipal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(947, 14);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 5;
            label2.Text = "Usuario:";
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.BackColor = Color.Orange;
            labelusuario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelusuario.ForeColor = Color.White;
            labelusuario.Location = new Point(1042, 14);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(68, 23);
            labelusuario.TabIndex = 6;
            labelusuario.Text = "Usuario";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Orange;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(731, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(62, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Orange;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(849, -10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Orange;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(361, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(494, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Orange;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(259, -18);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(62, 60);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, -5);
            label1.Name = "label1";
            label1.Size = new Size(1285, 59);
            label1.TabIndex = 2;
            label1.Text = "  SISTEMA DE VENTAS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Qnacho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1246, 744);
            Controls.Add(menu);
            Controls.Add(panelPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "Qnacho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE VENTAS";
            Load += Qnacho_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private MenuStrip menu;
        private ToolStripMenuItem gestionDeProductoToolStripMenuItem;
        private ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private ToolStripMenuItem gestionDeInventarioToolStripMenuItem;
        private ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;

        private Label label1;
        private Label label2;
        private Label labelusuario;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem detalleCompraToolStripMenuItem;
        private ToolStripMenuItem registrarVentaToolStripMenuItem;
        private ToolStripMenuItem detalleVentasToolStripMenuItem;
    }
}