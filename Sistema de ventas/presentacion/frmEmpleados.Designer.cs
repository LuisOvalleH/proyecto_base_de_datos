﻿namespace presentacion
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 183);
            label1.Name = "label1";
            label1.Size = new Size(440, 41);
            label1.TabIndex = 0;
            label1.Text = "Soy el formulario de empleados";
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(621, 442);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmpleados";
            WindowState = FormWindowState.Maximized;
            Load += frmEmpleados_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}