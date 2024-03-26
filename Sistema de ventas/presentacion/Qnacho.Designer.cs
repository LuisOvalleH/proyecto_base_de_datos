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
            menuStrip1 = new MenuStrip();
            gestionDeProductoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeVentasToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeComprasToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Chocolate;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(25, 25);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDeProductoToolStripMenuItem, gestionDeVentasToolStripMenuItem, gestionDeClientesToolStripMenuItem, gestionDeComprasToolStripMenuItem, gestionDeEmpleadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1008, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductoToolStripMenuItem
            // 
            gestionDeProductoToolStripMenuItem.Image = Properties.Resources.bienes1;
            gestionDeProductoToolStripMenuItem.Name = "gestionDeProductoToolStripMenuItem";
            gestionDeProductoToolStripMenuItem.Size = new Size(172, 29);
            gestionDeProductoToolStripMenuItem.Text = "Gestion de producto";
            gestionDeProductoToolStripMenuItem.Click += gestionDeProductoToolStripMenuItem_Click;
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            gestionDeVentasToolStripMenuItem.Image = Properties.Resources.beneficio_financiero;
            gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            gestionDeVentasToolStripMenuItem.Size = new Size(156, 29);
            gestionDeVentasToolStripMenuItem.Text = "Gestion de ventas";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Image = Properties.Resources.objetivo;
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(161, 29);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            gestionDeComprasToolStripMenuItem.Image = Properties.Resources.metodo_de_pago;
            gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            gestionDeComprasToolStripMenuItem.Size = new Size(168, 29);
            gestionDeComprasToolStripMenuItem.Text = "Gestion de compras";
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            gestionDeEmpleadosToolStripMenuItem.Image = Properties.Resources.empleo;
            gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            gestionDeEmpleadosToolStripMenuItem.Size = new Size(182, 29);
            gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados";
            gestionDeEmpleadosToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_02_28_a_las_08_371;
            pictureBox1.Location = new Point(250, 40);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(859, 136);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(859, 248);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Qnacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 558);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Qnacho";
            Text = "Qnacho";
            Load += Qnacho_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDeProductoToolStripMenuItem;
        private ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private ToolStripMenuItem gestionDeInventarioToolStripMenuItem;
        private ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}
