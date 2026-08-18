using MySql.Data.MySqlClient;
using ProyectoASIS22K26___Polideportivo;
using SistemaDePolideportivo.Conexion;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaDePolideportivo
{
    public partial class FrmModuloSeguridad : Form
    {
        public FrmModuloSeguridad()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
           
        }

        private void seguridad_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            
        }


        private void BtnRol_Click(object sender, EventArgs e)
        {
            FrmRol BtnRol = new FrmRol();
            BtnRol.Show();
        }

        private void BtnRolperm_Click(object sender, EventArgs e)
        {
            FrmRolPermiso rolPermiso = new FrmRolPermiso();
            rolPermiso.Show();
        }

        private void BtnPermiso_Click(object sender, EventArgs e)
        {
            Permiso BtnPermiso = new Permiso();
            BtnPermiso.Show();
        }

        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            Bitacora BtnBitacora = new Bitacora();

            BtnBitacora.ShowDialog();
        }
    }
}
