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
    public partial class PanallaPrincipal : Form
    {
        Bienvenida inicio;

        public PanallaPrincipal(Bienvenida pantallaInicio)
        {
            InitializeComponent();

            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;

            //Ocultar la barra de título
            this.FormBorderStyle = FormBorderStyle.None;

            inicio = pantallaInicio;

            //CategoryName
            web.Tag = "web";
            personal.Tag = "personal";
            map.Tag = "map";
            form.Tag = "form";
            font.Tag = "font";
            admin.Tag = "admin";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario principal
            inicio.Show();
            //Cerrar el formulario actual
            this.Close();
        }
    }
}
