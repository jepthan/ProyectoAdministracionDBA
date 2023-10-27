using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;

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

        public string File_Dir { get; set; }

        public bool? AutoExtend { get; set; }

        public string? TamannoIncremento { get; set; }
        public string? MaxSize { get; set; }

        public override string ToString()
        {

            return "TABLE SPACE---------NAME: " + this.Name + " File Dir: " + this.File_Dir + " autoExtend: " + this.AutoExtend + " tamaño incremento: " + TamannoIncremento + " MaxBytes: " + MaxSize;
        }
        public void AddTableToDB()
        {
            //TODO
        }
        public void RemoveTableFromDB()
        {
            //TODO
        }
        public void ModifyTableFormDB()
        {
            //TODO
        }
        public static List<TableSpace> GetTableSpaces()
        {
            //cmd.CommandText = "SELECT TABLESPACE_NAME, status from dba_tablespaces where status='ONLINE'";
            DBConection.cmd.CommandText = "SELECT tablespace_name, bytes/1024/1024, File_NAME, AUTOEXTENSIBLE,INCREMENT_BY, MAXBYTES from dba_data_files \r\nunion all\r\nSELECT tablespace_name, bytes/1024/1024, File_NAME, AUTOEXTENSIBLE,INCREMENT_BY, MAXBYTES from dba_temp_files";
            //Console.WriteLine(cmd.CommandText);
            //cmd.ExecuteNonQuery();

            OracleDataReader reader = DBConection.cmd.ExecuteReader();

            List<TableSpace> result = new List<TableSpace>();

            while (reader.Read())
            {
                Debug.WriteLine("TableSpace Name " + reader.GetString(0) + " Status: " + reader.GetString(1));
                TableSpace tempTable = new TableSpace(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                if ("YES" == reader.GetString(3))
                {
                    tempTable.AutoExtend = true;
                }
                else
                {
                    tempTable.AutoExtend = false;
                }
                tempTable.MaxSize = reader.GetString(5);
                tempTable.TamannoIncremento = reader.GetString(4);

                Debug.WriteLine(tempTable.ToString());
                result.Add(tempTable);

            }

            reader.Dispose();

            return result;
        }
    }
}
