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
    public partial class Planos : Form
    {
        PrivateFontCollection dosis = new PrivateFontCollection();
        Font dosisLight;

        PanallaPrincipal principal;
        public Planos(PanallaPrincipal panalla)
        {
            InitializeComponent();
            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;
            principal = panalla;

            inicializarFuente();
        }

        private void buttonPlanta1_Click(object sender, EventArgs e)
        {
            //Colocar planta1 en el control de imagen
            imagenPlano.Image = Properties.Resources.planta1;
        }

        private void buttonPlanta2_Click(object sender, EventArgs e)
        {
            //Colocar planta2 en el control de imagen
            imagenPlano.Image = Properties.Resources.planta2;
        }

        private void buttonPlanta3_Click(object sender, EventArgs e)
        {
            //Colocar planta3 en el control de imagen
            imagenPlano.Image = Properties.Resources.planta3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario
            this.Close();
            //Mostrar el formulario principal
            principal.Show();
        }

        private void inicializarFuente()
        {
            try
            {
                dosis.AddFontFile("dosis-light_[allfont.es].ttf");
                dosisLight = new Font(dosis.Families[0], 20);

                //Establecer la fuente de los botones
                buttonPlanta1.Font = dosisLight;
                buttonPlanta2.Font = dosisLight;
                buttonPlanta3.Font = dosisLight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fuentes: " + ex.Message);
            }

        }
    }
}
