using Controllers.CRUD;
using Database.Entities;
using Guna.UI2.WinForms.Suite;
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
    public partial class frmRefacciones : Form
    {
        public string role;
        public frmRefacciones()
        {
            InitializeComponent();
        }

        private void frmRefacciones_Load(object sender, EventArgs e)
        {
            pnAdmin.Hide();
            pnAdmin.Location=new Point(12,12);
            pnUsuario.Hide();
            this.Size = new Size(806, 675);
            if (role=="Usuario")
            {
                pnUsuario.Show();
                CRefacciones cRefacciones = new CRefacciones();
                List<RefaccionesCls> refacciones = cRefacciones.Consultar();
                dgvRefaUsu.DataSource = refacciones;
                foreach (DataGridViewColumn column in dgvRefaUsu.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                pnAdmin.Show();
                txtPrecio.MaxLength = 10;
                txtDescripcion.MaxLength = 1000;
                txtNombre.MaxLength = 100;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CRefacciones cRefacciones = new CRefacciones();
            decimal result;
            if (decimal.TryParse(txtPrecio.Text, out result))
            {
              
            
            RefaccionesCls refaccionesCls = new RefaccionesCls
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = result
            };
                if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecio.Text != "")
                {
                    cRefacciones.Insertar(refaccionesCls);
                    MessageBox.Show("Insertado correctamente!", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número decimal válido.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnGuardar.Location = new Point(3, 363);
            btnConsultar.Location = new Point(189, 363);
            btnActualizar.Location = new Point(384, 363);
            btnActualizar.Enabled = true;

            dgvRefaccionesAdm.Show();
            CRefacciones cRefacciones = new CRefacciones();
            var consultar = cRefacciones.Consultar();
            dgvRefaccionesAdm.DataSource = consultar;

            
            foreach (DataGridViewColumn column in dgvRefaccionesAdm.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

           

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CRefacciones cRefacciones = new CRefacciones();
            decimal result;
            if (decimal.TryParse(txtPrecio.Text, out result))
            {


                RefaccionesCls refaccionesCls = new RefaccionesCls
                {
                    RefaccionID=int.Parse(lblOculto.Text),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = result
                };
                if (lblOculto.Text !="" && txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecio.Text != "")
                {
                    cRefacciones.Actualizar(refaccionesCls);
                    MessageBox.Show("Actualizado correctamente!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Tienes que llenar todos los campos!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número decimal válido.");
            }
        }

        

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(txtPrecio.Text, out value))
            {
                e.Cancel = true;
                txtPrecio.Focus();
               
            }
            else
            {
                
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void dgvRefaccionesAdm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRefaccionesAdm.Rows[e.RowIndex];

                lblOculto.Text = row.Cells["RefaccionID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            }
        }
        public void Limpiar()
        {
            lblOculto.Text = string.Empty;
            txtNombre.Text= string.Empty;  
            txtDescripcion.Text= string.Empty;  
            txtPrecio.Text = string.Empty;
        }
    }
}
