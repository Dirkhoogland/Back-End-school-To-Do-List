using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Back_End_school_To_Do_List.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void Connect()
        {
            string con = "Data Source = LAPTOP - 6OVEOOKP; Integrated Security = True";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
        }

        //public static string executeSql(string query, string db, string action)
        //{
        //    string returnValue = "";

        //    string con = "Data Source = LAPTOP - 6OVEOOKP; Integrated Security = True";

        //    SqlConnection conn = new SqlConnection(con);
        //    SqlCommand commandsql = new SqlCommand(query, conn);
        //    conn.Open();

        //    if (action == "SELECT")
        //    {
        //        try
        //        {
        //            returnValue = commandsql.ExecuteScalar().ToString();
        //        }
        //        catch (NullReferenceException e)
        //        {
        //            returnValue = "NULL";
        //        }


        //    }
        //    else
        //    {
        //        commandsql.ExecuteNonQuery();

        //    }
        //    conn.Close();


        //    return returnValue;
        //}



    }
}
