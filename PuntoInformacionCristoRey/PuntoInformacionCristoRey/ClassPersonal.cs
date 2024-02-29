using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacionCristoRey
{
    internal class ClassPersonal
    {
        public static readonly string[] puestos = { "Dirección",
                                                    "Jefatura de estudios",
                                                    "Secretaría",
                                                    "Administración",
                                                    "Orientación",
                                                    "Conserje"};
        public string puesto { get; set; }
        public string nombre { get; set; }
        public string rutaImagen { get; set; }
        public string horarioAtencion { get; set; }

        public ClassPersonal()
        {
            nombre = "";
            puesto = "";
            rutaImagen = "";
            horarioAtencion = "";
        }

        public ClassPersonal(string nombre, string puesto, string rutaImagen, string horarioAtencion)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.rutaImagen = rutaImagen;
            this.horarioAtencion = horarioAtencion;
        }

        public List<ClassPersonal> leerDatos(String rutaFichero)
        {
            List<ClassPersonal> personal = new List<ClassPersonal>();
            string[] lineas = System.IO.File.ReadAllLines(rutaFichero);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');
                personal.Add(new ClassPersonal(datos[0], datos[1], datos[2], datos[3]));
            }
            return personal;
        }

        public void guardarDatos(String rutaFichero, List<ClassPersonal> personal)
        {
            string[] lineas = new string[personal.Count];
            for (int i = 0; i < personal.Count; i++)
            {
                lineas[i] = personal[i].nombre + ";" + personal[i].puesto + ";" + personal[i].rutaImagen + ";" + personal[i].horarioAtencion;
            }
            System.IO.File.WriteAllLines(rutaFichero, lineas);
        }

        public void restaurarDatos(String rutaFichero, List<ClassPersonal> personal)
        {
            personal.Clear();
            personal.AddRange(leerDatos(rutaFichero));
        }

        public void modificarDato(List<ClassPersonal> personal, int indice, string nombre, string puesto, string rutaImagen, string horarioAtencion)
        {
            personal[indice].nombre = nombre;
            personal[indice].puesto = puesto;
            personal[indice].rutaImagen = rutaImagen;
            personal[indice].horarioAtencion = horarioAtencion;
        }

        public void eliminarDato(List<ClassPersonal> personal, int indice)
        {
            personal.RemoveAt(indice);
        }

        public void insertarDato(List<ClassPersonal> personal, int indice, string nombre, string puesto, string rutaImagen, string horarioAtencion)
        {
            personal.Insert(indice, new ClassPersonal(nombre, puesto, rutaImagen, horarioAtencion));
        }

    }
}
