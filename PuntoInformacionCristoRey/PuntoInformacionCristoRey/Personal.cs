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
        ModoAdmin modoAdmin;

        List<ClassPersonal> personal = new List<ClassPersonal>();

        public Personal(PanallaPrincipal panallaPrincipal)
        {
            InitializeComponent();

            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;

            principal = panallaPrincipal;

            inicializarFuente();

            mostrarPersonal();

            //Añadir shortcut para el modo admin: Ctrl + A

        }

        private void leerDatos()
        {
            personal.Clear();
            ClassPersonal p = new ClassPersonal();
            personal = p.leerDatos("personal.txt");
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
            //Limpiar el flowLayout
            flowLayoutPanelPersonal.Controls.Clear();

            leerDatos();

            //Mostrar el personal
            foreach (ClassPersonal p in personal)
            {
                //Crear un panel para cada persona
                Panel panel = new Panel();
                panel.Size = new Size(400, 400);
                panel.BackColor = blanco;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(50, 10, 50, 10);
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
                labelHorario.Size = new Size(400, 60);
                labelHorario.Font = dosisLight;
                labelHorario.Dock = DockStyle.Top;
                labelHorario.TextAlign = ContentAlignment.MiddleCenter;
                labelHorario.ForeColor = amarillo;

                //Crear un pictureBox para la imagen
                PictureBox pictureBox = new PictureBox();
                try
                {
                    pictureBox.Image = Image.FromFile(p.rutaImagen);
                }
                catch (Exception ex)
                {
                    //Coloca una imagen por defecto si no se encuentra la imagen
                    pictureBox.Image = Image.FromFile("FotosPersonal/default.png");
                }
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.BackColor = amarillo;
                pictureBox.Size = new Size(300,300);
                pictureBox.Dock = DockStyle.Bottom;

                //Añadir los controles al panel
                panel.Controls.Add(labelHorario);
                panel.Controls.Add(labelPuesto);
                panel.Controls.Add(labelNombre);
                panel.Controls.Add(pictureBox);

                //Añadir el panel al flowLayout
                flowLayoutPanelPersonal.Controls.Add(panel);
            }
        }

        private void pictureBoxRetroceder_DoubleClick(object sender, EventArgs e)
        {
            //Modo admin
            modoAdmin = new ModoAdmin(this);
            modoAdmin.Show();
            this.Hide();
        }
    }
}
