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
    public partial class ingreso_excel : Form
    {
        public ingreso_excel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione archivo Excel";
            openFileDialog.Filter = "Archivos de Excel y CSV (*.xls;*.xlsx;*.csv)|*.xls;*.xlsx;*.csv";
            openFileDialog.InitialDirectory = @"C:\"; //Directorio Inicial

            // Mostrar el diálogo y comprobar si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Mostrar la ruta en una variable, consola o un label, por ejemplo:
                lblArchivoExcel.Text = "Archivo seleccionado: " + filePath;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargaWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione archivo Word";
            openFileDialog.Filter = "Archivos de Word (*.doc;*.docx)|*.doc;*.docx";
            openFileDialog.InitialDirectory = @"C:\"; //Directorio Inicial

            // Mostrar el diálogo y comprobar si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Mostrar la ruta en una variable, consola o un label, por ejemplo:
                lblArchivoWord.Text = "Archivo seleccionado: " + filePath;

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            menu_principal menuPrincipal = new menu_principal();
            this.Hide();
            menuPrincipal.Show();
        }

        private void ingreso_excel_Load(object sender, EventArgs e)
        {

        }
    }
}
