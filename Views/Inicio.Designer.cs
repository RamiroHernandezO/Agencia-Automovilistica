namespace Views
{
    partial class frmInicio
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
            Guna.Charts.WinForms.LPoint lPoint1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint3 = new Guna.Charts.WinForms.LPoint();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.bdsEnEspera = new Guna.Charts.WinForms.GunaBarDataset();
            this.bdsEnProceso = new Guna.Charts.WinForms.GunaAreaDataset();
            this.bdsFinalizado = new Guna.Charts.WinForms.GunaAreaDataset();
            this.mnuServicios = new System.Windows.Forms.MenuStrip();
            this.tsmiMenuServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefacciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntregas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.chtEstatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbtnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mnuServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtEstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsEnEspera
            // 
            this.bdsEnEspera.BorderColors.AddRange(new System.Drawing.Color[] {
            System.Drawing.Color.Crimson,
            System.Drawing.Color.Lime,
            System.Drawing.Color.DarkGreen});
            lPoint1.Label = "En Espera";
            lPoint1.Y = 1D;
            lPoint2.Label = "En Proceso";
            lPoint2.Y = 1D;
            lPoint3.Label = "Finalizado";
            lPoint3.Y = 1D;
            this.bdsEnEspera.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] {
            lPoint1,
            lPoint2,
            lPoint3});
            this.bdsEnEspera.FillColors.AddRange(new System.Drawing.Color[] {
            System.Drawing.Color.Crimson,
            System.Drawing.Color.Lime,
            System.Drawing.Color.DarkGreen});
            this.bdsEnEspera.Label = "En Espera";
            // 
            // bdsEnProceso
            // 
            this.bdsEnProceso.BorderColor = System.Drawing.Color.Empty;
            this.bdsEnProceso.FillColor = System.Drawing.Color.Lime;
            this.bdsEnProceso.Label = "En Proceso";
            // 
            // bdsFinalizado
            // 
            this.bdsFinalizado.BorderColor = System.Drawing.Color.Empty;
            this.bdsFinalizado.FillColor = System.Drawing.Color.DarkGreen;
            this.bdsFinalizado.Label = "Finalizado";
            // 
            // mnuServicios
            // 
            this.mnuServicios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuServicio});
            this.mnuServicios.Location = new System.Drawing.Point(0, 0);
            this.mnuServicios.Name = "mnuServicios";
            this.mnuServicios.Size = new System.Drawing.Size(800, 24);
            this.mnuServicios.TabIndex = 1;
            this.mnuServicios.Text = "Servicios";
            // 
            // tsmiMenuServicio
            // 
            this.tsmiMenuServicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiServicio,
            this.tsmiRefacciones,
            this.tsmiEntregas,
            this.tsmiVehiculos});
            this.tsmiMenuServicio.Name = "tsmiMenuServicio";
            this.tsmiMenuServicio.Size = new System.Drawing.Size(115, 20);
            this.tsmiMenuServicio.Text = "Menu de Servicios";
            // 
            // tsmiServicio
            // 
            this.tsmiServicio.Name = "tsmiServicio";
            this.tsmiServicio.Size = new System.Drawing.Size(137, 22);
            this.tsmiServicio.Text = "Servicio";
            this.tsmiServicio.Click += new System.EventHandler(this.tsmiServicio_Click);
            // 
            // tsmiRefacciones
            // 
            this.tsmiRefacciones.Name = "tsmiRefacciones";
            this.tsmiRefacciones.Size = new System.Drawing.Size(137, 22);
            this.tsmiRefacciones.Text = "Refacciones";
            this.tsmiRefacciones.Click += new System.EventHandler(this.tsmiRefacciones_Click);
            // 
            // tsmiEntregas
            // 
            this.tsmiEntregas.Name = "tsmiEntregas";
            this.tsmiEntregas.Size = new System.Drawing.Size(137, 22);
            this.tsmiEntregas.Text = "Entregas";
            this.tsmiEntregas.Click += new System.EventHandler(this.tsmiEntregas_Click);
            // 
            // tsmiVehiculos
            // 
            this.tsmiVehiculos.Name = "tsmiVehiculos";
            this.tsmiVehiculos.Size = new System.Drawing.Size(137, 22);
            this.tsmiVehiculos.Text = "Vehiculos";
            this.tsmiVehiculos.Click += new System.EventHandler(this.tsmiVehiculos_Click);
            // 
            // chtEstatus
            // 
            chartArea1.Name = "chtArea";
            this.chtEstatus.ChartAreas.Add(chartArea1);
            this.chtEstatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chtEstatus.Location = new System.Drawing.Point(0, 268);
            this.chtEstatus.Name = "chtEstatus";
            this.chtEstatus.Size = new System.Drawing.Size(800, 300);
            this.chtEstatus.TabIndex = 3;
            this.chtEstatus.Text = "chart1";
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
            this.cbtnLogout.Location = new System.Drawing.Point(727, 27);
            this.cbtnLogout.Name = "cbtnLogout";
            this.cbtnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnLogout.Size = new System.Drawing.Size(67, 75);
            this.cbtnLogout.TabIndex = 2;
            this.cbtnLogout.Click += new System.EventHandler(this.cbtnLogout_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.chtEstatus);
            this.Controls.Add(this.cbtnLogout);
            this.Controls.Add(this.mnuServicios);
            this.MainMenuStrip = this.mnuServicios;
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.mnuServicios.ResumeLayout(false);
            this.mnuServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtEstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.Charts.WinForms.GunaBarDataset bdsEnEspera;
        private Guna.Charts.WinForms.GunaAreaDataset bdsEnProceso;
        private Guna.Charts.WinForms.GunaAreaDataset bdsFinalizado;
        private System.Windows.Forms.MenuStrip mnuServicios;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuServicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntregas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefacciones;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnLogout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtEstatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmiServicio;
    }
}