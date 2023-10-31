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

        public void addIndex() {
            
            //TODO codigo de dba
        }
        public static void ReconstruirIndice(string name)
        {
            //TODO RECONSTRUIR INDICE DBA
        }
        public static void Delete(string name) { 
            // eliminar indice con el nombre
        }
    }
}
