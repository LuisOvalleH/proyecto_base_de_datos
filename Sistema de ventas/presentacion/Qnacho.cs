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
            frmEmpleados formEmpleados = new frmEmpleados();

            // Establecer el formulario de empleados como formulario secundario de Qnacho
            formEmpleados.MdiParent = this;

            // Mostrar el formulario de empleados
            formEmpleados.Show();

        }
    }
}