namespace Views
{
    partial class frmVehiculos
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
            this.dgvVehiculosUsu = new System.Windows.Forms.DataGridView();
            this.pnAdmin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRegresar2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbtnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblOculto = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvVehiculosAdm = new System.Windows.Forms.DataGridView();
            this.lblAdministrarVehiculos = new System.Windows.Forms.Label();
            this.dtpFechaProxServicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDueño = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAño = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMarca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnUsuario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblVehUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosUsu)).BeginInit();
            this.pnAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosAdm)).BeginInit();
            this.pnUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculosUsu
            // 
            this.dgvVehiculosUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosUsu.Location = new System.Drawing.Point(0, 84);
            this.dgvVehiculosUsu.Name = "dgvVehiculosUsu";
            this.dgvVehiculosUsu.Size = new System.Drawing.Size(760, 499);
            this.dgvVehiculosUsu.TabIndex = 0;
            // 
            // pnAdmin
            // 
            this.pnAdmin.Controls.Add(this.btnRegresar2);
            this.pnAdmin.Controls.Add(this.cbtnLogout);
            this.pnAdmin.Controls.Add(this.lblOculto);
            this.pnAdmin.Controls.Add(this.btnEliminar);
            this.pnAdmin.Controls.Add(this.btnConsultar);
            this.pnAdmin.Controls.Add(this.btnActualizar);
            this.pnAdmin.Controls.Add(this.btnGuardar);
            this.pnAdmin.Controls.Add(this.dgvVehiculosAdm);
            this.pnAdmin.Controls.Add(this.lblAdministrarVehiculos);
            this.pnAdmin.Controls.Add(this.dtpFechaProxServicio);
            this.pnAdmin.Controls.Add(this.txtDueño);
            this.pnAdmin.Controls.Add(this.txtAño);
            this.pnAdmin.Controls.Add(this.cboModelo);
            this.pnAdmin.Controls.Add(this.cboMarca);
            this.pnAdmin.Location = new System.Drawing.Point(12, 12);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(760, 583);
            this.pnAdmin.TabIndex = 1;
            // 
            // btnRegresar2
            // 
            this.btnRegresar2.Animated = true;
            this.btnRegresar2.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar2.BackgroundImage = global::Views.Properties.Resources.flecha_hacia_atras;
            this.btnRegresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar2.FillColor = System.Drawing.Color.Transparent;
            this.btnRegresar2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegresar2.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar2.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRegresar2.Size = new System.Drawing.Size(67, 75);
            this.btnRegresar2.TabIndex = 17;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
            // 
            // cbtnLogout
            // 
            this.cbtnLogout.Animated = true;
            this.cbtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.cbtnLogout.BackgroundImage = global::Views.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.cbtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cbtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cbtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cbtnLogout.FillColor = System.Drawing.Color.Transparent;
            this.cbtnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtnLogout.ForeColor = System.Drawing.Color.Black;
            this.cbtnLogout.Location = new System.Drawing.Point(690, 3);
            this.cbtnLogout.Name = "cbtnLogout";
            this.cbtnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnLogout.Size = new System.Drawing.Size(67, 75);
            this.cbtnLogout.TabIndex = 16;
            this.cbtnLogout.Click += new System.EventHandler(this.cbtnLogout_Click);
            // 
            // lblOculto
            // 
            this.lblOculto.AutoSize = true;
            this.lblOculto.Location = new System.Drawing.Point(12, 9);
            this.lblOculto.Name = "lblOculto";
            this.lblOculto.Size = new System.Drawing.Size(0, 13);
            this.lblOculto.TabIndex = 15;
            this.lblOculto.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(577, 526);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 45);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Vehiculo";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Animated = true;
            this.btnConsultar.BorderRadius = 13;
            this.btnConsultar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(189, 526);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 45);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar Vehiculos";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Animated = true;
            this.btnActualizar.BorderRadius = 13;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(384, 526);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 45);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar Vehiculo";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.BorderRadius = 13;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(3, 526);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Vehiculo";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvVehiculosAdm
            // 
            this.dgvVehiculosAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosAdm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVehiculosAdm.Location = new System.Drawing.Point(0, 414);
            this.dgvVehiculosAdm.Name = "dgvVehiculosAdm";
            this.dgvVehiculosAdm.ReadOnly = true;
            this.dgvVehiculosAdm.Size = new System.Drawing.Size(760, 169);
            this.dgvVehiculosAdm.TabIndex = 6;
            this.dgvVehiculosAdm.Visible = false;
            this.dgvVehiculosAdm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosAdm_CellClick);
            // 
            // lblAdministrarVehiculos
            // 
            this.lblAdministrarVehiculos.AutoSize = true;
            this.lblAdministrarVehiculos.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrarVehiculos.ForeColor = System.Drawing.Color.Aqua;
            this.lblAdministrarVehiculos.Location = new System.Drawing.Point(186, 9);
            this.lblAdministrarVehiculos.Name = "lblAdministrarVehiculos";
            this.lblAdministrarVehiculos.Size = new System.Drawing.Size(378, 50);
            this.lblAdministrarVehiculos.TabIndex = 5;
            this.lblAdministrarVehiculos.Text = "Administrar Vehiculos";
            // 
            // dtpFechaProxServicio
            // 
            this.dtpFechaProxServicio.BorderRadius = 13;
            this.dtpFechaProxServicio.Checked = true;
            this.dtpFechaProxServicio.FillColor = System.Drawing.Color.White;
            this.dtpFechaProxServicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaProxServicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaProxServicio.Location = new System.Drawing.Point(235, 235);
            this.dtpFechaProxServicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaProxServicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaProxServicio.Name = "dtpFechaProxServicio";
            this.dtpFechaProxServicio.Size = new System.Drawing.Size(232, 36);
            this.dtpFechaProxServicio.TabIndex = 4;
            this.dtpFechaProxServicio.Value = new System.DateTime(2023, 10, 23, 17, 28, 38, 624);
            // 
            // txtDueño
            // 
            this.txtDueño.BorderRadius = 13;
            this.txtDueño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDueño.DefaultText = "";
            this.txtDueño.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDueño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDueño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDueño.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDueño.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDueño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDueño.ForeColor = System.Drawing.Color.Black;
            this.txtDueño.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDueño.Location = new System.Drawing.Point(458, 174);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.PasswordChar = '\0';
            this.txtDueño.PlaceholderText = "Dueño del Vehiculo";
            this.txtDueño.SelectedText = "";
            this.txtDueño.Size = new System.Drawing.Size(212, 36);
            this.txtDueño.TabIndex = 3;
            // 
            // txtAño
            // 
            this.txtAño.BorderRadius = 13;
            this.txtAño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAño.DefaultText = "";
            this.txtAño.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAño.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAño.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAño.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAño.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAño.ForeColor = System.Drawing.Color.Black;
            this.txtAño.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAño.Location = new System.Drawing.Point(35, 174);
            this.txtAño.Name = "txtAño";
            this.txtAño.PasswordChar = '\0';
            this.txtAño.PlaceholderText = "Año del modelo";
            this.txtAño.SelectedText = "";
            this.txtAño.Size = new System.Drawing.Size(212, 36);
            this.txtAño.TabIndex = 2;
            // 
            // cboModelo
            // 
            this.cboModelo.BackColor = System.Drawing.Color.Transparent;
            this.cboModelo.BorderRadius = 13;
            this.cboModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboModelo.ItemHeight = 30;
            this.cboModelo.Location = new System.Drawing.Point(458, 111);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(212, 36);
            this.cboModelo.TabIndex = 1;
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.Color.Transparent;
            this.cboMarca.BorderRadius = 13;
            this.cboMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMarca.ItemHeight = 30;
            this.cboMarca.Location = new System.Drawing.Point(35, 111);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(212, 36);
            this.cboMarca.TabIndex = 0;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // pnUsuario
            // 
            this.pnUsuario.Controls.Add(this.lblVehUser);
            this.pnUsuario.Controls.Add(this.btnRegresar);
            this.pnUsuario.Controls.Add(this.btnLogout);
            this.pnUsuario.Controls.Add(this.dgvVehiculosUsu);
            this.pnUsuario.Location = new System.Drawing.Point(778, 12);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(760, 583);
            this.pnUsuario.TabIndex = 4;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Animated = true;
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::Views.Properties.Resources.flecha_hacia_atras;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRegresar.Size = new System.Drawing.Size(67, 75);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::Views.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(690, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout.Size = new System.Drawing.Size(67, 75);
            this.btnLogout.TabIndex = 3;
            // 
            // lblVehUser
            // 
            this.lblVehUser.AutoSize = true;
            this.lblVehUser.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehUser.ForeColor = System.Drawing.Color.Aqua;
            this.lblVehUser.Location = new System.Drawing.Point(204, 9);
            this.lblVehUser.Name = "lblVehUser";
            this.lblVehUser.Size = new System.Drawing.Size(401, 50);
            this.lblVehUser.TabIndex = 18;
            this.lblVehUser.Text = "Vehiculos en la agencia";
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1631, 636);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.pnAdmin);
            this.MaximizeBox = false;
            this.Name = "frmVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosUsu)).EndInit();
            this.pnAdmin.ResumeLayout(false);
            this.pnAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosAdm)).EndInit();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculosUsu;
        private Guna.UI2.WinForms.Guna2Panel pnAdmin;
        private Guna.UI2.WinForms.Guna2ComboBox cboModelo;
        private Guna.UI2.WinForms.Guna2ComboBox cboMarca;
        private System.Windows.Forms.DataGridView dgvVehiculosAdm;
        private System.Windows.Forms.Label lblAdministrarVehiculos;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaProxServicio;
        private Guna.UI2.WinForms.Guna2TextBox txtDueño;
        private Guna.UI2.WinForms.Guna2TextBox txtAño;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.Label lblOculto;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnLogout;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout;
        private Guna.UI2.WinForms.Guna2Panel pnUsuario;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar2;
        private System.Windows.Forms.Label lblVehUser;
    }
}