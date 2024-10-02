using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crea_permisos
{
    public partial class formulario_permiso : Form
    {
        public formulario_permiso()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            menu_principal menuPrincipal = new menu_principal();
            this.Hide();
            menuPrincipal.Show();
        }

        private void formulario_permiso_Load(object sender, EventArgs e)
        {

        }
    }
}
