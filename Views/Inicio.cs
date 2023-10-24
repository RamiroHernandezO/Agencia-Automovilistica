using Controllers.CRUD;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Views
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
           
        }
        public string role;
        private void frmInicio_Load(object sender, EventArgs e)
        {
           
            CServicio cServicio = new CServicio();

            var conteos = cServicio.ContarPorEstatus();

            if (chtEstatus.Series.Count == 0)
            {
                chtEstatus.Series.Add("Estatus");
            }

            chtEstatus.Series[0].Points.Clear();

            foreach (var conteo in conteos)
            {
                int puntoIndex = chtEstatus.Series[0].Points.AddXY(conteo.Estatus, conteo.Cantidad);

                switch (conteo.Estatus)
                {
                    case "En espera":
                        chtEstatus.Series[0].Points[puntoIndex].Color = Color.Red;
                        break;
                    case "En Proceso":
                        chtEstatus.Series[0].Points[puntoIndex].Color = Color.FromArgb(255, 80, 40);
                        break;
                    case "Finalizado":
                        chtEstatus.Series[0].Points[puntoIndex].Color = Color.Green;
                        break;
                }
            }
        }

        private void tsmiEntregas_Click(object sender, EventArgs e)
        {
            frmEntregas frmEntregas = new frmEntregas();
            frmEntregas.role = role;
            frmEntregas.Show();
            this.Hide();
        }

        private void tsmiRefacciones_Click(object sender, EventArgs e)
        {
            frmRefacciones frmRefacciones = new frmRefacciones();
            frmRefacciones.role = role;
            frmRefacciones.Show();
            this.Hide();
        }

        private void cbtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsmiVehiculos_Click(object sender, EventArgs e)
        {
            frmVehiculos frmVehiculos = new frmVehiculos();
            frmVehiculos.role=role;
            frmVehiculos.Show();
            this.Hide();
        }

        private void tsmiServicio_Click(object sender, EventArgs e)
        {
            frmServicio frmServicio = new frmServicio();
            frmServicio.role=role;
            frmServicio.Show();
            this.Hide();
        }
    }
}
