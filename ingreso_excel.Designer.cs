
namespace crea_permisos
{
    partial class ingreso_excel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargaExcel = new System.Windows.Forms.Button();
            this.btnCargaWord = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArchivoExcel = new System.Windows.Forms.Label();
            this.lblArchivoWord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargaExcel
            // 
            this.btnCargaExcel.Location = new System.Drawing.Point(14, 15);
            this.btnCargaExcel.Name = "btnCargaExcel";
            this.btnCargaExcel.Size = new System.Drawing.Size(143, 68);
            this.btnCargaExcel.TabIndex = 0;
            this.btnCargaExcel.Text = "Cargar Datos de Excel";
            this.btnCargaExcel.UseVisualStyleBackColor = true;
            this.btnCargaExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargaWord
            // 
            this.btnCargaWord.Location = new System.Drawing.Point(14, 109);
            this.btnCargaWord.Name = "btnCargaWord";
            this.btnCargaWord.Size = new System.Drawing.Size(143, 68);
            this.btnCargaWord.TabIndex = 1;
            this.btnCargaWord.Text = "Cargar Tipo de Permiso";
            this.btnCargaWord.UseVisualStyleBackColor = true;
            this.btnCargaWord.Click += new System.EventHandler(this.btnCargaWord_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(238, 324);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(98, 37);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 26);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblArchivoWord);
            this.panel1.Controls.Add(this.lblArchivoExcel);
            this.panel1.Controls.Add(this.btnCargaExcel);
            this.panel1.Controls.Add(this.btnCargaWord);
            this.panel1.Location = new System.Drawing.Point(50, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 199);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblArchivoExcel
            // 
            this.lblArchivoExcel.AutoSize = true;
            this.lblArchivoExcel.Location = new System.Drawing.Point(185, 41);
            this.lblArchivoExcel.Name = "lblArchivoExcel";
            this.lblArchivoExcel.Size = new System.Drawing.Size(20, 17);
            this.lblArchivoExcel.TabIndex = 2;
            this.lblArchivoExcel.Text = "...";
            this.lblArchivoExcel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArchivoWord
            // 
            this.lblArchivoWord.AutoSize = true;
            this.lblArchivoWord.Location = new System.Drawing.Point(185, 135);
            this.lblArchivoWord.Name = "lblArchivoWord";
            this.lblArchivoWord.Size = new System.Drawing.Size(20, 17);
            this.lblArchivoWord.TabIndex = 3;
            this.lblArchivoWord.Text = "...";
            // 
            // ingreso_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGenerar);
            this.Name = "ingreso_excel";
            this.Text = "Importar desde Excel";
            this.Load += new System.EventHandler(this.ingreso_excel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaExcel;
        private System.Windows.Forms.Button btnCargaWord;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblArchivoExcel;
        private System.Windows.Forms.Label lblArchivoWord;
    }
}