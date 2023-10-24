using Controllers.CRUD;
using Database.Entities;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmEntregas : Form
    {
        public frmEntregas()
        {
            InitializeComponent();
        }
        public string role;
        private void cboConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConsultar.SelectedIndex!=0)
            {
                var tipodgv = dgvEntregas;
                Data(tipodgv);
            }
            else
            {
                MessageBox.Show("Elige un Folio!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void Data(DataGridView tipodgv)
        {
            tipodgv.Columns.Clear();

            DataGridViewColumn colServicioID = new DataGridViewTextBoxColumn();
            colServicioID.DataPropertyName = "ServicioID";
            colServicioID.HeaderText = "ID del Servicio";
            tipodgv.Columns.Add(colServicioID);

            DataGridViewColumn colFechaServicio = new DataGridViewTextBoxColumn();
            colFechaServicio.DataPropertyName = "FechaServicio";
            colFechaServicio.HeaderText = "Fecha de Servicio";
            tipodgv.Columns.Add(colFechaServicio);

            DataGridViewColumn colEstatus = new DataGridViewTextBoxColumn();
            colEstatus.DataPropertyName = "Estatus";
            colEstatus.HeaderText = "Estatus";
            tipodgv.Columns.Add(colEstatus);

            DataGridViewColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.DataPropertyName = "Usuario";
            colUsuario.HeaderText = "Usuario";
            tipodgv.Columns.Add(colUsuario);

            DataGridViewColumn colFechaEntrega = new DataGridViewTextBoxColumn();
            colFechaEntrega.DataPropertyName = "FechaEntrega";
            colFechaEntrega.HeaderText = "Fecha de Entrega";
            tipodgv.Columns.Add(colFechaEntrega);

            CEntregas cEntregas = new CEntregas();
            List<EntregaDetalladoCls> folios = cEntregas.ConsultarDetallado();

            if (role == "Usuario")
            {
                var ServicioId = (int)cboConsultar.SelectedItem;
                var Folioencontrado = folios.FirstOrDefault(u => u.ServicioID == ServicioId);
                foreach (DataGridViewColumn column in tipodgv.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                tipodgv.DataSource = new List<EntregaDetalladoCls> { Folioencontrado };
                tipodgv.Refresh();
            }
            else
            {
               
                foreach (DataGridViewColumn column in tipodgv.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                tipodgv.DataSource = folios ;
                tipodgv.Refresh();
            }
           
        }

        private void frmEntregas_Load(object sender, EventArgs e)
        {
            this.Size = new Size(940, 600);

            pnUsuario.Hide();
            pnAdmin.Hide();
            if (role=="Usuario")
            {
                
                pnUsuario.Show();
                CServicio cServicio = new CServicio();
                var consulta = cServicio.Consultar();
                cboConsultar.Items.Add("--Seleccionar Servicio--");
                cboConsultar.SelectedIndex = 0;
                foreach (var cons in consulta)
                {
                    cboConsultar.Items.Add(cons.ServicioID);
                }
            }
            else
            {
                pnAdmin.Location = new Point(12, 12);
                pnAdmin.Show();
                
                CUsuario cUsuario = new CUsuario();
                CServicio cServicio = new CServicio();
                var consulta = cServicio.Consultar();
                cboServicio.Items.Add("--Seleccionar Servicio--");
                foreach (var cons in consulta)
                {
                    cboServicio.Items.Add(cons.ServicioID);
                }
                cboServicio.SelectedIndex = 0;


                var usuario = cUsuario.Consultar();
                List<KeyValuePair<int, string>> itemsCombo = new List<KeyValuePair<int, string>>();
                itemsCombo.Add(new KeyValuePair<int, string>(0, "--Seleccionar usuario--"));

                foreach (var item in usuario)
                {
                    itemsCombo.Add(new KeyValuePair<int, string>(item.UsuarioID, item.NombreUsuario));

                }
                cboUsuario.DataSource = itemsCombo;
                cboUsuario.DisplayMember = "Value";
                cboUsuario.ValueMember = "Key";
            }
           
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            CEntregas cEntregas = new CEntregas();
            EntregaCls entregaCls = new EntregaCls
            {
                ServicioID = cboServicio.SelectedIndex,
                AdminID = (int)cboUsuario.SelectedValue,
                FechaEntrega = dtpFechaEntrega.Value
            };

            if ((int)cboServicio.SelectedIndex != 0 && (int)cboUsuario.SelectedValue != 0)
            {
                cEntregas.Insertar(entregaCls);
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
            var tipodgv = dgvConsultaAdmin;
            Data(tipodgv);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CEntregas cEntregas = new CEntregas();
            EntregaCls entregaCls = new EntregaCls
            {
                ServicioID = cboServicio.SelectedIndex,
                AdminID = (int)cboUsuario.SelectedValue,
                FechaEntrega = dtpFechaEntrega.Value
            };

            if ((int)cboServicio.SelectedIndex != 0 && (int)cboUsuario.SelectedValue != 0)
            {
                cEntregas.Actualizar(entregaCls);
                MessageBox.Show("Actualizacion Exitosa!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void Limpiar()
        {
          cboUsuario.SelectedIndex = 0;
            cboServicio.SelectedIndex = 0;
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CEntregas cEntregas = new CEntregas();
  

            if ((int)cboServicio.SelectedIndex != 0 && (int)cboUsuario.SelectedValue != 0)
            {
                cEntregas.Eliminar(cboServicio.SelectedIndex, (int)cboUsuario.SelectedValue);
                MessageBox.Show("Eliminacion Exitosa!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
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
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regreso();
        }
    }
}
