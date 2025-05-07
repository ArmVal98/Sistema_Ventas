using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using Utilidades;
using System.Threading;
using CapaPresentacion;
using System.Configuration;
//using System.Windows;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private Thread workerThread = null;

        bool filtroActivos = true;

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new Opcion_Combo() { valor = true, texto = "Activo" });
            comboBoxEstado.Items.Add(new Opcion_Combo() { valor = false, texto = "No Activo" });
            comboBoxEstado.DisplayMember = "texto";
            comboBoxEstado.ValueMember = "valor";
            comboBoxEstado.SelectedIndex = 0;

            List<Rol> lista_rol = new CN_Rol().Listar();

            foreach (Rol item in lista_rol)
            {
                comboBoxRol.Items.Add(new Opcion_Combo() { valor = item.id_rol, texto = item.descripcion });
            }

            comboBoxRol.DisplayMember = "texto";
            comboBoxRol.ValueMember = "valor";
            comboBoxRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "" && columna.HeaderText != "Estado")
                {
                    comboBoxBusqueda.Items.Add(new Opcion_Combo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }

            comboBoxBusqueda.DisplayMember = "texto";
            comboBoxBusqueda.ValueMember = "valor";
            comboBoxBusqueda.SelectedIndex = 1;

            textBoxUsuario.MaxLength = 4;

            cargarDatosUsuarios();
        }

        public void cargarDatosUsuarios()
        {
            //Mostrar todos los usuarios
            List<Usuario> lista_usuario = new CN_Usuario().Listar();

            foreach (Usuario item in lista_usuario)
            {
                dataGridViewData.Rows.Add(new object[] {"",item.id_usuario,item.usuario_login,item.nombre_completo,item.correo,
                    item.oRol.descripcion,item.estado == true ? "Activo" : "No Activo",item.telefono,item.clave
                });
            }

            comboBoxRol.DisplayMember = "texto";
            comboBoxRol.ValueMember = "valor";
            comboBoxRol.SelectedIndex = 2;

            clave.Visible = false;
            id_rol.Visible = false;
            id_usuario.Visible = false;
            //telefono.Visible = false;

            textBoxTelefono.MaxLength = 10;

            filtrarUsuariosActivos();
        }



        //Limpiar formulario
        public void limpiar()
        {

            if (textBoxId.InvokeRequired)
            {
                textBoxId.Invoke(new MethodInvoker(limpiar));
                return; 
            }

            textBoxId.Text = "0";
            textBoxUsuario.Text = string.Empty;
            textBoxNombreCompleto.Text = string.Empty;
            textBoxCorreo.Text = string.Empty;
            textBoxClave.Text = string.Empty;
            textBoxConfirmarClave.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;   
            comboBoxRol.SelectedIndex = 2;
            comboBoxEstado.SelectedIndex = 0;
        }

        public void buscarUsuario()
        {
            string buscar = textBoxBusqueda.Text.Trim().ToUpper();
            string columnaFiltro = ((Opcion_Combo)comboBoxBusqueda.SelectedItem).valor.ToString();

            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                if (filtroActivos == true)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(buscar) && row.Cells["estado"].Value.ToString().Trim().ToUpper() == "ACTIVO")
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(buscar) && row.Cells["estado"].Value.ToString().Trim().ToUpper() == "NO ACTIVO")
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                
            }
        }

        public void filtrarUsuariosActivos()
        {
            if(checkBoxUsuariosActivos.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    if (row.Cells["estado"].Value.ToString().Trim().ToUpper() == "ACTIVO")
                    {
                        filtroActivos = true;
                        row.Visible = true;
                        buscarUsuario();
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    if (row.Cells["estado"].Value.ToString().Trim().ToUpper() == "NO ACTIVO")
                    {
                        filtroActivos = false;
                        row.Visible = true;
                        buscarUsuario();
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
            public void registrar()
        {
            if (comboBoxRol.InvokeRequired)
            {
                comboBoxRol.Invoke(new Action(registrar));
                return;
            }

            if(textBoxClave.Text != textBoxConfirmarClave.Text)
            {
                MessageBox.Show("La contraseña no coincide. Favor de validar la contraseña correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrWhiteSpace(textBoxUsuario.Text) ||
               string.IsNullOrWhiteSpace(textBoxNombreCompleto.Text) ||
               string.IsNullOrWhiteSpace(textBoxCorreo.Text) ||
               string.IsNullOrWhiteSpace(textBoxClave.Text) ||
               string.IsNullOrWhiteSpace(textBoxConfirmarClave.Text) ||
               string.IsNullOrWhiteSpace(textBoxTelefono.Text))
            {
                MessageBox.Show("Hay campos en blanco. Favor de rellenar todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = string.Empty;
            DataTable dtRegistrar = new DataTable();
            Ejecutar_Query oEjecutar_Query = new Ejecutar_Query();
            Rol oRol = new Rol();
            int numusuario = Convert.ToInt32(textBoxUsuario.Text);
            string nombrecompleto = textBoxNombreCompleto.Text;
            string correo = textBoxCorreo.Text;
            string clave = textBoxClave.Text;
            int idrol = Convert.ToInt32(((Opcion_Combo)comboBoxRol.SelectedItem).valor);
            string telefono = textBoxTelefono.Text;
            bool estado = Convert.ToBoolean(((Opcion_Combo)comboBoxEstado.SelectedItem).valor);

            string numeroUsuarioLogueado = UsuarioLogin.usuarioLogueado;

            try
            {
                using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
                {
                    
                    query = "SELECT out_estado, out_mensaje FROM fun_usuarios(1, 0, " + numusuario + ", '" + nombrecompleto + "', '" + correo + "', '" + clave + "', '"  + idrol + "', '" + telefono + "', " + estado + ",  " + numeroUsuarioLogueado + "," + numeroUsuarioLogueado + " ); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    conection.Open();
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    dtRegistrar.Load(reader);

                    if (dtRegistrar.Rows[0]["out_estado"].ToString() == "1")
                    {
                        MessageBox.Show("Usuario registrado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridViewData.Rows.Clear();
                        limpiar();
                        cargarDatosUsuarios();
                    }
                    else if (dtRegistrar.Rows[0]["out_estado"].ToString() == "0")
                    {
                        MessageBox.Show("El número de usuario ya existe, favor de elegir otro número de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void desactivar()
        {
            if (textBoxId.Text != "0")
            {
                string query = string.Empty;
                DataTable dtDesactivar = new DataTable();
                Ejecutar_Query oEjecutar_Query = new Ejecutar_Query();
                int idusuario = Convert.ToInt32(textBoxId.Text);

                string numeroUsuarioLogueado = UsuarioLogin.usuarioLogueado;

                try
                {
                    using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
                    {

                        query = "SELECT out_estado, out_mensaje FROM fun_usuarios(2, " + idusuario + ", 0, '0', '0', '0', 0, '0', false, 0," + numeroUsuarioLogueado + " ); ";
                        NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                        cmd.CommandType = System.Data.CommandType.Text;

                        conection.Open();
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        dtDesactivar.Load(reader);

                        if (dtDesactivar.Rows[0]["out_estado"].ToString() == "1")
                        {
                            MessageBox.Show("Usuario desactivado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiar();

                            if (dataGridViewData.InvokeRequired)
                            {
                                dataGridViewData.Invoke(new MethodInvoker(delegate {
                                    dataGridViewData.Rows.Clear();
                                    cargarDatosUsuarios();
                                }));
                            }
                            else
                            {
                                dataGridViewData.Rows.Clear();
                                cargarDatosUsuarios();
                            }


                        }
                        else if (dtDesactivar.Rows[0]["out_estado"].ToString() == "0")
                        {
                            limpiar();
                            MessageBox.Show("El usuario ya se encontraba desactivado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un usuario para desactivar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void reactivar()
        {
            if (textBoxId.Text != "0")
            {
                string query = string.Empty;
                DataTable dtReactivar = new DataTable();
                Ejecutar_Query oEjecutar_Query = new Ejecutar_Query();
                int idusuario = Convert.ToInt32(textBoxId.Text);

                string numeroUsuarioLogueado = UsuarioLogin.usuarioLogueado;

                try
                {
                    using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
                    {

                        query = "SELECT out_estado, out_mensaje FROM fun_usuarios(3, " + idusuario + ", 0, '0', '0', '0', 0, '0', true, 0," + numeroUsuarioLogueado + " ); ";
                        NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                        cmd.CommandType = System.Data.CommandType.Text;

                        conection.Open();
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        dtReactivar.Load(reader);

                        if (dtReactivar.Rows[0]["out_estado"].ToString() == "1")
                        {
                            MessageBox.Show("Usuario reactivado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiar();

                            if (dataGridViewData.InvokeRequired)
                            {
                                dataGridViewData.Invoke(new MethodInvoker(delegate {
                                    dataGridViewData.Rows.Clear();
                                    cargarDatosUsuarios();
                                }));
                            }
                            else
                            {
                                dataGridViewData.Rows.Clear();
                                cargarDatosUsuarios();
                            }


                        }
                        else if (dtReactivar.Rows[0]["out_estado"].ToString() == "0")
                        {
                            limpiar();
                            MessageBox.Show("El usuario ya se encontraba activo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un usuario para reactivar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void editar()
        {
            if (comboBoxRol.InvokeRequired)
            {
                comboBoxRol.Invoke(new Action(editar));
                return;
            }

            if (textBoxClave.Text != textBoxConfirmarClave.Text)
            {
                MessageBox.Show("La contraseña no coincide. Favor de validar la contraseña correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) ||
               string.IsNullOrWhiteSpace(textBoxNombreCompleto.Text) ||
               string.IsNullOrWhiteSpace(textBoxCorreo.Text) ||
               string.IsNullOrWhiteSpace(textBoxClave.Text) ||
               string.IsNullOrWhiteSpace(textBoxConfirmarClave.Text) ||
               string.IsNullOrWhiteSpace(textBoxTelefono.Text))
            {
                MessageBox.Show("Hay campos en blanco. Favor de rellenar todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = string.Empty;
            DataTable dtRegistrar = new DataTable();
            Ejecutar_Query oEjecutar_Query = new Ejecutar_Query();
            Rol oRol = new Rol();
            int idusuario = Convert.ToInt32(textBoxId.Text);
            int numusuario = Convert.ToInt32(textBoxUsuario.Text);
            string nombrecompleto = textBoxNombreCompleto.Text;
            string correo = textBoxCorreo.Text;
            string clave = textBoxClave.Text;
            int idrol = Convert.ToInt32(((Opcion_Combo)comboBoxRol.SelectedItem).valor);
            string telefono = textBoxTelefono.Text;
            bool estado = Convert.ToBoolean(((Opcion_Combo)comboBoxEstado.SelectedItem).valor);

            string numeroUsuarioLogueado = UsuarioLogin.usuarioLogueado;

            try
            {
                using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
                {

                    query = "SELECT out_estado, out_mensaje FROM fun_usuarios(4, " + idusuario + ", " + numusuario + ", '" + nombrecompleto + "', '" + correo + "', '" + clave + "', '" + idrol + "', '" + telefono + "', " + estado + ", 0," + numeroUsuarioLogueado + " ); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    conection.Open();
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    dtRegistrar.Load(reader);

                    if (dtRegistrar.Rows[0]["out_estado"].ToString() == "1")
                    {
                        MessageBox.Show("Información actualizada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridViewData.Rows.Clear();
                        limpiar();
                        cargarDatosUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la actualización", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Agregar icono de check en el datagridview para seleccionar usuarios
        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var ancho = Properties.Resources.check.Width - 7;
                var alto = Properties.Resources.check.Height - 7;
                var x = e.CellBounds.Left + (e.CellBounds.Width - ancho) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - alto) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, alto, ancho));
                e.Handled = true;
            }
        }

        //Rellenar el formulario con los datos del usuario cuando se presiona el check
        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewData.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    textBoxId.Text = dataGridViewData.Rows[indice].Cells["id_usuario"].Value.ToString();
                    textBoxUsuario.Text = dataGridViewData.Rows[indice].Cells["usuario"].Value.ToString();
                    textBoxNombreCompleto.Text = dataGridViewData.Rows[indice].Cells["nombre_completo"].Value.ToString();
                    textBoxCorreo.Text = dataGridViewData.Rows[indice].Cells["correo"].Value.ToString();
                    textBoxClave.Text = dataGridViewData.Rows[indice].Cells["clave"].Value.ToString();
                    textBoxConfirmarClave.Text = dataGridViewData.Rows[indice].Cells["clave"].Value.ToString();
                    textBoxTelefono.Text = dataGridViewData.Rows[indice].Cells["telefono"].Value.ToString();
                    comboBoxRol.Text = dataGridViewData.Rows[indice].Cells["rol"].Value.ToString();
                    comboBoxEstado.Text = dataGridViewData.Rows[indice].Cells["estado"].Value.ToString();

                }
            }
        }

        //Evento para dar al enter y pasar al siguiente textbox
        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBoxNombreCompleto.Focus();
        }

        private void textBoxNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBoxCorreo.Focus();
        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBoxClave.Focus();
        }

        private void textBoxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBoxConfirmarClave.Focus();
        }

        private void textBoxConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBoxTelefono.Focus();
        }
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                comboBoxRol.Focus();
        }
        private void textBoxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Opcion_Combo)comboBoxBusqueda.SelectedItem).texto.ToString() == "Teléfono" || ((Opcion_Combo)comboBoxBusqueda.SelectedItem).texto.ToString() == "Número de Usuario")
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (!char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void comboBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Opcion_Combo)comboBoxBusqueda.SelectedItem).texto.ToString() == "Teléfono" || ((Opcion_Combo)comboBoxBusqueda.SelectedItem).texto.ToString() == "Número de Usuario")
            {
                textBoxBusqueda.Text = string.Empty;
                textBoxBusqueda.MaxLength = 10;
            }
            else
            {
                textBoxBusqueda.MaxLength = 50;
                buscarUsuario();
            }
        }
        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            string buscar = textBoxBusqueda.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(buscar))
            {
                dataGridViewData.Rows.Clear();
                cargarDatosUsuarios();
                
            }
            else
            {
                buscarUsuario();
                filtrarUsuariosActivos();
            }
        }
        //BOTONES
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(new ThreadStart(this.registrar));
            this.workerThread.Start();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(new ThreadStart(this.desactivar));
            this.workerThread.Start();
        }

        private void checkBoxUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            filtrarUsuariosActivos();
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(new ThreadStart(this.reactivar));
            this.workerThread.Start(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(new ThreadStart(this.editar));
            this.workerThread.Start();
        }
    }
}
