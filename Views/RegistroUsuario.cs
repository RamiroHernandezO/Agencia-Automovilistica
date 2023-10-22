using Controllers.CRUD;
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
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();          

            txtUsuario.MaxLength = 100;
            txtEmail.MaxLength = 100;
            txtContraseña.MaxLength = 100;
        }

        private void llblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo Usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus(); 
                return; 
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus(); 
                return; 
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El campo Email no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus(); 
                return; 
            }

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text; 
            string email = txtEmail.Text;
            int rolID = 2; 

            UsuarioCls nuevoUsuario = new UsuarioCls
            {
                NombreUsuario = usuario,
                Contraseña = contraseña,
                Email = email,
                RolID = rolID
            };
            CUsuario cUsuario = new CUsuario();
            cUsuario.Insertar(nuevoUsuario);
            MessageBox.Show("Usuario registrado con éxito!");

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '_' && e.KeyChar != (char)8)
            {
                e.Handled = true; 
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresProhibidos = { ' ', ':', ';', '_', ',', '.', '[', ']', '{', '}', '+', '*', '´', '¨', '?', '¡', '¿', '=', '\\', '¬', '°', '|', '!', '#', '"', '/', '(', ')', '\'' };

            if (caracteresProhibidos.Contains(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresProhibidos = { ' ', ':', ';', '_', ',', '[', ']', '{', '}', '+', '*', '´', '¨', '?', '¡', '¿', '=', '\\', '¬', '°', '|', '!', '#', '"', '/', '(', ')', '\'' };

            if (caracteresProhibidos.Contains(e.KeyChar))
            {
                e.Handled = true;  
            }
        }
    }
}
