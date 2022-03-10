﻿using Microsoft.AspNetCore.Mvc;
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
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SchoolContext _context;

        public IndexModel(ILogger<IndexModel> logger, SchoolContext context)
        {
            _logger = logger;
            _context = context;
        }
        public string Naaminput  { get; set; }
        
        public string Beschrijvinginput { get; set; }

        public int Duurinput { get; set; }

        public string Statusinput { get; set; }
        public int BezigCount { get; set; }
        public int KlaarCount { get; set; }

        public bool Insert { get; set; }

        public bool Delete { get; set; }

        public bool Update { get; set; }

        public async Task OnGet()
        {
            // _context.Requirements.Include(i => i.)

            var item = await _context.Requirements.FirstOrDefaultAsync(i => i.Status == "Bezig");
            if (item != null)
            {
            }

            var Bezig = await _context.Requirements.Where(i => i.Status == "Bezig").ToListAsync();
            var Klaar = await _context.Requirements.Where(i => i.Status == "Klaar").ToListAsync();



             BezigCount = Bezig.Count();
             KlaarCount = Klaar.Count();


        }
        
        public void OnPost()
        {


            if (Insert == true) {
                _context.Requirements.Add(new Requirements()
                {
                    Id = 0,
                    Lijst = "Requirements",
                    Naam = Naaminput,
                    Beschrijving = Beschrijvinginput,
                    Duur = Duurinput,
                    Status = Statusinput

                });
            }
            if (Delete == true)
            {
                _context.Requirements.Remove(new Requirements()
                {

                    Naam = Naaminput,
                    Beschrijving = Beschrijvinginput,
                    Duur = Duurinput,
                    Status = Statusinput

                });
            }
            //if (Update == true)
            //{
            //    _context.Requirements.Update(new Requirements()
            //    {
            //        Naam = Naaminput,   
                    
            //    });
            //}


            if (_context.SaveChanges() > 0)
            {
                _context.SaveChanges();
            }

        }

        


    }
}
