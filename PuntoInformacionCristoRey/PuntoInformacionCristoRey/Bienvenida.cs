using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacionCristoRey
{
    public partial class Bienvenida : Form
    {

        PrivateFontCollection dosis = new PrivateFontCollection();
        Font dosisLight;

        //Paleta de colores
        Color rosa = Color.FromArgb(242, 92, 132);
        Color azulClaro = Color.FromArgb(89, 168, 217);
        Color azulOscuro = Color.FromArgb(38, 111, 140);
        Color amarillo = Color.FromArgb(242, 183, 5);
        Color blanco = Color.FromArgb(242, 242, 242);

        public Bienvenida()
        {
            InitializeComponent();

            //Establecer el formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;

            //Maximizar el panel de bienvenida
            panelBienvenida.Dock = DockStyle.Fill;

            inicializarFuente();
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

            label1.Font = new Font(dosis.Families[0], 55);
            label2.Font = new Font(dosis.Families[0], 20);

        }

        private void panelBienvenida_Click(object sender, EventArgs e)
        {
            //Ocultar imagen de bienvenida
            pictureBox1.Visible = false;
        }
    }
}
