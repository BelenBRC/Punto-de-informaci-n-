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
    public partial class ModoAdmin : Form
    {
        Personal pantallaPersonal;
        ClassPersonal p = new ClassPersonal();

        PrivateFontCollection dosis = new PrivateFontCollection();
        Font dosisLight;

        List<ClassPersonal> personal = new List<ClassPersonal>();

        string fichero = "personal.txt";

        //Paleta de colores
        Color rosa = Color.FromArgb(242, 92, 132);
        Color azulClaro = Color.FromArgb(89, 168, 217);
        Color azulOscuro = Color.FromArgb(38, 111, 140);
        Color amarillo = Color.FromArgb(242, 183, 5);
        Color blanco = Color.FromArgb(242, 242, 242);

        public ModoAdmin(Personal pantalla)
        {
            InitializeComponent();
            this.pantallaPersonal = pantalla;

            //Maximizar la ventana
            this.WindowState = FormWindowState.Maximized;

            inicializarFuente();

            //Mostrar panel login
            panelLogin.Visible = true;
            panelLogin.BringToFront();
            pictureBoxRetroceder.BringToFront();

            //Aplicar la fuente a los controles
            labelUser.Font = dosisLight;
            labelContrasenia.Font = dosisLight;
            buttonAcceder.Font = new Font(dosis.Families[0], 26);
            textBoxUser.Font = dosisLight;
            textBoxCont.Font = dosisLight;

            //Aplicar fuente a los controles del panel modo admin
            dataGridViewPersonal.Font = dosisLight;
            buttonGuardar.Font = dosisLight;
            buttonRecargar.Font = dosisLight;
        }

        

        private void inicializarFuente()
        {
            try
            {
                dosis.AddFontFile("dosis-light_[allfont.es].ttf");
                dosisLight = new Font(dosis.Families[0], 20);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fuentes: " + ex.Message);
            }

        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            //Comprobar credenciales
            if (textBoxUser.Text == "admin" && textBoxCont.Text == "admin")
            {
                //Mostrar panel de opciones
                panelAdmin.Visible = true;
                panelAdmin.BringToFront();
                panelLogin.Visible = false;
                pictureBoxRetroceder.BringToFront();
                pintarDatosPersonal();
            }
            else
            {   
                //Si el campo de usuario está vacío
                if (textBoxUser.Text == "")
                {
                    MessageBox.Show("Introduce un usuario");
                }
                //Si el campo de contraseña está vacío
                else if (textBoxCont.Text == "")
                {
                    MessageBox.Show("Introduce una contraseña");
                }
                //En otro caso
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

        }

        private void pintarDatosPersonal()
        {
            //Leer los datos del fichero
            personal = p.leerDatos(fichero);

            //Crear una tabla para mostrar los datos
            DataTable dt = new DataTable();
            
            //Añadir las columnas
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Puesto", typeof(string));
            dt.Columns.Add("Ruta imagen", typeof(string));
            dt.Columns.Add("Horario de atención", typeof(string));

            //Añadir las filas
            foreach (ClassPersonal persona in personal)
            {
                dt.Rows.Add(persona.nombre, persona.puesto, persona.rutaImagen, persona.horarioAtencion);
            }

            //Mostrar los datos en el datagridview
            dataGridViewPersonal.DataSource = dt;

            //Hacer que las columnas se ajusten al contenido
            dataGridViewPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Altura de las filas
            dataGridViewPersonal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Formato split container a proporción 4:1 (80% - 20%) en horizontal
            splitContainer1.SplitterDistance = splitContainer1.Width * 85 / 100;

            //Ancho botones
            buttonGuardar.Width = splitContainer1.Panel2.Width;
            buttonRecargar.Width = splitContainer1.Panel2.Width;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Tomar los datos del datagridview
            DataTable dt = (DataTable)dataGridViewPersonal.DataSource;
            personal.Clear();
            foreach (DataRow row in dt.Rows)
            {
                personal.Add(new ClassPersonal(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString()));
            }
            //Guardar los datos en el fichero
            p.guardarDatos(fichero, personal);

            pantallaPersonal.mostrarPersonal();

            //Mostrar mensaje de éxito
            MessageBox.Show("Datos guardados correctamente");
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            pintarDatosPersonal();
        }

        private void pictureBoxRetroceder_Click(object sender, EventArgs e)
        {
            //Cerrar esta ventana y volver a la ventana de personal
            this.Close();
            pantallaPersonal.Show();
        }
    }
}
