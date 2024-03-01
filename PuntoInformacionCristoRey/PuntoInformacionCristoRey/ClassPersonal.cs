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

        /**
         * @brief Obtiene los datos de la lista de personal
         * @param rutaFichero   Ruta del fichero de texto
         * @return              Lista de personal
         */   
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
        /**
         * @brief Guarda los datos de la lista de personal sobreescribiendo el fichero
         * @param rutaFichero   Ruta del fichero de texto
         * @param personal      Lista de personal a guardar
         */
        public void guardarDatos(String rutaFichero, List<ClassPersonal> personal)
        {
            //Limpiar el fichero
            System.IO.File.WriteAllText(rutaFichero, String.Empty);
            //Escribir los datos
            string[] lineas = new string[personal.Count];
            for (int i = 0; i < personal.Count; i++)
            {
                lineas[i] = personal[i].nombre + ";" + personal[i].puesto + ";" + personal[i].rutaImagen + ";" + personal[i].horarioAtencion;
            }
            System.IO.File.WriteAllLines(rutaFichero, lineas);
        }

        /**
         * @brief Elimina los datos del array de personal y los restaura desde el fichero
         * @param rutaFichero   Ruta del fichero de texto
         * @param personal      Lista de personal a restaurar
         */
        public void restaurarDatos(String rutaFichero, List<ClassPersonal> personal)
        {
            personal.Clear();
            personal.AddRange(leerDatos(rutaFichero));
        }

        /**
         * @brief Modifica los datos de la lista de personal
         * @param personal          Lista de personal a modificar
         * @param indice            Índice del personal a modificar
         * @param nombre            Nombre del personal
         * @param puesto            Puesto del personal
         * @param rutaImagen        Ruta de la imagen del personal
         * @param horarioAtencion   Horario de atención del personal
         */
        public void modificarDato(List<ClassPersonal> personal, int indice, string nombre, string puesto, string rutaImagen, string horarioAtencion)
        {
            personal[indice].nombre = nombre;
            personal[indice].puesto = puesto;
            personal[indice].rutaImagen = rutaImagen;
            personal[indice].horarioAtencion = horarioAtencion;
        }

        /**
         * @brief Elimina los datos de la lista de personal
         * @param personal  Lista de personal a eliminar
         * @param indice    Índice del personal a eliminar
         */
        public void eliminarDato(List<ClassPersonal> personal, int indice)
        {
            personal.RemoveAt(indice);
        }

        /**
         * @brief Inserta los datos en la lista de personal
         * @param personal          Lista de personal a insertar
         * @param indice            Índice del personal a insertar
         * @param nombre            Nombre del personal
         * @param puesto            Puesto del personal
         * @param rutaImagen        Ruta de la imagen del personal
         * @param horarioAtencion   Horario de atención del personal
         */
        public void insertarDato(List<ClassPersonal> personal, int indice, string nombre, string puesto, string rutaImagen, string horarioAtencion)
        {
            personal.Insert(indice, new ClassPersonal(nombre, puesto, rutaImagen, horarioAtencion));
        }

    }
}
