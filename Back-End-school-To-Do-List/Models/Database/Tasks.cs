using System;
using System.Collections.Generic;

#nullable disable

namespace Back_End_school_To_Do_List.Models.Database
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Lijst { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int? Duur { get; set; }
        public string Status { get; set; }

        public virtual Lijstentable LijstNavigation { get; set; }
    }
}
