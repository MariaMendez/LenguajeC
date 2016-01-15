using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DiseñoLogin : Form
    {
        public DiseñoLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexionBaseDatos = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maria\Documents\DataUser.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adaptador = new SqlDataAdapter("Select Count(*) From Login where UserName='" + userName.Text + "'and Password='" + password.Text + "'", conexionBaseDatos);
            DataTable tablaDeDatos = new DataTable();
            adaptador.Fill(tablaDeDatos);
            if (tablaDeDatos.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
                paginaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrecta.Por favor ingresarlos de nuevo");
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
