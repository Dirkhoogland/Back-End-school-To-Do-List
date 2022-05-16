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
        public int BezigCount { get; set; }
        public int KlaarCount { get; set; }

        public List<Requirements> Klaar { get; set; }

        public List<Requirements> Bezig { get; set; }

        public bool Insert { get; set; }

        public bool Delete { get; set; }

        public bool Update { get; set; }

        public int Idinput { get; set; }

        public string Lijst { get; set; }
        public string Lijstinput { get; set; }
        public async Task OnGet()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            _context.Lijstenbackend.Include(m => m);

            var lijsten = _context.Lijstenbackend.Where(m => m.IdLijst > 0).ToList();
            _context.Requirements.Include(i => i);
            //var taken = await _context.Requirements.Where(i => i.Id > 0).;
            List<Requirements> Taken = new List<Requirements>();
            foreach (var item in lijsten)
            {
                
                Taken.AddRange(_context.Requirements.Where(t => t.Lijst == item.NaamLijst).ToList());
            }
            //Bezig = await _context.Requirements.Where(i => i.Status == "Bezig").ToListAsync();
            //Klaar = await _context.Requirements.Where(i => i.Status == "Klaar").ToListAsync();



            //BezigCount = Bezig.Count();
            //KlaarCount = Klaar.Count();
        }

        public async Task OnPost()
        {
            if (Request.Form.Any(p => p.Value == "SubmitLijst"))
            {
                _context.Lijstenbackend.Add(new Lijstenbackend()
                {
                    NaamLijst = Lijst
                });
            }
            else
            {
                _context.Requirements.Add(new Requirements()
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
                await LoadData();
            }
            else
            {
                var error = true;
            }
            //if (Delete == true)
            //{
            //    _context.Requirements.Remove(new Requirements()
            //    {

            //        Id = Idinput

            //    });


            //}
            //if (Update == true)
            //{
            //    var item = _context.Requirements.SingleOrDefault(i => i.Id == Idinput);
            //    item.Naam = Naaminput;

            //    _context.Requirements.Update(new Requirements()
            //    {
            //        Naam = Naaminput,
            //        Lijst = "Requirements",
            //        Beschrijving = Beschrijvinginput,
            //        Duur = Duurinput,
            //        Status = Statusinput
            //    });
            //}


  


        }
    }
}
