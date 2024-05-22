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
    public partial class frmRegistroVenta : Form
    {
        private MySqlConnection mySqlConnection;
        private DataTable detalleVentaTable;
        public int idClienteSeleccionado { get; set; }


        public frmRegistroVenta()
        {
            InitializeComponent();
            // Inicializar la conexión a la base de datos
            string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";
            mySqlConnection = new MySqlConnection(connectionString);
            detalleVentaTable = new DataTable();
            InicializarTablaDetalleCompra();
            CargarDatosEnGridView();

        }

        private void InicializarTablaDetalleCompra()
        {
            // Definir las columnas de la tabla
            detalleVentaTable.Columns.Add("Producto");
            detalleVentaTable.Columns.Add("Cantidad", typeof(int));
            detalleVentaTable.Columns.Add("PrecioVenta", typeof(decimal)); // Agregar la columna "PrecioVenta"
            detalleVentaTable.Columns.Add("SubTotal", typeof(decimal));

        }

        private void CargarDatosEnGridView()
        {

            dataGridView1.DataSource = detalleVentaTable;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Obtener los datos ingresados por el usuario
            string producto = txtProducto.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precioVenta = Convert.ToDecimal(txtVenta.Text);

            // Calcular el subtotal (cantidad * precioVenta)
            decimal subtotal = cantidad * precioVenta;

            // Agregar la fila al DataTable
            detalleVentaTable.Rows.Add(producto, cantidad, precioVenta, subtotal);

            // Calcular y actualizar el total a pagar
            CalcularTotalPagar();
        }
        private void CalcularTotalPagar()
        {
            decimal totalPagar = 0;

            // Iterar a través de las filas del DataGridView y sumar los subtotales
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object subtotalValue = row.Cells["Subtotal"].Value;
                if (subtotalValue != DBNull.Value)
                {
                    totalPagar += Convert.ToDecimal(subtotalValue);
                }
            }

            // Mostrar el total a pagar en el txtTotalPagar
            txtTotal.Text = totalPagar.ToString();
        }




        private int InsertarVenta()
        {
            int idVenta = 0;
            decimal total = Convert.ToDecimal(txtTotal.Text); // Obtener el total de la venta del formulario
            string query = "CALL InsertarVenta(@Fecha, @Total, @Cliente, @IdVenta);";

            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@Fecha", DateTime.Now); // Usar la fecha actual
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@Cliente", idClienteSeleccionado);
                command.Parameters.Add(new MySqlParameter("@IdVenta", MySqlDbType.Int32));
                command.Parameters["@IdVenta"].Direction = ParameterDirection.Output;

                if (mySqlConnection.State == ConnectionState.Closed)
                    mySqlConnection.Open();

                command.ExecuteNonQuery();
                idVenta = Convert.ToInt32(command.Parameters["@IdVenta"].Value);

                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
            return idVenta;
        }

        private void InsertarDetalleVenta(int idVenta)
        {
            foreach (DataRow row in detalleVentaTable.Rows)
            {
                string nombreProducto = row["Producto"].ToString();
                int idProducto = ObtenerIdProducto(nombreProducto); // Obtener el ID del producto
                decimal precioVenta = Convert.ToDecimal(row["PrecioVenta"]);
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                decimal subtotal = Convert.ToDecimal(row["SubTotal"]);

                string query = "CALL InsertarDetalleVenta(@IdVenta, @IdProducto, @Cantidad, @Subtotal, @PrecioUnitario)";

                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@IdVenta", idVenta);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);
                    command.Parameters.AddWithValue("@PrecioUnitario", precioVenta);

                    if (mySqlConnection.State == ConnectionState.Closed)
                        mySqlConnection.Open();

                    command.ExecuteNonQuery();

                    if (mySqlConnection.State == ConnectionState.Open)
                        mySqlConnection.Close();
                }
            }
        }



        private int ObtenerIdProducto(string nombreProducto)
        {
            int idProducto = 0;
            string query = "CALL ObtenerIdProducto(@NombreProducto, @IdProducto)";

            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                command.Parameters.Add(new MySqlParameter("@IdProducto", MySqlDbType.Int32));
                command.Parameters["@IdProducto"].Direction = ParameterDirection.Output;

                if (mySqlConnection.State == ConnectionState.Closed)
                    mySqlConnection.Open();

                command.ExecuteNonQuery();
                idProducto = Convert.ToInt32(command.Parameters["@IdProducto"].Value);

                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
            return idProducto;
        }




        private frmElegirCliente ElegirClienteForm;

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            if (ElegirClienteForm == null || ElegirClienteForm.IsDisposed)
            {
                ElegirClienteForm = new frmElegirCliente();
                ElegirClienteForm.Show();
            }
            else
            {
                ElegirClienteForm.BringToFront();
            }
        }


        private frmElegirProducto1 ElegirProducto1Form;
        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            if (ElegirProducto1Form == null || ElegirProducto1Form.IsDisposed)
            {
                ElegirProducto1Form = new frmElegirProducto1();
                ElegirProducto1Form.Show();
            }
            else
            {
                ElegirProducto1Form.BringToFront();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();

                // Paso 1: Insertar datos de compra en la tabla "compras" y obtener el ID generado
                int idVenta = InsertarVenta();

                // Paso 2: Insertar detalles de la compra en la tabla "detallecompra"
                InsertarDetalleVenta(idVenta);

                MessageBox.Show("Compra registrada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
        }

        private void frmRegistroVenta_Load(object sender, EventArgs e)
        {

        }
    }
}