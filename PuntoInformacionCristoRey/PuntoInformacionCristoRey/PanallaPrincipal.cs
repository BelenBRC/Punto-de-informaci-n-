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

        Personal pantallaPersonal;
        Planos pantallaPlanos;
        FormularioSugerencias pantallaSugerencias;
        Calendario pantallaCalendario;

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
            personal.BackColor = rosa;
            map.BackColor = azulOscuro;
            form.BackColor = amarillo;
            calendario.BackColor = azulOscuro;
            exit.BackColor = amarillo;

            //Establecer anvho y alto de los controles
            web.Width = 400;
            web.Height = 400;
            personal.Width = 400;
            personal.Height = 400;
            map.Width = 400;
            map.Height = 400;
            form.Width = 400;
            form.Height = 400;
            calendario.Width = 400;
            calendario.Height = 400;
            exit.Width = 400;
            exit.Height = 400;

            //Mostrar tooltip en los controles
            toolTip1.SetToolTip(web, "Visitar la página web");
            toolTip1.SetToolTip(personal, "Información sobre el personal");
            toolTip1.SetToolTip(map, "Planos del centro y sitios de interés cercanos");
            toolTip1.SetToolTip(form, "Enviar formulario de sugerencias");
            toolTip1.SetToolTip(calendario, "Calendario escolar");
            toolTip1.SetToolTip(exit, "Salir de la aplicación");
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

        private void personal_Click(object sender, EventArgs e)
        {
            //Abrir nuevo formulario
            pantallaPersonal = new Personal(this);
            pantallaPersonal.Show();
            //Ocultar este formulario
            this.Hide();
        }

        private void map_Click(object sender, EventArgs e)
        {
            //Abrir nuevo formulario
            pantallaPlanos = new Planos(this);
            pantallaPlanos.Show();
            //Ocultar este formulario
            this.Hide();
        }

        private void form_Click(object sender, EventArgs e)
        {
            //Abrir nuevo formulario
            pantallaSugerencias = new FormularioSugerencias(this);
            pantallaSugerencias.Show();
            //Ocultar este formulario
            this.Hide();
        }

        private void calendario_Click(object sender, EventArgs e)
        {
            pantallaCalendario = new Calendario(this);
            pantallaCalendario.Show();
            this.Hide();
        }
    }
}
