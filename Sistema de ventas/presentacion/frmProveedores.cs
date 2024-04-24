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


    }
}