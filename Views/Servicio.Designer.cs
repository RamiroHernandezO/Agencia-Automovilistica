namespace Views
{
    partial class frmServicio
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
            this.pnAdmin = new Guna.UI2.WinForms.Guna2Panel();
            this.cboRefacciones = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboEncargado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboEstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboVehiculoId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRegresar2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbtnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvConsultaAdmin = new System.Windows.Forms.DataGridView();
            this.pnUsuario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogout2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsultaEntrega = new System.Windows.Forms.Label();
            this.cboConsultar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboActualizar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAdmin)).BeginInit();
            this.pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdmin
            // 
            this.pnAdmin.Controls.Add(this.label3);
            this.pnAdmin.Controls.Add(this.guna2CheckBox1);
            this.pnAdmin.Controls.Add(this.cboActualizar);
            this.pnAdmin.Controls.Add(this.cboRefacciones);
            this.pnAdmin.Controls.Add(this.cboEncargado);
            this.pnAdmin.Controls.Add(this.cboEstatus);
            this.pnAdmin.Controls.Add(this.dtpFecha);
            this.pnAdmin.Controls.Add(this.cboVehiculoId);
            this.pnAdmin.Controls.Add(this.btnRegresar2);
            this.pnAdmin.Controls.Add(this.cbtnLogout);
            this.pnAdmin.Controls.Add(this.label1);
            this.pnAdmin.Controls.Add(this.btnConsultar);
            this.pnAdmin.Controls.Add(this.btnActualizar);
            this.pnAdmin.Controls.Add(this.btnGuardar);
            this.pnAdmin.Controls.Add(this.dgvConsultaAdmin);
            this.pnAdmin.Location = new System.Drawing.Point(905, 12);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(888, 528);
            this.pnAdmin.TabIndex = 3;
            // 
            // cboRefacciones
            // 
            this.cboRefacciones.BackColor = System.Drawing.Color.Transparent;
            this.cboRefacciones.BorderRadius = 13;
            this.cboRefacciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRefacciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRefacciones.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRefacciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRefacciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRefacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRefacciones.ItemHeight = 30;
            this.cboRefacciones.Location = new System.Drawing.Point(27, 257);
            this.cboRefacciones.Name = "cboRefacciones";
            this.cboRefacciones.Size = new System.Drawing.Size(220, 36);
            this.cboRefacciones.TabIndex = 24;
            // 
            // cboEncargado
            // 
            this.cboEncargado.BackColor = System.Drawing.Color.Transparent;
            this.cboEncargado.BorderRadius = 13;
            this.cboEncargado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncargado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboEncargado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboEncargado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboEncargado.ItemHeight = 30;
            this.cboEncargado.Location = new System.Drawing.Point(546, 205);
            this.cboEncargado.Name = "cboEncargado";
            this.cboEncargado.Size = new System.Drawing.Size(279, 36);
            this.cboEncargado.TabIndex = 23;
            // 
            // cboEstatus
            // 
            this.cboEstatus.BackColor = System.Drawing.Color.Transparent;
            this.cboEstatus.BorderRadius = 13;
            this.cboEstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboEstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboEstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboEstatus.ItemHeight = 30;
            this.cboEstatus.Location = new System.Drawing.Point(27, 205);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(220, 36);
            this.cboEstatus.TabIndex = 22;
            // 
            // dtpFecha
            // 
            this.dtpFecha.BorderRadius = 13;
            this.dtpFecha.Checked = true;
            this.dtpFecha.FillColor = System.Drawing.Color.White;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.Location = new System.Drawing.Point(546, 153);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(279, 36);
            this.dtpFecha.TabIndex = 21;
            this.dtpFecha.Value = new System.DateTime(2023, 10, 23, 22, 35, 54, 960);
            // 
            // cboVehiculoId
            // 
            this.cboVehiculoId.BackColor = System.Drawing.Color.Transparent;
            this.cboVehiculoId.BorderRadius = 13;
            this.cboVehiculoId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboVehiculoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehiculoId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboVehiculoId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboVehiculoId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVehiculoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboVehiculoId.ItemHeight = 30;
            this.cboVehiculoId.Location = new System.Drawing.Point(27, 153);
            this.cboVehiculoId.Name = "cboVehiculoId";
            this.cboVehiculoId.Size = new System.Drawing.Size(220, 36);
            this.cboVehiculoId.TabIndex = 20;
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
            this.btnRegresar2.Location = new System.Drawing.Point(3, 5);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRegresar2.Size = new System.Drawing.Size(67, 75);
            this.btnRegresar2.TabIndex = 19;
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
            this.cbtnLogout.Location = new System.Drawing.Point(818, 5);
            this.cbtnLogout.Name = "cbtnLogout";
            this.cbtnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnLogout.Size = new System.Drawing.Size(67, 75);
            this.cbtnLogout.TabIndex = 14;
            this.cbtnLogout.Click += new System.EventHandler(this.cbtnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(277, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrar Servicios ";
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
            this.btnConsultar.Location = new System.Drawing.Point(333, 480);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 45);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar Servicios";
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
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(636, 480);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 45);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Servicios";
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
            this.btnGuardar.Location = new System.Drawing.Point(27, 480);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar Servicios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvConsultaAdmin
            // 
            this.dgvConsultaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvConsultaAdmin.Location = new System.Drawing.Point(0, 354);
            this.dgvConsultaAdmin.Name = "dgvConsultaAdmin";
            this.dgvConsultaAdmin.Size = new System.Drawing.Size(888, 174);
            this.dgvConsultaAdmin.TabIndex = 6;
            this.dgvConsultaAdmin.Visible = false;
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnUsuario.Controls.Add(this.btnRegresar);
            this.pnUsuario.Controls.Add(this.btnLogout2);
            this.pnUsuario.Controls.Add(this.dgvServicio);
            this.pnUsuario.Controls.Add(this.label2);
            this.pnUsuario.Controls.Add(this.lblConsultaEntrega);
            this.pnUsuario.Controls.Add(this.cboConsultar);
            this.pnUsuario.Location = new System.Drawing.Point(12, 12);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(887, 528);
            this.pnUsuario.TabIndex = 2;
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
            this.btnRegresar.Location = new System.Drawing.Point(3, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRegresar.Size = new System.Drawing.Size(67, 75);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLogout2
            // 
            this.btnLogout2.Animated = true;
            this.btnLogout2.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout2.BackgroundImage = global::Views.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnLogout2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout2.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout2.ForeColor = System.Drawing.Color.Black;
            this.btnLogout2.Location = new System.Drawing.Point(817, 5);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout2.Size = new System.Drawing.Size(67, 75);
            this.btnLogout2.TabIndex = 15;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // dgvServicio
            // 
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvServicio.Location = new System.Drawing.Point(0, 354);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.Size = new System.Drawing.Size(887, 174);
            this.dgvServicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consultar por folio:";
            // 
            // lblConsultaEntrega
            // 
            this.lblConsultaEntrega.AutoSize = true;
            this.lblConsultaEntrega.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaEntrega.ForeColor = System.Drawing.Color.Aqua;
            this.lblConsultaEntrega.Location = new System.Drawing.Point(193, 30);
            this.lblConsultaEntrega.Name = "lblConsultaEntrega";
            this.lblConsultaEntrega.Size = new System.Drawing.Size(461, 50);
            this.lblConsultaEntrega.TabIndex = 3;
            this.lblConsultaEntrega.Text = "Consultar Servicios Activos";
            // 
            // cboConsultar
            // 
            this.cboConsultar.BackColor = System.Drawing.Color.Transparent;
            this.cboConsultar.BorderRadius = 13;
            this.cboConsultar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsultar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboConsultar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboConsultar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboConsultar.ItemHeight = 30;
            this.cboConsultar.Location = new System.Drawing.Point(274, 126);
            this.cboConsultar.Name = "cboConsultar";
            this.cboConsultar.Size = new System.Drawing.Size(252, 36);
            this.cboConsultar.TabIndex = 1;
            this.cboConsultar.SelectedIndexChanged += new System.EventHandler(this.cboConsultar_SelectedIndexChanged);
            // 
            // cboActualizar
            // 
            this.cboActualizar.BackColor = System.Drawing.Color.Transparent;
            this.cboActualizar.BorderRadius = 13;
            this.cboActualizar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActualizar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboActualizar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboActualizar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboActualizar.ItemHeight = 30;
            this.cboActualizar.Location = new System.Drawing.Point(27, 111);
            this.cboActualizar.Name = "cboActualizar";
            this.cboActualizar.Size = new System.Drawing.Size(220, 36);
            this.cboActualizar.TabIndex = 25;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.Aqua;
            this.guna2CheckBox1.Location = new System.Drawing.Point(661, 130);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(47, 22);
            this.guna2CheckBox1.TabIndex = 26;
            this.guna2CheckBox1.Text = "No";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(561, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quieres actualizar algun registro?";
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1826, 650);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.pnUsuario);
            this.Name = "frmServicio";
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.Servicio_Load);
            this.pnAdmin.ResumeLayout(false);
            this.pnAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAdmin)).EndInit();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnAdmin;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar2;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnLogout;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvConsultaAdmin;
        private Guna.UI2.WinForms.Guna2Panel pnUsuario;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout2;
        private System.Windows.Forms.DataGridView dgvServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsultaEntrega;
        private Guna.UI2.WinForms.Guna2ComboBox cboConsultar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private Guna.UI2.WinForms.Guna2ComboBox cboVehiculoId;
        private Guna.UI2.WinForms.Guna2ComboBox cboEstatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboEncargado;
        private Guna.UI2.WinForms.Guna2ComboBox cboRefacciones;
        private Guna.UI2.WinForms.Guna2ComboBox cboActualizar;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label3;
    }
}