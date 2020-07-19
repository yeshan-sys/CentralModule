using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralModule.GetSet
{
    public class DBConnection
    {
        public SqlConnection sqlConn;
        public SqlDataAdapter sqlDA;
        public DataSet sqlDS;

        public string query;
        public int rowCount;
        public string value;


        public SqlConnection SQLConnectionDetails()
        {
            sqlConn = new SqlConnection(ConfigurationManager.AppSettings.Get("DBConn"));
            sqlConn.Open();
            return sqlConn;
        }
        public void DataAdapterDetails()
        {
            sqlDA = new SqlDataAdapter(query, sqlConn);
        }
        public int DataSetDetails()
        {
            sqlDS = new DataSet();
            sqlDS.Clear();
            sqlDA.Fill(sqlDS, "AppData");
            rowCount = sqlDS.Tables["AppData"].Rows.Count;
            return rowCount;
        }
        public string RowsValue(int column, int row)
        {
            sqlDS = new DataSet();
            sqlDS.Clear();
            sqlDA.Fill(sqlDS, "AppData");
            value = sqlDS.Tables["AppData"].Rows[column][row].ToString();
            return value;
        }
        public void SqlCommand()
        {
            SqlCommand SQLCMD = new SqlCommand(query, sqlConn);

            SQLCMD.ExecuteNonQuery();
        }
        public DataTable DataGrid()
        {
            sqlDS = new DataSet();
            sqlDS.Clear();
            sqlDA.Fill(sqlDS, "AppData");
            return sqlDS.Tables["AppData"];
        }

    }
}
