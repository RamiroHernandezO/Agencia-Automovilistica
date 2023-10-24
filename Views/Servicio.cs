using Controllers.CRUD;
using Database.Entities;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmServicio : Form
    {
        public string role;
        public frmServicio()
        {
            InitializeComponent();
        }

        private void cboConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConsultar.SelectedIndex!=0)
            {

                CServicioRefacciones cServicioRefacciones = new CServicioRefacciones();
                List<ServicioRefaccionesDetalladoCls> servicio = cServicioRefacciones.ConsultarDetallado();


                var ServicioId = (int)cboConsultar.SelectedItem;
                var Folioencontrado = servicio.FirstOrDefault(u => u.ServicioID == ServicioId);

                foreach (DataGridViewColumn column in dgvServicio.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                dgvServicio.DataSource = new List<ServicioRefaccionesDetalladoCls> { Folioencontrado };
                dgvServicio.Refresh();
            }
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            this.Size = new Size(940, 600);
            pnAdmin.Hide();
            pnUsuario.Hide();
            pnAdmin.Location = new Point(12, 12);
            
            if (role=="Usuario")
            {
                pnUsuario.Show();
                CServicio cServicio = new CServicio();
                var servicio = cServicio.Consultar();
                cboConsultar.Items.Add("-- Seleccionar Servicio --");
                cboConsultar.SelectedIndex = 0;
                foreach (var item in servicio)
                {
                    cboConsultar.Items.Add(item.ServicioID);
                }
            }
            else
            {
                dgvConsultaAdmin.Hide();
                pnAdmin.Show();
                btnActualizar.Enabled = false;
                string[] Estatus = {"-- Seleccionar Estatus" ,"En espera", "En proceso", "Finalizado" };
                foreach (var item in Estatus)
                {
                    cboEstatus.Items.Add(item);
                }
                cboEstatus.SelectedIndex = 0;

                CVehiculo cVehiculo = new CVehiculo();
                

                CServicio cServicio = new CServicio();

                CRefacciones cRefacciones = new CRefacciones();

                CUsuario cUsuario = new CUsuario();

                var vehiculo = cVehiculo.Consultar();

                var servicio = cServicio.Consultar();

                var refacciones= cRefacciones.Consultar();


                List<KeyValuePair<int, string>> itemsRefacciones = new List<KeyValuePair<int, string>>();
                itemsRefacciones.Add(new KeyValuePair<int, string>(0, "--Seleccionar Refaccion--"));
                foreach (var item in refacciones)
                {
                    itemsRefacciones.Add(new KeyValuePair<int, string>(item.RefaccionID, item.Nombre));

                }
                cboRefacciones.DataSource = itemsRefacciones;
                cboRefacciones.DisplayMember = "Value";
                cboRefacciones.ValueMember = "Key";
                cboRefacciones.SelectedIndex = 0;


                List<KeyValuePair<int, string>> itemsvehiculo = new List<KeyValuePair<int, string>>();
                itemsvehiculo.Add(new KeyValuePair<int, string>(0, "--Seleccionar Vehiculo--"));
                foreach (var item in vehiculo)
                {
                    itemsvehiculo.Add(new KeyValuePair<int, string>(item.VehiculoID, item.Modelo));

                }
                cboVehiculoId.DataSource = itemsvehiculo;
                cboVehiculoId.DisplayMember = "Value";
                cboVehiculoId.ValueMember = "Key";
                cboVehiculoId.SelectedIndex = 0;

                var usuario = cUsuario.Consultar();
                List<KeyValuePair<int, string>> itemsCombo = new List<KeyValuePair<int, string>>();
                itemsCombo.Add(new KeyValuePair<int, string>(0, "--Seleccionar usuario--"));

                foreach (var item in usuario)
                {
                    itemsCombo.Add(new KeyValuePair<int, string>(item.UsuarioID, item.NombreUsuario));

                }
                cboEncargado.DataSource = itemsCombo;
                cboEncargado.DisplayMember = "Value";
                cboEncargado.ValueMember = "Key";
            }
        }

        private void cbtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            Regreso();
        }
        public void Regreso()
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.role = role;
            frmInicio.Show();
            this.Hide();
        }
        private void btnLogout2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regreso();
        }

      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CServicio Cservicio = new CServicio();
            ServicioCls servicioCls = new ServicioCls();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CServicioRefacciones Cservicio = new CServicioRefacciones();
            btnGuardar.Location = new Point(3, 303);
            btnConsultar.Location = new Point(189, 303);
            btnActualizar.Location = new Point(384, 303);
            btnActualizar.Enabled = true;

            dgvConsultaAdmin.Show();
        
            var consultar = Cservicio.ConsultarDetallado();
            dgvConsultaAdmin.DataSource = consultar;
            foreach (DataGridViewColumn column in dgvConsultaAdmin.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CServicio Cservicio = new CServicio();
            CEntregas cEntregas = new CEntregas();
            CServicioRefacciones cServicioRefacciones = new CServicioRefacciones();

            
            ServicioCls servicioCls = new ServicioCls
            {
                VehiculoID = int.Parse(cboVehiculoId.SelectedValue.ToString()),
                Fecha = dtpFecha.Value,
                Estatus= (string)cboEstatus.SelectedItem,
            };
           

            if (cboEstatus.SelectedIndex!=0 && cboVehiculoId.SelectedIndex != 0 && cboRefacciones.SelectedIndex != 0 && cboEncargado.SelectedIndex != 0)
            {
                Cservicio.Insertar(servicioCls);
                
                var servi=Cservicio.Consultar().LastOrDefault();

                EntregaCls entregaCls = new EntregaCls
                {
                  ServicioID=servi.ServicioID,
                  AdminID=int.Parse(cboEncargado.SelectedValue.ToString()),
                  FechaEntrega=dtpFecha.Value.AddMonths(5),

                };
                ServicioRefaccionesCls servicioRefaccionesCls = new ServicioRefaccionesCls
                {
                    ServicioID = servi.ServicioID,
                    RefaccionID = int.Parse(cboRefacciones.SelectedValue.ToString()),
                    Cantidad = 1,
                };

                cEntregas.Insertar(entregaCls);
                cServicioRefacciones.Insertar(servicioRefaccionesCls);
                MessageBox.Show("Actualizado correctamente!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Limpiar()
        {
            cboVehiculoId.SelectedIndex = 0;
            cboEstatus.SelectedIndex = 0;
            cboEncargado.SelectedIndex = 0;
            cboRefacciones.SelectedIndex = 0;   
        }
    }
}
