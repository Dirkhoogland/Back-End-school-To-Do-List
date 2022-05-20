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
        public string Naaminput { get; set; }

        public string Beschrijvinginput { get; set; }

        public int Duurinput { get; set; }

        public string Statusinput { get; set; }

        public List<Tasks> Taken { get; set; }

        public string Lijst { get; set; }
        public string Lijstinput { get; set; }
        public void OnGet()
        {
             LoadData();
        }

        private void LoadData()
        {
            _context.Lijstentable.Include(m => m);

            var lijsten =  _context.Lijstentable.Where(m => m.IdLijst >= 0).ToList();
            _context.Tasks.Include(i => i);
            

            List<Tasks> Taken = new List<Tasks>();
            foreach (var item in lijsten)
            {
                
                Taken.AddRange(_context.Tasks.Where(t => t.Lijst == item.NaamLijst).ToList());
            }
        }

        public void OnPost()
        {
            if (Request.Form.Any(p => p.Value == "SubmitLijst"))
            {
                _context.Lijstentable.Add(new Lijstentable()
                {
                    NaamLijst = Lijst
                });
            }
            else
            {
                _context.Tasks.Add(new Tasks()
                {
                    Id = 0,
                    Lijst = Lijstinput,
                    Naam = Naaminput,
                    Beschrijving = Beschrijvinginput,
                    Duur = Duurinput,
                    Status = Statusinput

                });
            }

            if (_context.SaveChanges() > 0)
            {
                LoadData();
            }

        }
    }
}
