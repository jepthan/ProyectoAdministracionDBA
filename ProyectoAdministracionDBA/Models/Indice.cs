using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdministracionDBA.Models
{
    internal class Indice
    {
        public Indice(string Nombre,  string Tabla, string Columna) {
            
            this.Nombre = Nombre;
            this.Tabla = Tabla;
            this.Columna = Columna;

        }
        public string Nombre { get; set; }
        public string Tabla {  get; set; }

        public string Columna { get; set; }
    }
}
