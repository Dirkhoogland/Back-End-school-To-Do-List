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
        [BindProperty]
        public string Lijst { get; private set; }
        public string Naam { get; private set; }
        public string Beschrijving { get; private set; }

        public string Duur { get; private set; }

        public string Status { get; private set; }
        public void OnGet()
        {
            Console.WriteLine(Lijst);

        }

        public void OnPost()
        {
            
            Console.WriteLine(Lijst);
        }

        public void Connect()
        {
            string con = "Data Source = LAPTOP-6OVEOOKP; Initial Catalog = School; Integrated Security = True";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
        }


        public void UserdDta()
        {

            Connect();

           Console.WriteLine(Lijst);

        }


        public void Insert()
        {
            string con = "Data Source = LAPTOP-6OVEOOKP; Initial Catalog = School; Integrated Security = True";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
        }


    }
}
