using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace presentacion
{
    public partial class frmProveedores : Form
    {
        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmProveedores()
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
                string query = "SELECT Id_proveedor,Nombre, Contacto, Direccion, Estado FROM proveedores";
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
                int contacto = Convert.ToInt32(txtContacto.Text);
                string Direccion = txtDireccion.Text;
                string Estado = cmbEstado.Text;


                // Generar un ID aleatorio único para el nuevo empleado
                Random random = new Random();
                int id_proveedor = random.Next(100000, 999999); // ID de 6 dígitos

                // Consulta SQL para insertar un nuevo empleado con el ID generado aleatoriamente
                string query = "INSERT INTO proveedores (Id_proveedor,Nombre, Contacto, Direccion,Estado) VALUES (@Id_proveedor,@Nombre, @Contacto, @Direccion,@Estado);";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@Id_proveedor", id_proveedor);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Contacto", contacto);
                command.Parameters.AddWithValue("@Estado", Estado);
                command.Parameters.AddWithValue("@Direccion", Direccion);



                command.ExecuteNonQuery(); // Ejecutar la inserción

                MessageBox.Show("Proveedor guardado correctamente");

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    mySqlConnection.Open();

                    // Obtener el ID del proveedor seleccionado en el DataGridView
                    int idProveedor = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_proveedor"].Value);

                    // Consulta SQL para actualizar el estado del proveedor a "Activo"
                    string query = "UPDATE proveedores SET Estado = 'Activo' WHERE Id_proveedor = @idProveedor";
                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@idProveedor", idProveedor);

                    // Ejecutar la consulta de actualización
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proveedor activado correctamente");
                        // Volver a cargar los datos en el DataGridView para reflejar los cambios
                        LoadEmployeesData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo activar el proveedor");
                    }

                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al activar el proveedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para activar");
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    mySqlConnection.Open();

                    // Obtener el ID del proveedor seleccionado en el DataGridView
                    int idProveedor = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_proveedor"].Value);

                    // Consulta SQL para actualizar el estado del proveedor a "Inactivo"
                    string query = "UPDATE proveedores SET Estado = 'Inactivo' WHERE Id_proveedor = @idProveedor";
                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@idProveedor", idProveedor);

                    // Ejecutar la consulta de actualización
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proveedor deshabilitado correctamente");
                        // Volver a cargar los datos en el DataGridView para reflejar los cambios
                        LoadEmployeesData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo deshabilitar el proveedor");
                    }

                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deshabilitar el proveedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para deshabilitar");
            }

        }
    }
}