using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace presentacion
{
    public partial class Login : Form
    {
        private MySqlConnection mySqlConnection;

        public Login()
        {
            InitializeComponent();
            string mysqlcon = "server=127.0.0.1; port=3307; user=root; database=qnacho; password=ovalle82";
            mySqlConnection = new MySqlConnection(mysqlcon);
            this.MaximizeBox = false;

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtdocumento.Text;
            string contraseña = txtclave.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un usuario y una contraseña.");
                return;
            }

            try
            {
                mySqlConnection.Open();

                // Calcular el hash SHA-256 de la contraseña proporcionada
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(contraseña));
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                    // Consulta para verificar el usuario y la contraseña en la base de datos
                    string query = "SELECT COUNT(*) FROM empleados WHERE usuario = @usuario AND clave = @contraseña";
                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", hash);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Verificar si el inicio de sesión fue exitoso o no
                    if (count > 0)
                    {
                        Qnacho form = new Qnacho(usuario);
                        form.Show();
                        this.Hide();
                        form.FormClosing += frm_closing;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
