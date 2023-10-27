using Oracle.ManagedDataAccess.Client;
using ProyectoAdministracionDBA.Models;
using System.Diagnostics;

namespace ProyectoAdministracionDBA
{
    public static class DBConection
    {
        public static bool initialice = false;
        public static string user = "SYS";
        public static string pwd = "2711";
        public static string db = "localhost:1521/XE";
        public static OracleConnection? con;
        public static OracleCommand? cmd;
        private static bool CreateConnection()
        {
            string conStringUser = "User Id=" + user + ";Password=" + pwd + ";Data Source=" + db + ";DBA Privilege=SYSDBA;";
            try
            {
                con = new OracleConnection(conStringUser);
                con.Open();
                Debug.WriteLine("Successfully connected to Oracle Database as " + user);
                Debug.WriteLine("");
                initialice = true;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("-----------ORACLE CONECTOR EXEPTION-----------");
                Debug.WriteLine(ex.ToString());
                initialice = false;
                return false;
            }

        }
        private static void CreateCommand()
        {
            try
            {
                cmd = con.CreateCommand();
                Debug.WriteLine("Command created Successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("-----------ORACLE COMAND EXEPTION-----------");
                Debug.WriteLine(ex.ToString());
            }
        }
        public static List<TableSpace> GetTableSpaces()
        {
            //cmd.CommandText = "SELECT TABLESPACE_NAME, status from dba_tablespaces where status='ONLINE'";
            cmd.CommandText = "SELECT tablespace_name, bytes/1024/1024, File_NAME, AUTOEXTENSIBLE,INCREMENT_BY, MAXBYTES from dba_data_files \r\nunion all\r\nSELECT tablespace_name, bytes/1024/1024, File_NAME, AUTOEXTENSIBLE,INCREMENT_BY, MAXBYTES from dba_temp_files";
            //Console.WriteLine(cmd.CommandText);
            //cmd.ExecuteNonQuery();

            OracleDataReader reader = cmd.ExecuteReader();

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
        public static void ChangeTableSpaceSize(TableSpace table)
        {
            cmd.CommandText = "ALTER DATABASE DATAFILE '" + table.File_Dir + "' RESIZE " + table.Size + "M";
            int rows = cmd.ExecuteNonQuery();
            Debug.WriteLine("TAMAño actualisado?" + rows);
        }

        static DBConection()
        {
            CreateConnection();
            CreateCommand();
        }

    }
}
