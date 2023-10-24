namespace Views
{
    partial class frmEntregas
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
            this.pnUsuario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogout2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsultaEntrega = new System.Windows.Forms.Label();
            this.cboConsultar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnAdmin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRegresar2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbtnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpFechaEntrega = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboServicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvConsultaAdmin = new System.Windows.Forms.DataGridView();
            this.pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.pnAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnUsuario.Controls.Add(this.btnRegresar);
            this.pnUsuario.Controls.Add(this.btnLogout2);
            this.pnUsuario.Controls.Add(this.dgvEntregas);
            this.pnUsuario.Controls.Add(this.label2);
            this.pnUsuario.Controls.Add(this.lblConsultaEntrega);
            this.pnUsuario.Controls.Add(this.cboConsultar);
            this.pnUsuario.Location = new System.Drawing.Point(12, 12);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(887, 528);
            this.pnUsuario.TabIndex = 0;
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
            // dgvEntregas
            // 
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEntregas.Location = new System.Drawing.Point(0, 354);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.Size = new System.Drawing.Size(887, 174);
            this.dgvEntregas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 93);
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
            this.lblConsultaEntrega.Location = new System.Drawing.Point(251, 30);
            this.lblConsultaEntrega.Name = "lblConsultaEntrega";
            this.lblConsultaEntrega.Size = new System.Drawing.Size(331, 50);
            this.lblConsultaEntrega.TabIndex = 3;
            this.lblConsultaEntrega.Text = "Consultar Entregas";
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
            // pnAdmin
            // 
            this.pnAdmin.Controls.Add(this.btnRegresar2);
            this.pnAdmin.Controls.Add(this.cbtnLogout);
            this.pnAdmin.Controls.Add(this.dtpFechaEntrega);
            this.pnAdmin.Controls.Add(this.cboUsuario);
            this.pnAdmin.Controls.Add(this.cboServicio);
            this.pnAdmin.Controls.Add(this.label1);
            this.pnAdmin.Controls.Add(this.btnEliminar);
            this.pnAdmin.Controls.Add(this.btnConsultar);
            this.pnAdmin.Controls.Add(this.btnActualizar);
            this.pnAdmin.Controls.Add(this.btnGuardar);
            this.pnAdmin.Controls.Add(this.dgvConsultaAdmin);
            this.pnAdmin.Location = new System.Drawing.Point(905, 12);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(888, 528);
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
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.BorderRadius = 13;
            this.dtpFechaEntrega.Checked = true;
            this.dtpFechaEntrega.FillColor = System.Drawing.Color.White;
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(647, 126);
            this.dtpFechaEntrega.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEntrega.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(214, 36);
            this.dtpFechaEntrega.TabIndex = 13;
            this.dtpFechaEntrega.Value = new System.DateTime(2023, 10, 23, 15, 59, 59, 729);
            // 
            // cboUsuario
            // 
            this.cboUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cboUsuario.BorderRadius = 13;
            this.cboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboUsuario.ItemHeight = 30;
            this.cboUsuario.Location = new System.Drawing.Point(348, 126);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(211, 36);
            this.cboUsuario.TabIndex = 12;
            // 
            // cboServicio
            // 
            this.cboServicio.BackColor = System.Drawing.Color.Transparent;
            this.cboServicio.BorderRadius = 13;
            this.cboServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboServicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboServicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboServicio.ItemHeight = 30;
            this.cboServicio.Location = new System.Drawing.Point(27, 126);
            this.cboServicio.Name = "cboServicio";
            this.cboServicio.Size = new System.Drawing.Size(211, 36);
            this.cboServicio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(277, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrar Entregas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(681, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 45);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Entrega";
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
            this.btnConsultar.Location = new System.Drawing.Point(243, 303);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 45);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar Entregas";
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
            this.btnActualizar.Location = new System.Drawing.Point(462, 303);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 45);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Entrega";
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
            this.btnGuardar.Location = new System.Drawing.Point(27, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar Entrega";
            this.btnGuardar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // dgvConsultaAdmin
            // 
            this.dgvConsultaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvConsultaAdmin.Location = new System.Drawing.Point(0, 354);
            this.dgvConsultaAdmin.Name = "dgvConsultaAdmin";
            this.dgvConsultaAdmin.Size = new System.Drawing.Size(888, 174);
            this.dgvConsultaAdmin.TabIndex = 6;
            // 
            // frmEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1815, 561);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.pnUsuario);
            this.MaximizeBox = false;
            this.Name = "frmEntregas";
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.frmEntregas_Load);
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.pnAdmin.ResumeLayout(false);
            this.pnAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cboConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsultaEntrega;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private Guna.UI2.WinForms.Guna2Panel pnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvConsultaAdmin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaEntrega;
        private Guna.UI2.WinForms.Guna2ComboBox cboUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cboServicio;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout2;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnLogout;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar2;
        private Guna.UI2.WinForms.Guna2CircleButton btnRegresar;
    }
}