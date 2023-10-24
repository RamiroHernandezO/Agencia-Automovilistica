using Controllers.CRUD;
using Database.Entities;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Views
{
    public partial class frmVehiculos : Form
    {
        public string role;
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(806, 675);
            pnUsuario.Location = new Point(12, 12);
            pnUsuario.Hide();
            pnAdmin.Hide();
            if (role == "Usuario")
            {

                pnUsuario.Show();
                CVehiculo cVehiculo = new CVehiculo();
                List<VehiculoCls> vehiculos = cVehiculo.Consultar();
                dgvVehiculosUsu.DataSource = vehiculos;
                foreach (DataGridViewColumn column in dgvVehiculosUsu.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                pnAdmin.Show();
                string[] Marca = { "Nissan", "Chevrolet", "KIA", "Volkswagen", "Mazda" };
                cboMarca.Items.Add("--Seleccionar Marca--");
                foreach (var item in Marca)
                {
                    cboMarca.Items.Add(item);
                }
                cboMarca.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CVehiculo cVehiculo = new CVehiculo();
            VehiculoCls vehiculoCls = new VehiculoCls
            {
                Marca = cboMarca.SelectedItem.ToString(),
                Modelo = cboModelo.SelectedItem.ToString(),
                Año = int.Parse(txtAño.Text),
                Dueño = txtDueño.Text,
                ProximoServicio = dtpFechaProxServicio.Value
            };
            if (cboMarca.SelectedIndex != 0 && cboModelo.SelectedIndex != 0 && txtAño.Text != "" && txtDueño.Text != "")
            {
                cVehiculo.Insertar(vehiculoCls);
                MessageBox.Show("Insertado correctamente!", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnGuardar.Location = new Point(3, 363);
            btnConsultar.Location = new Point(189, 363);
            btnActualizar.Location = new Point(384, 363);
            btnEliminar.Location = new Point(577, 363);
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;

            dgvVehiculosAdm.Show();
            CVehiculo cVehiculo = new CVehiculo();
            var consultar = cVehiculo.Consultar();
            dgvVehiculosAdm.DataSource = consultar;
            foreach (DataGridViewColumn column in dgvVehiculosAdm.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CVehiculo cVehiculo = new CVehiculo();
            VehiculoCls vehiculoCls = new VehiculoCls
            {
                VehiculoID = int.Parse(lblOculto.Text),
                Marca = cboMarca.SelectedItem.ToString(),
                Modelo = cboModelo.SelectedItem.ToString(),
                Año = int.Parse(txtAño.Text),
                Dueño = txtDueño.Text,
                ProximoServicio = dtpFechaProxServicio.Value
            };
            if (lblOculto.Text != "" && cboMarca.SelectedIndex != 0 && cboModelo.SelectedIndex != 0 && txtAño.Text != "" && txtDueño.Text != "")
            {
                cVehiculo.Actualizar(vehiculoCls);
                MessageBox.Show("Actualizado correctamente!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CVehiculo cVehiculo = new CVehiculo();
            CServicio cServicio = new CServicio();
            CServicioRefacciones cServicioRefacciones = new CServicioRefacciones();
            CEntregas cEntregas = new CEntregas();


            var servicio = cServicio.Consultar();
            var servicioencontrado = servicio.LastOrDefault(u => u.VehiculoID == int.Parse(lblOculto.Text));
            if (servicioencontrado == null)
            {
                cVehiculo.Eliminar(int.Parse(lblOculto.Text));
                MessageBox.Show("Eliminado correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                return;
            }
            var serviciorefacciones = cServicioRefacciones.Consultar();
            var serviciorefaccionesencontrado = serviciorefacciones.LastOrDefault(d => d.ServicioID == servicioencontrado.ServicioID);
            var entregas = cEntregas.Consultar();
            var entregasencontrado = entregas.LastOrDefault(f => f.ServicioID == servicioencontrado.ServicioID);

            if (lblOculto.Text != "")
            {
                cServicioRefacciones.Eliminar(serviciorefaccionesencontrado.ServicioID, serviciorefaccionesencontrado.RefaccionID);

                cEntregas.Eliminar(entregasencontrado.ServicioID, entregasencontrado.AdminID);

                cServicio.Eliminar(servicioencontrado.ServicioID);

                cVehiculo.Eliminar(int.Parse(lblOculto.Text));
                MessageBox.Show("Eliminado correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModelo.Items.Clear();
            cboModelo.Items.Add("--Seleccionar Modelo--");
            switch (cboMarca.SelectedItem.ToString())
            {
                case "Nissan":
                    cboModelo.Items.AddRange(new string[] { "Altima", "Sentra", "Versa" });
                    break;

                case "Chevrolet":
                    cboModelo.Items.AddRange(new string[] { "Aveo", "Spark", "Cruze" });
                    break;

                case "KIA":

                    cboModelo.Items.AddRange(new string[] { "Sportage", "Sorento", "Rio" });
                    break;

                case "Volkswagen":
                    cboModelo.Items.AddRange(new string[] { "Golf", "Jetta", "Tiguan" });
                    break;

                case "Mazda":
                    cboModelo.Items.AddRange(new string[] { "Mazda 3", "Mazda 6", "CX-5" });
                    break;

                case "MG":
                    cboModelo.Items.AddRange(new string[] { "Modelo1", "Modelo2", "Modelo3", });
                    break;
            }

            cboModelo.SelectedIndex = 0;
        }


        private void dgvVehiculosAdm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehiculosAdm.Rows[e.RowIndex];

                lblOculto.Text = row.Cells["VehiculoID"].Value.ToString();
                cboMarca.SelectedItem = row.Cells["Marca"].Value.ToString();
                cboModelo.SelectedItem = row.Cells["Modelo"].Value.ToString();
                txtAño.Text = row.Cells["Año"].Value.ToString();
                txtDueño.Text = row.Cells["Dueño"].Value.ToString();

                if (row.Cells["ProximoServicio"].Value != null)
                {
                    dtpFechaProxServicio.Value = Convert.ToDateTime(row.Cells["ProximoServicio"].Value);
                }
            }
        }

        private void cbtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
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
        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            Regreso();
        }
        
        public void Limpiar()
        {
          lblOculto.Text = string.Empty;
            txtAño.Text= string.Empty;
            txtDueño.Text = string.Empty;
            cboMarca.SelectedIndex = 0;
        }
    }
}
