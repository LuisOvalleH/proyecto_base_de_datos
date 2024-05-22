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
    public partial class frmDetalleVenta : Form
    {

        private string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";

        public frmDetalleVenta()
        {
            InitializeComponent();
            this.Load += frmDetalleCompra_Load;
            btnBuscar.Click += btnBuscar_Click_1;
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            LoadCompraData();
        }

        private void LoadCompraData()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                // Consulta SQL para seleccionar todas las columnas de la tabla detallecompra
                string query = "SELECT * FROM detalleventa" ;
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idVenta = Convert.ToInt32(txtId.Text);

                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                // Consulta SQL para seleccionar las filas de la tabla detallecompra con el id de compra especificado
                string query = "SELECT * FROM detalleventa WHERE ventas_idVenta = @IdVenta";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@IdVenta", idVenta);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                // Calcular el total de la compra
                decimal total = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    total += Convert.ToDecimal(row["SubTotal"]);
                }

                txtTotal.Text = total.ToString();

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message);
            }
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {

        }
    }


}

