using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if(objusuario == null)
            {
                usuarioActual = new Usuario() { nombre_completo = "Armando", id_usuario = 1 };
            }
            else
            {
                usuarioActual = objusuario;
            }
            InitializeComponent();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Lectura de permisos y visualización de menús
            List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.id_usuario);

            foreach(IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.nombre_menu == iconmenu.Name);

                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            //Rellenar nombre de usuario y Versión con la que se trabaja
            labelNombreUsuario.Text = "Usuario: " + usuarioActual.nombre_completo;

            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            labelVersion.Text = "Versión: " + version;
        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if(formularioActivo != null) 
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuUsuarios, new frmUsuarios());
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmCategoria());
        }
        
        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmVentas());
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompras());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuClientes, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuProveedores, new frmProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReportes());
        }

        private void subMenuNuevoMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuDesarrollo, new frmNuevoMenu());
        }

        private void subMenuUtilidades_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuUtilidades, new frmUtilidades());
        }
    }
}
