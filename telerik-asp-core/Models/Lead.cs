using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace telerik_asp_core.Models
{
    public class Lead
    {
        public string Business_Name { get; set; }

        public string Category { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string CityState { get; set; }
    }
}
