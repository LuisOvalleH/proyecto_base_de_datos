using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace presentacion
{
    public partial class frmElegirCliente : Form
    {
        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmElegirCliente()
        {
            InitializeComponent();
            this.AutoScroll = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajuste automático de las columnas
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void frmElegirCliente_Load(object sender, EventArgs e)
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
                string query = "SELECT idCliente,Nombre, Apellidos, Nit FROM clientes";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Obtener los valores de la fila seleccionada
                string nombre = row.Cells["Nombre"].Value.ToString();
                string nit = row.Cells["Nit"].Value.ToString();
                string apellidos = row.Cells["Apellidos"].Value.ToString();
                int idCliente = Convert.ToInt32(row.Cells["idCliente"].Value); // Obtener el ID del proveedor

                // Asignar los valores a los campos en el formulario de registro de compra
                frmRegistroVenta RegistroVentaForm = Application.OpenForms["frmRegistroVenta"] as frmRegistroVenta;
                if (RegistroVentaForm != null)
                {
                    RegistroVentaForm.txtNit.Text = nit.ToString();
                    RegistroVentaForm.txtApellidos.Text = apellidos;
                    RegistroVentaForm.txtCliente.Text = nombre;
                    RegistroVentaForm.idClienteSeleccionado = idCliente; // Asignar el ID del proveedor al formulario de registro de compra
                }

                // Cerrar el formulario de elegir proveedor
                this.Close();
            }
        }

        private void frmElegirCliente_Load_1(object sender, EventArgs e)
        {

        }
    }
}
