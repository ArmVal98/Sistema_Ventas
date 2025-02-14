using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using Utilidades;
using System.Threading;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Thread workerThread = null;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iniciarSesion()
        {
            List<Usuario> test = new CN_Usuario().Listar();

            string usuarioLogin = textBoxUsuario.Text;
            string claveLogin = Encriptar.GetMD5(textBoxClave.Text);

            Usuario oUsuario = new CN_Usuario().Listar().Where(u => u.usuario_login.ToString() == usuarioLogin && u.clave == claveLogin).FirstOrDefault();

            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);

                form.Show();

                this.Hide();

                form.FormClosing += cerrarFormulario;
            }
            else
            {
                MessageBox.Show("Favor de ingresar un usuario y contraseña válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void cerrarFormulario(object sender, FormClosingEventArgs e)
        {
            textBoxUsuario.Text = string.Empty;
            textBoxClave.Text = string.Empty;

            this.Show();
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
                textBoxClave.Focus();
        }

        private void textBoxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                iniciarSesion();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(new ThreadStart(this.iniciarSesion));
            this.workerThread.Start();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
