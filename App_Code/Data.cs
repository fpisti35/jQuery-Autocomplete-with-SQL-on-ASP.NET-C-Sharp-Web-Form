using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// Summary description for Data
/// </summary>
public class Data
{
    string sConnection = ConfigurationManager.ConnectionStrings["AutoConn"].ConnectionString;

    public Data()
    {
    }

    public DataSet SP_RetrieveData(string sStoredProc, List<string> sParams)
    {
        //create dataset
        DataSet ds = new DataSet();
        ds.Tables.Add(new DataTable());

        SqlConnection objConn = new SqlConnection(sConnection);
        objConn.Open();

        SqlCommand objCommand = new SqlCommand(sStoredProc, objConn);
        objCommand.CommandType = CommandType.StoredProcedure;

        objCommand.Parameters.Clear();

        foreach (string myparam in sParams)
        {
            string sName = "";
            string sValue = "";
            sName = myparam.Substring(0, myparam.IndexOf(":"));
            sValue = myparam.Substring(myparam.IndexOf(":") + 1);

            objCommand.Parameters.Add(sName, SqlDbType.VarChar).Value = sValue;
        }

        SqlDataReader objDataReader = objCommand.ExecuteReader();

        if (objDataReader.HasRows)
        {
            for (int k = 0; k < objDataReader.FieldCount; k++)
            {
                ds.Tables[0].Columns.Add(new DataColumn(objDataReader.GetName(k).ToString()));
            }


            int iRowCount = 1;
            while (objDataReader.Read())
            {

                DataRow dr = ds.Tables[0].NewRow();


                for (int colcount = 0; colcount < objDataReader.FieldCount; colcount++)
                {
                    dr[colcount] = objDataReader[colcount].ToString();

                }

                ds.Tables[0].Rows.Add(dr);
                iRowCount++;

            }
        }

        objDataReader.Close();
        objCommand.Dispose();
        objConn.Close();

        return ds;
    }
}
