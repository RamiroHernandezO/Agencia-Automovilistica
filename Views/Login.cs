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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public bool ValidarLogin(string nombreUsuario, string contraseña)
        {
            CUsuario cUsuario = new CUsuario();
            List<UsuarioCls> usuarios = cUsuario.Consultar();
            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);

            
            if (usuarioEncontrado != null)
                return true;

            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text; 

            if (ValidarLogin(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                CUsuario cUsuario = new CUsuario();
                List<UsuarioConRolCls> usuarios = cUsuario.ConsultarConRol();
                var usuarioEncontrado = usuarios.FirstOrDefault(u => u.NombreUsuario == usuario && u.Contraseña == contraseña);
                if (usuarioEncontrado.Rol == "Usuario")
                {
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.role = usuarioEncontrado.Rol;
                    frmInicio.Show();
                    this.Hide();
                }
                else
                {
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.role = usuarioEncontrado.Rol;
                    frmInicio.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            frmRegistroUsuario.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
