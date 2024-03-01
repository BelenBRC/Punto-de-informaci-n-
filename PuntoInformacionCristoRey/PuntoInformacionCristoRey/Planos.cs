using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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

        GMarkerGoogle marcador;
        GMapOverlay capaMarcado;
        DataTable dataTable;


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
            mapasGoogle.Visible = false;
            //Colocar planta1 en el control de imagen
            imagenPlano.Image = Properties.Resources.planta1;
        }

        private void buttonPlanta2_Click(object sender, EventArgs e)
        {
            mapasGoogle.Visible = false;
            //Colocar planta2 en el control de imagen
            imagenPlano.Image = Properties.Resources.planta2;
        }

        private void buttonPlanta3_Click(object sender, EventArgs e)
        {
            mapasGoogle.Visible = false;
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
                buttonPapeleríasCercanas.Font = dosisLight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fuentes: " + ex.Message);
            }

        }

        private void buttonPapeleríasCercanas_Click(object sender, EventArgs e)
        {
            //Mostrar el componente mapasGoogle
            mapasGoogle.Visible = true;
            //Traer al frente
            mapasGoogle.BringToFront();
            pictureBox1.BringToFront();

            cargarMapa();
            marcadoresLibrerias();
        }

        private void cargarMapa()
        {
            double latitud = 37.18426;
            double longitud = -3.59338;

            mapasGoogle.DragButton = MouseButtons.Left;
            mapasGoogle.CanDragMap = true;
            mapasGoogle.MapProvider = GMapProviders.GoogleMap;
            mapasGoogle.Position = new GMap.NET.PointLatLng(latitud, longitud);
            mapasGoogle.MinZoom = 0;
            mapasGoogle.MaxZoom = 22;
            mapasGoogle.Zoom = 18;
            mapasGoogle.AutoScroll = true;
        }

        private void marcadoresLibrerias()
        {
            double latitud = 0;
            double longitud = 0;

            capaMarcado = new GMapOverlay();

            //Marcador colegio
            latitud = 37.18426;
            longitud = -3.59338;
            marcador = new GMarkerGoogle(new GMap.NET.PointLatLng(latitud, longitud), GMarkerGoogleType.red_pushpin);
            capaMarcado.Markers.Add(marcador);
            marcador.ToolTipMode = MarkerTooltipMode.Always;
            marcador.ToolTipText = "CES Cristo Rey";

            //Marcadores papelerías
            latitud = 37.18410;
            longitud = -3.59371;
            marcador = new GMarkerGoogle(new GMap.NET.PointLatLng(latitud, longitud), GMarkerGoogleType.green);
            capaMarcado.Markers.Add(marcador);
            marcador.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marcador.ToolTipText = "Librería Papelería Albayzín";

            latitud = 37.18263;
            longitud = -3.59336;
            marcador = new GMarkerGoogle(new GMap.NET.PointLatLng(latitud, longitud), GMarkerGoogleType.green);
            capaMarcado.Markers.Add(marcador);
            marcador.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marcador.ToolTipText = "Papelería Plaza Larga";

            latitud = 37.18312;
            longitud = -3.59327;
            marcador = new GMarkerGoogle(new GMap.NET.PointLatLng(latitud, longitud), GMarkerGoogleType.green);
            capaMarcado.Markers.Add(marcador);
            marcador.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marcador.ToolTipText = "Expendeduría Albayzín N19";

            mapasGoogle.Overlays.Add(capaMarcado);
        }
    }
}
