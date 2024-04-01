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
            menu = new MenuStrip();
            gestionDeProductoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeVentasToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeComprasToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            labelusuario = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.Chocolate;
            menu.Dock = DockStyle.None;
            menu.Font = new Font("Segoe UI", 10F);
            menu.ImageScalingSize = new Size(25, 25);
            menu.Items.AddRange(new ToolStripItem[] { gestionDeProductoToolStripMenuItem, gestionDeVentasToolStripMenuItem, gestionDeClientesToolStripMenuItem, gestionDeComprasToolStripMenuItem, gestionDeEmpleadosToolStripMenuItem });
            menu.Location = new Point(0, 59);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 3, 0, 3);
            menu.RenderMode = ToolStripRenderMode.System;
            menu.Size = new Size(1152, 37);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // gestionDeProductoToolStripMenuItem
            // 
            gestionDeProductoToolStripMenuItem.Image = Properties.Resources.bienes1;
            gestionDeProductoToolStripMenuItem.Name = "gestionDeProductoToolStripMenuItem";
            gestionDeProductoToolStripMenuItem.Size = new Size(206, 31);
            gestionDeProductoToolStripMenuItem.Text = "Gestion de producto";
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            gestionDeVentasToolStripMenuItem.Image = Properties.Resources.beneficio_financiero;
            gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            gestionDeVentasToolStripMenuItem.Size = new Size(185, 31);
            gestionDeVentasToolStripMenuItem.Text = "Gestion de ventas";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Image = Properties.Resources.objetivo;
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(193, 31);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            gestionDeComprasToolStripMenuItem.Image = Properties.Resources.metodo_de_pago;
            gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            gestionDeComprasToolStripMenuItem.Size = new Size(201, 31);
            gestionDeComprasToolStripMenuItem.Text = "Gestion de compras";
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            gestionDeEmpleadosToolStripMenuItem.Image = Properties.Resources.empleo;
            gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            gestionDeEmpleadosToolStripMenuItem.Size = new Size(219, 31);
            gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados";
            gestionDeEmpleadosToolStripMenuItem.Click += gestionDeEmpleadosToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1152, 59);
            label1.TabIndex = 2;
            label1.Text = "  SISTEMA DE VENTAS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_02_28_a_las_08_37_37_9d4332cd_removebg_preview;
            pictureBox1.Location = new Point(231, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(883, 19);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 5;
            label2.Text = "Usuario:";
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.BackColor = Color.ForestGreen;
            labelusuario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelusuario.ForeColor = Color.White;
            labelusuario.Location = new Point(961, 19);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(68, 23);
            labelusuario.TabIndex = 6;
            labelusuario.Text = "Usuario";
            // 
            // Qnacho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 744);
            Controls.Add(labelusuario);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "Qnacho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE VENTAS";
            Load += Qnacho_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem gestionDeProductoToolStripMenuItem;
        private ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private ToolStripMenuItem gestionDeInventarioToolStripMenuItem;
        private ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label labelusuario;
    }
}
