using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_ProiectRecords.Data;
using Barbu_Nicoleta_ProiectRecords.Models;

namespace Barbu_Nicoleta_ProiectRecords.Pages.Recordhouses
{
    public class IndexModel : PageModel
    {
        private readonly Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext _context;

        public IndexModel(Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext context)
        {
            _context = context;
        }

        public IList<Recordhouse> Recordhouse { get;set; }

        public async Task OnGetAsync()
        {
            Recordhouse = await _context.Recordhouse.ToListAsync();
        }
    }
}
