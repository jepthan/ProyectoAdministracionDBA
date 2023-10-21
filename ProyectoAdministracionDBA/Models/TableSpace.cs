using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdministracionDBA.Models
{
    public class TableSpace
    {
        public TableSpace(string name, string size, string file_Dir)
        {
            Name = name;
            Size = size;
            File_Dir = file_Dir;
        }
        public string Name { get; set; }
        public string Size { get; set; }

        public string File_Dir {  get; set; }

        public bool AutoExtend { get; set; }

        public string TamannoIncremento { get; set; }
        public string MaxSize { get; set; }

        public override string ToString()
        {

            return "TABLE SPACE---------NAME: "+ this.Name + " File Dir: "+ this.File_Dir + " autoExtend: "+ this.AutoExtend + " tamaño incremento: "+ TamannoIncremento + " MaxBytes: " + MaxSize;
        }
        public void AddTableToDB()
        {
            //TODO
        }
        public void RemoveTableFromDB() {
            //TODO
        }
        public void ModifyTableFormDB()
        {
            //TODO
        }
    }
}
