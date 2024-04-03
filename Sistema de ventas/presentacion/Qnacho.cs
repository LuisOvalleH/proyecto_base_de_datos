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
                MessageBox.Show("Conexión establecida");
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
                MessageBox.Show("Conexión cerrada");
            }
        }
        private void Qnacho_Load(object sender, EventArgs e)
        {
            labelusuario.Text = usuario; // Mostrar el nombre de usuario en el Label
            OpenConnection();
            CloseConnection();
        }



        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmEmpleados
            frmEmpleados formEmpleados = new frmEmpleados();

            // Establecer el formulario de empleados como formulario secundario de Qnacho
            formEmpleados.MdiParent = this;
            // Ajustar el tamaño del formulario para que no sobrepase el ancho del MenuStrip y respete la altura disponible
            int formWidth = Math.Min(panelPrincipal.Width, this.ClientSize.Width);
            int formHeight = this.ClientSize.Height - menu.Height;
            formEmpleados.Size = new Size(formWidth, formHeight);

            // Mostrar el formulario de empleados
            formEmpleados.Show();
            // Ajustar la posición del formulario para que aparezca debajo del MenuStrip y el título "SISTEMA DE VENTAS"
            int formTop = label1.Bottom + menu.Height; // Asegurar que no se superponga al borde superior de la ventana
            formEmpleados.Location = new Point(0, formTop);

            // Establecer el formulario frmEmpleados como un control secundario del Panel
            formEmpleados.TopLevel = false; // Indicar que no es un formulario independiente
            panelPrincipal.Controls.Add(formEmpleados); // Agregar el formulario al Panel
            formEmpleados.Dock = DockStyle.Fill; // Hacer que el formulario llene todo el espacio del Panel

            // Mostrar el formulario frmEmpleados
            formEmpleados.Show();
        }
    }
}