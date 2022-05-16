using System;
using System.Collections.Generic;

#nullable disable

namespace Back_End_school_To_Do_List.Models.Database
{
    public partial class Lijstenbackend
    {
        public Lijstenbackend()
        {
            Requirements = new HashSet<Requirements>();
        }

        public int IdLijst { get; set; }
        public string NaamLijst { get; set; }

        public virtual ICollection<Requirements> Requirements { get; set; }
    }
}
