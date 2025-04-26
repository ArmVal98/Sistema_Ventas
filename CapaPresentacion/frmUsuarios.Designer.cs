namespace CapaPresentacion
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFondoIzquierda = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.textBoxConfirmarClave = new System.Windows.Forms.TextBox();
            this.labelConfirmarClave = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.checkBoxUsuariosActivos = new System.Windows.Forms.CheckBox();
            this.btnReactivar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFondoIzquierda
            // 
            this.labelFondoIzquierda.BackColor = System.Drawing.Color.White;
            this.labelFondoIzquierda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFondoIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFondoIzquierda.Location = new System.Drawing.Point(0, 0);
            this.labelFondoIzquierda.Name = "labelFondoIzquierda";
            this.labelFondoIzquierda.Size = new System.Drawing.Size(248, 564);
            this.labelFondoIzquierda.TabIndex = 0;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(34, 79);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(104, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Número de Usuario: ";
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.BackColor = System.Drawing.Color.White;
            this.labelNombreCompleto.Location = new System.Drawing.Point(34, 121);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(94, 13);
            this.labelNombreCompleto.TabIndex = 2;
            this.labelNombreCompleto.Text = "Nombre Completo:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.Color.White;
            this.labelCorreo.Location = new System.Drawing.Point(34, 163);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 3;
            this.labelCorreo.Text = "Correo:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(37, 98);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(178, 20);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.Location = new System.Drawing.Point(37, 140);
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombreCompleto.TabIndex = 5;
            this.textBoxNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreCompleto_KeyPress);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(37, 182);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(178, 20);
            this.textBoxCorreo.TabIndex = 6;
            this.textBoxCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCorreo_KeyPress);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(37, 224);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(178, 20);
            this.textBoxClave.TabIndex = 8;
            this.textBoxClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClave_KeyPress);
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.BackColor = System.Drawing.Color.White;
            this.labelClave.Location = new System.Drawing.Point(34, 205);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(64, 13);
            this.labelClave.TabIndex = 7;
            this.labelClave.Text = "Contraseña:";
            // 
            // textBoxConfirmarClave
            // 
            this.textBoxConfirmarClave.Location = new System.Drawing.Point(37, 266);
            this.textBoxConfirmarClave.Name = "textBoxConfirmarClave";
            this.textBoxConfirmarClave.PasswordChar = '*';
            this.textBoxConfirmarClave.Size = new System.Drawing.Size(178, 20);
            this.textBoxConfirmarClave.TabIndex = 10;
            this.textBoxConfirmarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfirmarClave_KeyPress);
            // 
            // labelConfirmarClave
            // 
            this.labelConfirmarClave.AutoSize = true;
            this.labelConfirmarClave.BackColor = System.Drawing.Color.White;
            this.labelConfirmarClave.Location = new System.Drawing.Point(34, 247);
            this.labelConfirmarClave.Name = "labelConfirmarClave";
            this.labelConfirmarClave.Size = new System.Drawing.Size(111, 13);
            this.labelConfirmarClave.TabIndex = 9;
            this.labelConfirmarClave.Text = "Confirmar Contraseña:";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(34, 334);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(26, 13);
            this.labelRol.TabIndex = 11;
            this.labelRol.Text = "Rol:";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(37, 353);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(178, 21);
            this.comboBoxRol.TabIndex = 12;
            this.comboBoxRol.TabStop = false;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(37, 396);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(178, 21);
            this.comboBoxEstado.TabIndex = 14;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(34, 377);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "Estado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(37, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Nuevo Usuario";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 16;
            this.btnEditar.Location = new System.Drawing.Point(37, 464);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(178, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 16;
            this.btnEliminar.Location = new System.Drawing.Point(37, 493);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Desactivar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Añadir Usuario";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarUsuario,
            this.id_usuario,
            this.usuario,
            this.nombre_completo,
            this.correo,
            this.rol,
            this.estado,
            this.telefono,
            this.clave,
            this.id_rol});
            this.dataGridViewData.Location = new System.Drawing.Point(255, 65);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewData.RowTemplate.Height = 28;
            this.dataGridViewData.Size = new System.Drawing.Size(1000, 488);
            this.dataGridViewData.TabIndex = 19;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            this.dataGridViewData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewData_CellPainting);
            // 
            // btnSeleccionarUsuario
            // 
            this.btnSeleccionarUsuario.HeaderText = "";
            this.btnSeleccionarUsuario.Name = "btnSeleccionarUsuario";
            this.btnSeleccionarUsuario.ReadOnly = true;
            this.btnSeleccionarUsuario.ToolTipText = "Seleccionar Usuario";
            this.btnSeleccionarUsuario.Width = 30;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Id Usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Número de Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 150;
            // 
            // nombre_completo
            // 
            this.nombre_completo.HeaderText = "Nombre Completo";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            this.nombre_completo.Width = 180;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 150;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "Id Rol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1002, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lista de usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(37, 54);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ShortcutsEnabled = false;
            this.textBoxId.Size = new System.Drawing.Size(25, 20);
            this.textBoxId.TabIndex = 21;
            this.textBoxId.Text = "0";
            this.textBoxId.Visible = false;
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.Color.White;
            this.labelBuscarPor.Location = new System.Drawing.Point(798, 22);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(58, 13);
            this.labelBuscarPor.TabIndex = 22;
            this.labelBuscarPor.Text = "Buscar por";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(862, 19);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBusqueda.TabIndex = 23;
            this.comboBoxBusqueda.TabStop = false;
            this.comboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusqueda_SelectedIndexChanged);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(998, 20);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(166, 20);
            this.textBoxBusqueda.TabIndex = 24;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            this.textBoxBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBusqueda_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(144, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(37, 308);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(178, 20);
            this.textBoxTelefono.TabIndex = 28;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(34, 289);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(55, 13);
            this.labelTelefono.TabIndex = 27;
            this.labelTelefono.Text = "Teléfono: ";
            // 
            // checkBoxUsuariosActivos
            // 
            this.checkBoxUsuariosActivos.AutoSize = true;
            this.checkBoxUsuariosActivos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxUsuariosActivos.Checked = true;
            this.checkBoxUsuariosActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUsuariosActivos.Location = new System.Drawing.Point(1179, 22);
            this.checkBoxUsuariosActivos.Name = "checkBoxUsuariosActivos";
            this.checkBoxUsuariosActivos.Size = new System.Drawing.Size(61, 17);
            this.checkBoxUsuariosActivos.TabIndex = 29;
            this.checkBoxUsuariosActivos.Text = "Activos";
            this.checkBoxUsuariosActivos.UseVisualStyleBackColor = false;
            this.checkBoxUsuariosActivos.CheckedChanged += new System.EventHandler(this.checkBoxUsuariosActivos_CheckedChanged);
            // 
            // btnReactivar
            // 
            this.btnReactivar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReactivar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivar.ForeColor = System.Drawing.Color.White;
            this.btnReactivar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnReactivar.IconColor = System.Drawing.Color.White;
            this.btnReactivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReactivar.IconSize = 16;
            this.btnReactivar.Location = new System.Drawing.Point(37, 522);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(178, 23);
            this.btnReactivar.TabIndex = 30;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReactivar.UseVisualStyleBackColor = false;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 564);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.checkBoxUsuariosActivos);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.labelBuscarPor);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.textBoxConfirmarClave);
            this.Controls.Add(this.labelConfirmarClave);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombreCompleto);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombreCompleto);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelFondoIzquierda);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFondoIzquierda;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.TextBox textBoxConfirmarClave;
        private System.Windows.Forms.Label labelConfirmarClave;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.CheckBox checkBoxUsuariosActivos;
        private FontAwesome.Sharp.IconButton btnReactivar;
    }
}