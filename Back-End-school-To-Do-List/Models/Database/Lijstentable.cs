using System;
using System.Collections.Generic;

#nullable disable

namespace Back_End_school_To_Do_List.Models.Database
{
    public partial class Lijstentable
    {
        public Lijstentable()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int IdLijst { get; set; }
        public string NaamLijst { get; set; }

        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
