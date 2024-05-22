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
    public partial class frmElegirProveedor : Form
    {
        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmElegirProveedor()
        {
            InitializeComponent();
            this.AutoScroll = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajuste automático de las columnas
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void frmElegirProveedor_Load(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void LoadEmployeesData()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                // Consulta SQL para seleccionar solo proveedores activos
                string query = "SELECT id_proveedor, Nombre, Contacto, Direccion, Estado FROM proveedores WHERE Estado = 'Activo'";
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
                int contacto = Convert.ToInt32(row.Cells["Contacto"].Value);
                string direccion = row.Cells["Direccion"].Value.ToString();
                int idProveedor = Convert.ToInt32(row.Cells["id_proveedor"].Value); // Obtener el ID del proveedor

                // Asignar los valores a los campos en el formulario de registro de compra
                frmRegistroCompra registroCompraForm = Application.OpenForms["frmRegistroCompra"] as frmRegistroCompra;
                if (registroCompraForm != null)
                {
                    registroCompraForm.txtContacto.Text = contacto.ToString();
                    registroCompraForm.txtDireccion.Text = direccion;
                    registroCompraForm.txtProveedor.Text = nombre;
                    registroCompraForm.idProveedorSeleccionado = idProveedor; // Asignar el ID del proveedor al formulario de registro de compra
                }

                // Cerrar el formulario de elegir proveedor
                this.Close();
            }
        }

    }
}
