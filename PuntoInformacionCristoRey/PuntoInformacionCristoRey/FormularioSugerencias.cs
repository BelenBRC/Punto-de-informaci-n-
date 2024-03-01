using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacionCristoRey
{
    public partial class FormularioSugerencias : Form
    {
        PanallaPrincipal principal;

        PrivateFontCollection dosis = new PrivateFontCollection();
        Font dosisLight;

        string correo = "belenrob.alumn@cescristorey.com";
        string correo1 = "sugerencias@cescristorey.com";
        string contrasenia = "++++++++++++++++";

        public FormularioSugerencias(PanallaPrincipal pantalla)
        {
            InitializeComponent();
            principal = pantalla;

            //Maximizar el formulario
            this.WindowState = FormWindowState.Maximized;

            inicializarFuente();
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
                dosisLight = new Font(dosis.Families[0], 20);

                label1.Font = new Font(dosis.Families[0], 32);
                richTextBoxSugerencia.Font = dosisLight;
                buttonEnviar.Font = dosisLight;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fuentes: " + ex.Message);
            }

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string from = correo1;
            string to = correo1;
            string subject = "Nueva sugerencia";
            StringBuilder body = new StringBuilder();
            DateTime fecha = DateTime.Now;
            string error = "Error al enviar la sugerencia";

            body.Append(richTextBoxSugerencia.Text);

            enviarCorreo(body, fecha, to, from, subject, error);            
        }

        private void enviarCorreo(StringBuilder body, DateTime fecha, string to, string from, string subject, string error)
        {
            try
            {
                body.Append(Environment.NewLine);
                body.Append(string.Format("Este correo ha sido enciado el día {0:dd/MM/yyyy} a las {0:HH:mm:ss} horas empleando el formulario del punto de información.", fecha));
                body.Append(Environment.NewLine);

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(from);
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.Body = body.ToString();

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;


                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = subject;
                mail.Body = body + "\n\n" + fecha;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(correo, contrasenia);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                error = "Correo enviado correctamente";
                MessageBox.Show(error);

                //Limpiar el campo de texto
                richTextBoxSugerencia.Text = "";
                //Al cerrar el mensaje, cerrar el formulario
                this.Close();
                //Mostrar el formulario principal
                principal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(error + ex.Message);
            }
        }

        private void richTextBoxSugerencia_Click(object sender, EventArgs e)
        {
            //Mostrar el teclado virtual
            //TODO esto no funciona: System.Diagnostics.Process.Start("osk.exe");
        }
    }
}
