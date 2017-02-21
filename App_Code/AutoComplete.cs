using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Services;
using System.Data;
/// <summary>
/// Summary description for AutoComplete
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class AutoComplete : System.Web.Services.WebService {

    public AutoComplete () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string[] GetCustomers(string searchWord)
    {
        List<string> customers = new List<string>();

        Data da = new Data();
        List<string> sParams = new List<string>();
        sParams.Clear();

        sParams.Add("@SearchText:" + searchWord);

        DataSet dsINFO = da.SP_RetrieveData("IF_READ_AUTO_COMPLETE", sParams);

        if (dsINFO.Tables.Count > 0)
        {
            foreach (DataTable tableINFO in dsINFO.Tables)
            {
                foreach (DataRow rowINFO in tableINFO.Rows)
                {
                    customers.Add(string.Format("{0};{1}", rowINFO["Name"], rowINFO["Id"]));
                }
            }
        }
        
        return customers.ToArray();        
    }    
}
