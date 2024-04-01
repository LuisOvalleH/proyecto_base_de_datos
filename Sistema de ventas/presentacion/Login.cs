using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

                string query = "SELECT COUNT(*) FROM empleados WHERE usuario = @usuario AND clave = @contraseña";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
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
    }
}
