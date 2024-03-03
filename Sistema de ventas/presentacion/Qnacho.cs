using MySql.Data.MySqlClient;
using System.Data;

namespace presentacion
{
    public partial class Qnacho : Form
    {
        private MySqlConnection mySqlConnection;

        public Qnacho()
        {
            InitializeComponent();
            string mysqlcon = "server= 127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";
            mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void OpenConnection()
        {
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Conexión establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.ToString());
            }
        }

        private void CloseConnection()
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
                MessageBox.Show("Conexión cerrada");
            }
        }

        private void Qnacho_Load(object sender, EventArgs e)
        {
            OpenConnection();
        }

        // Si necesitas cerrar la conexión en algún momento, puedes llamar al método CloseConnection()
    }
}