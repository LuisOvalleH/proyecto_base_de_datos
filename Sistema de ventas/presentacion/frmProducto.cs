using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace presentacion
{
    public partial class frmProducto : Form
    {
        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmProducto()
        {
            InitializeComponent();
            this.AutoScroll = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajuste automático de las columnas
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void LoadEmployeesData()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                // Consulta SQL para seleccionar todas las columnas excepto la columna de clave
                string query = "SELECT idProducto, Codigo, Nombre, Stock, PrecioCompra, PrecioVenta,Descripcion FROM producto";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnGuardar_Click1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                string codigo = txtCodigo.Text;

                // Generar un ID aleatorio único para el nuevo producto
                Random random = new Random();
                int idProducto = random.Next(100000, 999999); // ID de 6 dígitos

                // Consulta SQL para insertar un nuevo producto con los valores predeterminados
                string query = "INSERT INTO producto (idProducto, Codigo, Nombre, Stock, PrecioCompra, PrecioVenta, Descripcion) VALUES (@idProducto, @Codigo, @Nombre, 0, 0, 0, @Descripcion);";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                command.Parameters.AddWithValue("@Codigo", codigo);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Descripcion", descripcion);

                command.ExecuteNonQuery(); // Ejecutar la inserción

                MessageBox.Show("Producto guardado correctamente");

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}