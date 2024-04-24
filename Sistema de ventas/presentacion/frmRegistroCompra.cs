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
    public partial class frmRegistroCompra : Form
    {
        private MySqlConnection mySqlConnection;
        private DataTable detalleCompraTable;
        public int idProveedorSeleccionado { get; set; }


        public frmRegistroCompra()
        {
            InitializeComponent();
            // Inicializar la conexión a la base de datos
            string connectionString = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";
            mySqlConnection = new MySqlConnection(connectionString);
            detalleCompraTable = new DataTable();
            InicializarTablaDetalleCompra();
            CargarDatosEnGridView();

        }

        private void InicializarTablaDetalleCompra()
        {
            // Definir las columnas de la tabla
            detalleCompraTable.Columns.Add("Producto");
            detalleCompraTable.Columns.Add("Cantidad", typeof(int));
            detalleCompraTable.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompraTable.Columns.Add("PrecioVenta", typeof(decimal)); // Agregar la columna "PrecioVenta"
            detalleCompraTable.Columns.Add("SubTotal", typeof(decimal));

        }

        private void CargarDatosEnGridView()
        {

            dataGridView1.DataSource = detalleCompraTable;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Agregar los datos ingresados por el usuario a la tabla de detalle de compra
            DataRow row = detalleCompraTable.NewRow();
            row["Producto"] = txtProducto.Text; // Obtener el nombre del producto del formulario
            row["Cantidad"] = Convert.ToInt32(txtCantidad.Text); // Obtener la cantidad del formulario
            row["PrecioCompra"] = Convert.ToDecimal(txtCompra.Text); // Obtener el precio de compra del formulario
            row["PrecioVenta"] = Convert.ToDecimal(txtVenta.Text); // Obtener el precio de compra del formulario
            row["SubTotal"] = Convert.ToInt32(txtCantidad.Text) * Convert.ToDecimal(txtCompra.Text); // Calcular el total
                                                                                                     // Calcular el subtotal
            decimal subtotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtCompra.Text);

            // Agregar la fila al DataGridView
            detalleCompraTable.Rows.Add(txtProducto.Text, txtCantidad.Text, txtCompra.Text, txtVenta.Text, subtotal);

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

        private frmElegirProveedor ElegirProveedorForm;

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (ElegirProveedorForm == null || ElegirProveedorForm.IsDisposed)
            {
                ElegirProveedorForm = new frmElegirProveedor();
                ElegirProveedorForm.Show();
            }
            else
            {
                ElegirProveedorForm.BringToFront();
            }
        }


        private frmElegirProducto ElegirProductoForm;
        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            if (ElegirProductoForm == null || ElegirProductoForm.IsDisposed)
            {
                ElegirProductoForm = new frmElegirProducto();
                ElegirProductoForm.Show();
            }
            else
            {
                ElegirProductoForm.BringToFront();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();

                // Paso 1: Insertar datos de compra en la tabla "compras" y obtener el ID generado
                int idCompra = InsertarCompra();

                // Paso 2: Insertar detalles de la compra en la tabla "detallecompra"
                InsertarDetalleCompra(idCompra);

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
        private int InsertarCompra()
        {
            int idCompra = 0;
            decimal total = Convert.ToDecimal(txtTotal.Text); // Obtener el total de la compra del formulario
            string query = "INSERT INTO compras (Fecha, Total, proveedores_Id_proveedor) " +
                           "VALUES (@Fecha, @Total, @Proveedor); SELECT LAST_INSERT_ID();";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@Fecha", DateTime.Now); // Usar la fecha actual
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@Proveedor", idProveedorSeleccionado);

                idCompra = Convert.ToInt32(command.ExecuteScalar());
            }
            return idCompra;
        }
        private void InsertarDetalleCompra(int idCompra)
        {
            // Iterar a través de las filas de la DataTable para insertar cada detalle de compra
            foreach (DataRow row in detalleCompraTable.Rows)
            {
                int idProducto = ObtenerIdProducto(row["Producto"].ToString()); // Obtener el ID del producto
                decimal precioCompra = Convert.ToDecimal(row["PrecioCompra"]);
                decimal precioVenta = Convert.ToDecimal(row["PrecioVenta"]);
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                decimal subtotal = Convert.ToDecimal(row["Subtotal"]);

                string query = "INSERT INTO detallecompra (compras_IdCompra, productos_IdProducto, PrecioUnitario, PrecioVenta, Cantidad, Total) " +
                               "VALUES (@IdCompra, @IdProducto, @PrecioCompra, @PrecioVenta, @Cantidad, @Subtotal)";
                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@IdCompra", idCompra);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    command.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                    command.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);

                    command.ExecuteNonQuery();
                }
                // Actualizar el stock en la tabla producto
                int stockActual = ObtenerStockActual(idProducto);
                int nuevoStock = stockActual + cantidad;
                string actualizarStockQuery = "UPDATE producto SET Stock = @NuevoStock, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta WHERE idProducto = @IdProducto";
                using (MySqlCommand actualizarStockCommand = new MySqlCommand(actualizarStockQuery, mySqlConnection))
                {
                    actualizarStockCommand.Parameters.AddWithValue("@NuevoStock", nuevoStock);
                    actualizarStockCommand.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                    actualizarStockCommand.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                    actualizarStockCommand.Parameters.AddWithValue("@IdProducto", idProducto);

                    actualizarStockCommand.ExecuteNonQuery();
                }

            }
        }

        private int ObtenerStockActual(int idProducto)
        {
            int stockActual = 0;
            string query = "SELECT Stock FROM producto WHERE idProducto = @IdProducto";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    stockActual = Convert.ToInt32(result);
                }
            }
            return stockActual;
        }

        private int ObtenerIdProducto(string nombreProducto)
        {
            Console.WriteLine("Nombre del producto a buscar: " + nombreProducto);

            int idProducto = 0;
            string query = "SELECT idProducto FROM producto WHERE Nombre = @Nombre";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@Nombre", nombreProducto);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    idProducto = Convert.ToInt32(result);
                    Console.WriteLine("ID del producto encontrado: " + idProducto);
                }
                else
                {
                    Console.WriteLine("No se encontró ningún producto con el nombre proporcionado.");
                }
            }
            return idProducto;
        }

        private void frmRegistroCompra_Load(object sender, EventArgs e)
        {

        }
    }
}