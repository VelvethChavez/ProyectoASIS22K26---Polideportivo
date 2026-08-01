using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class ModuloSeguridad : Form
    {
        public ModuloSeguridad()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
           
        }

        private void seguridad_Click(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {
            usuario Usuario = new usuario();
            Usuario.Show();
        }


        private void rol_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Show();
        }

        private void rolperm_Click(object sender, EventArgs e)
        {
            RolPermiso rolPermiso = new RolPermiso();
            rolPermiso.Show();
        }

        private void permiso_Click(object sender, EventArgs e)
        {
            Permiso permiso = new Permiso();
            permiso.Show();
        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora();

            bitacora.ShowDialog();
        }
    }
}
