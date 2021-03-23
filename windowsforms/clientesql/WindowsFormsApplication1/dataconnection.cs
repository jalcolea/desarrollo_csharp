using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class dataconnection
    {
        private OracleConnection connection;
        private readonly string connectionstring = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 172.23.122.125)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = s_etrmd_onln)));User ID=ETRM;password=etrmxxxp";


        public dataconnection ()
        {
            connection = new OracleConnection (connectionstring);

        }


        public DataTable executequery(string sql, out string log)
        {
            log = "";
            DataTable result = new DataTable();
            try
            {
                OracleCommand cmd = new OracleCommand(sql);
                cmd.Connection = connection;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                OracleDataReader reader = cmd.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
            return result;
        }

        /*public string executequery (string sql)
        {
            String result = "";
            OracleCommand cmd = new OracleCommand(sql);
            cmd.Connection = connection;
            connection.Open();
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int cont = 0; cont < reader.FieldCount; cont++)
                { 
                    try
                    {
                        result += reader.GetString(cont);
                    }
                    catch (Exception)
                    {
                    }
                        result += "\t";
                }
                result += "\r\n";
            }
            return result;
        }*/
    }
}
