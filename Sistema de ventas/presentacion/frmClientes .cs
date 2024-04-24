using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace presentacion
{
    public partial class frmClientes : Form
    {
        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmClientes()
        {
            InitializeComponent();
            this.AutoScroll = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajuste automático de las columnas
        }

        private void frmClientes_Load(object sender, EventArgs e)
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
                string query = "SELECT idCliente,Nit, Nombre, Apellidos, Telefono FROM clientes";
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

                string Nombre = txtNombre.Text;
                string Apellidos = txtApellidos.Text;
                int Telefono = Convert.ToInt32(txtTelefono.Text);
                string Nit = txtNit.Text;


                // Generar un ID aleatorio único para el nuevo empleado
                Random random = new Random();
                int idCliente = random.Next(100000, 999999); // ID de 6 dígitos

                // Consulta SQL para insertar un nuevo empleado con el ID generado aleatoriamente
                string query = "INSERT INTO clientes (idCliente,Nit, Nombre, Apellidos,Telefono) VALUES ( @IdCliente, @Nit, @Nombre, @Apellidos,@Telefono);";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                command.Parameters.AddWithValue("@Nit", Nit);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellidos", Apellidos);
                command.Parameters.AddWithValue("@Telefono", Telefono);


                command.ExecuteNonQuery(); // Ejecutar la inserción

                MessageBox.Show("Empleado guardado correctamente");

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    mySqlConnection.Open();

                    // Obtener el ID del empleado seleccionado en el DataGridView
                    int idEmpleado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idEmpleados"].Value);

                    // Consulta SQL para eliminar el empleado seleccionado
                    string query = "DELETE FROM empleados WHERE idEmpleados = @idEmpleado";
                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                    // Ejecutar la consulta de eliminación
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado eliminado correctamente");
                        // Volver a cargar los datos en el DataGridView para reflejar los cambios
                        LoadEmployeesData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el empleado");
                    }

                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar");
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            // Crear un objeto de cifrado SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Calcular el hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convertir el arreglo de bytes a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}