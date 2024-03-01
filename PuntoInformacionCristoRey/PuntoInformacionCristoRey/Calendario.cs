using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacionCristoRey
{
    public partial class Calendario : Form
    {
        PanallaPrincipal pantallaPrincipal;
        public Calendario(PanallaPrincipal pantalla)
        {
            InitializeComponent();
            this.pantallaPrincipal = pantalla;

            //Maximizar la ventana
            this.WindowState = FormWindowState.Maximized;

            mostrarCalendarioPDF();
        }

        private void mostrarCalendarioPDF()
        {
            //Mostrar el calendario en el visor de PDF del formulario
            pdfViewer1.LoadFromFile("calendario.pdf");
        }

        private void pictureBoxRetroceder_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
            pantallaPrincipal.Show();
        }
    }
}
