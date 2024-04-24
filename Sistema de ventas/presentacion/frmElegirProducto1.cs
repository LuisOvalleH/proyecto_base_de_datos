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
    public partial class frmElegirProducto1 : Form
    {
        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmElegirProducto1()
        {
            InitializeComponent();
            this.AutoScroll = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void frmElegirProducto_Load(object sender, EventArgs e)
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
                string query = "SELECT Codigo, Nombre,PrecioVenta, Descripcion FROM producto";
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
                string codigo = row.Cells["Codigo"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();
                string PrecioVenta = row.Cells["PrecioVenta"].Value.ToString();


                // Asignar los valores a los campos en el formulario de registro de compra
                frmRegistroVenta registroVentaForm = Application.OpenForms["frmRegistroVenta"] as frmRegistroVenta;
                if (registroVentaForm != null)
                {
                    registroVentaForm.txtCodigo.Text = codigo.ToString();
                    registroVentaForm.txtProducto.Text = nombre.ToString();
                    registroVentaForm.txtVenta.Text = PrecioVenta.ToString();



                }

                // Cerrar el formulario de elegir proveedor
                this.Close();
            }
        }

    }
}
