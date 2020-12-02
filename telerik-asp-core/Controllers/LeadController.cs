using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telerik_asp_core.Data;
using telerik_asp_core.Models;

namespace telerik_asp_core.Controllers
{
    public class LeadController : Controller
    {
        private readonly LeadsDbContext _db;

        public LeadController(LeadsDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Lead> leadList = _db.Leads;
            return View(leadList);
        }
    }
}
