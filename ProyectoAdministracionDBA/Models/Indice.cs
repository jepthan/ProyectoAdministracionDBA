using System.Security.Policy;

namespace ProyectoAdministracionDBA.Models
{
    internal class Indice
    {
        public Indice(string Nombre, string Tabla, string Columna)
        {

            this.Nombre = Nombre;
            this.Tabla = Tabla;
            this.Columna = Columna;

        }
        public string Nombre { get; set; }
        public string Tabla { get; set; }

        public string Columna { get; set; }

        static public void addIndex() {
            
            //TODO codigo de dba
        }
    }
}
