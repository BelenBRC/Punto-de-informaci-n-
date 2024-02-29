using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacionCristoRey
{
    public partial class PanallaPrincipal : Form
    {
        Bienvenida inicio;

        PrivateFontCollection dosis = new PrivateFontCollection();
        Font dosisLight;

        //Paleta de colores
        Color rosa = Color.FromArgb(242, 92, 132);
        Color azulClaro = Color.FromArgb(89, 168, 217);
        Color azulOscuro = Color.FromArgb(38, 111, 140);
        Color amarillo = Color.FromArgb(242, 183, 5);
        Color blanco = Color.FromArgb(242, 242, 242);

        public PanallaPrincipal(Bienvenida pantallaInicio)
        {
            InitializeComponent();

            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;

            //Ocultar la barra de título
            this.FormBorderStyle = FormBorderStyle.None;

            inicializarFuente();

            inicio = pantallaInicio;

            //Establecer estilo a la direccion
            labelDireccion.BorderStyle = BorderStyle.None;
            labelDireccion.Font = dosisLight;
            labelDireccion.BackColor = azulOscuro;
            labelDireccion.ForeColor = blanco;

            //Color de imagen de los controles
            web.BackColor = azulClaro;
            personal.BackColor = amarillo;
            map.BackColor = rosa;
            form.BackColor = azulOscuro;
            font.BackColor = rosa;
            admin.BackColor = amarillo;
            exit.BackColor = azulClaro;

        }

        private void inicializarFuente()
        {
            try
            {
                dosis.AddFontFile("dosis-light_[allfont.es].ttf");
                dosisLight = new Font(dosis.Families[0], 26);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fuentes: " + ex.Message);
            }

            //Establecer la fuente de los controles
            foreach (Control c in this.Controls)
            {
                c.Font = dosisLight;
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario principal
            inicio.Show();
            //Cerrar el formulario actual
            this.Close();
        }

        private void web_Click(object sender, EventArgs e)
        {
            //Abrir en el navegador la página web
            System.Diagnostics.Process.Start("https://www.cescristorey.com/");
        }
    }
}
