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
    
    
   
    public class DeletepageModel : PageModel
    {
       


        private readonly ILogger<IndexModel> _logger;
        private readonly SchoolContext _context;

        public DeletepageModel(ILogger<IndexModel> logger, SchoolContext context)
        {
            _logger = logger;
            _context = context;
        }

        public ILogger<IndexModel> Logger => _logger;

        public void OnGet()
        {

        }

        //_context.Requirements.Remove(new Requirements()
        //{

        //    Id = Idinput

        //});
    }
}
