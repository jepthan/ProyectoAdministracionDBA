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
