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
    public partial class Personal : Form
    {

        PrivateFontCollection dosis = new PrivateFontCollection();
        Font dosisLight;

        //Paleta de colores
        Color rosa = Color.FromArgb(242, 92, 132);
        Color azulClaro = Color.FromArgb(89, 168, 217);
        Color azulOscuro = Color.FromArgb(38, 111, 140);
        Color amarillo = Color.FromArgb(242, 183, 5);
        Color blanco = Color.FromArgb(242, 242, 242);

        PanallaPrincipal principal;

        List<ClassPersonal> personal = new List<ClassPersonal>();

        public Personal(PanallaPrincipal panallaPrincipal)
        {
            InitializeComponent();

            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;

            principal = panallaPrincipal;

            inicializarFuente();

            ClassPersonal p = new ClassPersonal();
            personal = p.leerDatos("personal.txt");
            mostrarPersonal();
        }

        private void pictureBoxRetroceder_Click(object sender, EventArgs e)
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
                dosisLight = new Font(dosis.Families[0], 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fuentes: " + ex.Message);
            }

        }

        public void mostrarPersonal()
        {
            foreach (ClassPersonal p in personal)
            {
                //Crear un panel para cada persona
                Panel panel = new Panel();
                panel.Size = new Size(400, 400);
                panel.BackColor = blanco;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(10);
                panel.Padding = new Padding(10);

                //Crear un label para el nombre
                Label labelNombre = new Label();
                labelNombre.Text = p.nombre;
                labelNombre.Font = dosisLight;
                labelNombre.Dock = DockStyle.Top;
                labelNombre.TextAlign = ContentAlignment.MiddleCenter;
                labelNombre.ForeColor = azulOscuro;

                //Crear un label para el puesto
                Label labelPuesto = new Label();
                labelPuesto.Text = p.puesto;
                labelPuesto.Font = dosisLight;
                labelPuesto.Dock = DockStyle.Top;
                labelPuesto.TextAlign = ContentAlignment.MiddleCenter;
                labelPuesto.ForeColor = azulClaro;

                //Crear un label para el horario de atención
                Label labelHorario = new Label();
                //Introductir un salto de línea en el horario a cada 30 caracteres
                labelHorario.Text = p.horarioAtencion;
                for(int i = 39; i < labelHorario.Text.Length; i += 39)
                {
                    labelHorario.Text = labelHorario.Text.Insert(i, "\n");
                }
                labelHorario.Size = new Size(400, 50);
                labelHorario.Font = dosisLight;
                labelHorario.Dock = DockStyle.Top;
                labelHorario.TextAlign = ContentAlignment.MiddleCenter;
                labelHorario.ForeColor = amarillo;

                //Crear un separador entre el horario y la imagen
                Label separador = new Label();
                separador.Text = " ";
                separador.Dock = DockStyle.Top;

                //Crear un pictureBox para la imagen
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(p.rutaImagen);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.BackColor = amarillo;

                //Añadir los controles al panel
                panel.Controls.Add(labelHorario);
                panel.Controls.Add(labelPuesto);
                panel.Controls.Add(labelNombre);
                panel.Controls.Add(pictureBox);

                //Añadir el panel al flowLayout
                flowLayoutPanelPersonal.Controls.Add(panel);
            }
        }
    }
}
