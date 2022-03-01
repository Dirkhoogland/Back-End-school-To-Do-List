using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Back_End_school_To_Do_List.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Back_End_school_To_Do_List.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SchoolContext _context;

        public IndexModel(ILogger<IndexModel> logger, SchoolContext context)
        {
            _logger = logger;
            _context = context;
        }
        [BindProperty]
        public string Lijst { get; private set; }
        public string Naam { get; private set; }
        public string Beschrijving { get; private set; }

        public string Duur { get; private set; }

        public string Status { get; private set; }
        public async Task OnGet()
        {
            // _context.Requirements.Include(i => i.)

            var item = await _context.Requirements.FirstOrDefaultAsync(i => i.Status == "Bezig");
            if (item != null)
            {
            }

            var data = await _context.Requirements.Where(i => i.Duur == 10).ToListAsync();

            var x = true;

        }

        public void OnPost()
        {
            _context.Requirements.Add(new Requirements()
            {
                 Id = 0,
                  Naam = "Sander",
                Beschrijving = "Test3",
                    Duur = 14
                    
            });

            if (_context.SaveChanges() > 0)
            {
                //return OkResult();
            }


            Console.WriteLine(Lijst);
        }
        
        public void Connect()
        {
            string con = "Data Source = LAPTOP-6OVEOOKP; Initial Catalog = School; Integrated Security = True";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
        }


        public void UserdData()
        {

            Connect();


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
