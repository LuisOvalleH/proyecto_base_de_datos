using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace presentacion
{
    public partial class Qnacho : Form
    {
        private MySqlConnection mySqlConnection;
        private string usuario;
        private Form activeChildForm;

        public Qnacho(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario; // Guardar el nombre de usuario recibido como parámetro
            string mysqlcon = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";
            mySqlConnection = new MySqlConnection(mysqlcon);
            this.MaximizeBox = false;
        }

        private void OpenConnection()
        {
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.ToString());
            }
        }

        private void CloseConnection()
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }

        private void Qnacho_Load(object sender, EventArgs e)
        {
            labelusuario.Text = usuario; // Mostrar el nombre de usuario en el Label
            OpenConnection();
            CloseConnection();
        }

        private void OpenChildForm(Form childForm)
        {
            // Cerrar cualquier formulario secundario activo
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            // Establecer el nuevo formulario como formulario activo
            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();

            // Ajustar la posición vertical del formulario secundario
            int formTop = label1.Bottom + menu.Height; // Asegurar que no se superponga al borde superior de la ventana
            childForm.Location = new Point(0, formTop);

            childForm.Show();
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene el rol de administrador
            if (EsAdmin())
            {
                // Abrir el formulario de gestión de empleados
                OpenChildForm(new frmEmpleados());
            }
            else
            {
                // Mostrar un mensaje indicando que solo los administradores pueden acceder
                MessageBox.Show("Solo los administradores pueden acceder a esta función.");
            }
        }
        private bool EsAdmin()
        {
            try
            {
                mySqlConnection.Open();

                // Consulta SQL para verificar si el usuario tiene el rol de administrador
                string query = "SELECT Rol FROM empleados WHERE Usuario = @usuario";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@usuario", usuario);
                object result = command.ExecuteScalar();

                mySqlConnection.Close();

                // Verificar si el resultado es administrador
                if (result != null && result.ToString() == "admin")
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el rol del usuario: " + ex.Message);
            }

            return false;
        }


        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientes());
        }

        private void gestionDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProducto());
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProveedores());

        }

        private frmDetalleCompra detalleCompraForm;
        private void detalleCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detalleCompraForm == null || detalleCompraForm.IsDisposed)
            {
                detalleCompraForm = new frmDetalleCompra();
                detalleCompraForm.Show();
            }
            else
            {
                detalleCompraForm.BringToFront();
            }

        }

        private frmDetalleVenta detalleVentaForm;
        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detalleVentaForm == null || detalleVentaForm.IsDisposed)
            {
                detalleVentaForm = new frmDetalleVenta();
                detalleVentaForm.Show();
            }
            else
            {
                detalleVentaForm.BringToFront();
            }
        }

        private frmRegistroCompra RegistroCompraForm;

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroCompraForm == null || RegistroCompraForm.IsDisposed)
            {
                RegistroCompraForm = new frmRegistroCompra();
                RegistroCompraForm.Show();
            }
            else
            {
                RegistroCompraForm.BringToFront();
            }
        }
        private frmRegistroVenta RegistroVentaForm;

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroVentaForm == null || RegistroVentaForm.IsDisposed)
            {
                RegistroVentaForm = new frmRegistroVenta();
                RegistroVentaForm.Show();
            }
            else
            {
                RegistroVentaForm.BringToFront();
            }
        }


    }
}