namespace Views
{
    partial class frmRefacciones
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
            this.lblOculto = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvRefaccionesAdm = new System.Windows.Forms.DataGridView();
            this.lblRefacciones = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRegresar2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogout2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnUsuario = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuarioVista = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvRefaUsu = new System.Windows.Forms.DataGridView();
            this.pnAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefaccionesAdm)).BeginInit();
            this.pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefaUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAdmin
            // 
            this.pnAdmin.Controls.Add(this.lblOculto);
            this.pnAdmin.Controls.Add(this.txtPrecio);
            this.pnAdmin.Controls.Add(this.txtDescripcion);
            this.pnAdmin.Controls.Add(this.txtNombre);
            this.pnAdmin.Controls.Add(this.btnConsultar);
            this.pnAdmin.Controls.Add(this.btnActualizar);
            this.pnAdmin.Controls.Add(this.btnGuardar);
            this.pnAdmin.Controls.Add(this.dgvRefaccionesAdm);
            this.pnAdmin.Controls.Add(this.lblRefacciones);
            this.pnAdmin.Controls.Add(this.btnRegresar2);
            this.pnAdmin.Controls.Add(this.btnLogout2);
            this.pnAdmin.Location = new System.Drawing.Point(775, 12);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(760, 583);
            this.pnAdmin.TabIndex = 1;
            // 
            // lblOculto
            // 
            this.lblOculto.AutoSize = true;
            this.lblOculto.Location = new System.Drawing.Point(325, 97);
            this.lblOculto.Name = "lblOculto";
            this.lblOculto.Size = new System.Drawing.Size(0, 13);
            this.lblOculto.TabIndex = 23;
            this.lblOculto.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderRadius = 13;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.Location = new System.Drawing.Point(6, 215);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.Size = new System.Drawing.Size(212, 36);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderRadius = 13;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Location = new System.Drawing.Point(388, 143);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "Descripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(357, 108);
            this.txtDescripcion.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 13;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(6, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "Nombre de la refaccion";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(212, 36);
            this.txtNombre.TabIndex = 20;
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
            this.btnConsultar.Location = new System.Drawing.Point(288, 535);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 45);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar Refacciones";
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
            this.btnActualizar.Location = new System.Drawing.Point(531, 535);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 45);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar Refacciones";
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
            this.btnGuardar.Location = new System.Drawing.Point(38, 535);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar Refaccion";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvRefaccionesAdm
            // 
            this.dgvRefaccionesAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefaccionesAdm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRefaccionesAdm.Location = new System.Drawing.Point(0, 414);
            this.dgvRefaccionesAdm.Name = "dgvRefaccionesAdm";
            this.dgvRefaccionesAdm.ReadOnly = true;
            this.dgvRefaccionesAdm.Size = new System.Drawing.Size(760, 169);
            this.dgvRefaccionesAdm.TabIndex = 15;
            this.dgvRefaccionesAdm.Visible = false;
            this.dgvRefaccionesAdm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefaccionesAdm_CellClick);
            // 
            // lblRefacciones
            // 
            this.lblRefacciones.BackColor = System.Drawing.Color.Transparent;
            this.lblRefacciones.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefacciones.ForeColor = System.Drawing.Color.Aqua;
            this.lblRefacciones.Location = new System.Drawing.Point(142, 11);
            this.lblRefacciones.Name = "lblRefacciones";
            this.lblRefacciones.Size = new System.Drawing.Size(510, 67);
            this.lblRefacciones.TabIndex = 9;
            this.lblRefacciones.Text = "Administrar Refacciones";
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
            this.btnRegresar2.TabIndex = 5;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
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
            this.btnLogout2.Location = new System.Drawing.Point(690, 4);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout2.Size = new System.Drawing.Size(67, 75);
            this.btnLogout2.TabIndex = 6;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // pnUsuario
            // 
            this.pnUsuario.Controls.Add(this.lblUsuarioVista);
            this.pnUsuario.Controls.Add(this.btnRegresar);
            this.pnUsuario.Controls.Add(this.btnLogout);
            this.pnUsuario.Controls.Add(this.dgvRefaUsu);
            this.pnUsuario.Location = new System.Drawing.Point(12, 12);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(760, 583);
            this.pnUsuario.TabIndex = 5;
            // 
            // lblUsuarioVista
            // 
            this.lblUsuarioVista.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioVista.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioVista.ForeColor = System.Drawing.Color.Aqua;
            this.lblUsuarioVista.Location = new System.Drawing.Point(136, 11);
            this.lblUsuarioVista.Name = "lblUsuarioVista";
            this.lblUsuarioVista.Size = new System.Drawing.Size(511, 67);
            this.lblUsuarioVista.TabIndex = 8;
            this.lblUsuarioVista.Text = "Refacciones Disponibles";
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
            this.btnLogout.Location = new System.Drawing.Point(690, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout.Size = new System.Drawing.Size(67, 75);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvRefaUsu
            // 
            this.dgvRefaUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefaUsu.Location = new System.Drawing.Point(0, 85);
            this.dgvRefaUsu.Name = "dgvRefaUsu";
            this.dgvRefaUsu.Size = new System.Drawing.Size(760, 498);
            this.dgvRefaUsu.TabIndex = 0;
            // 
            // frmRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1554, 667);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.pnAdmin);
            this.MaximizeBox = false;
            this.Name = "frmRefacciones";
            this.Text = "Refacciones";
            this.Load += new System.EventHandler(this.frmRefacciones_Load);
            this.pnAdmin.ResumeLayout(false);
            this.pnAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefaccionesAdm)).EndInit();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefaUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnAdmin;
        private Guna.UI2.WinForms.Guna2Panel pnUsuario;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout;
        private System.Windows.Forms.DataGridView dgvRefaUsu;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout2;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar2;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRefacciones;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsuarioVista;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvRefaccionesAdm;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lblOculto;
    }
}