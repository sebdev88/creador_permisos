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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formulario_permiso formularioPermiso = new formulario_permiso();
            this.Hide();
            formularioPermiso.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso_excel ingresoExcel = new ingreso_excel();
            ingresoExcel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
