using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_ProiectRecords.Data;
using Barbu_Nicoleta_ProiectRecords.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Barbu_Nicoleta_ProiectRecords.Pages.Records
{
    public class DetailsModel : PageModel
    {
        private readonly Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext _context;

        public DetailsModel(Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext context)
        {
            _context = context;
        }

        public Record Record { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Record = await _context.Record.FirstOrDefaultAsync(m => m.ID == id);

            if (Record == null)
            {
                return NotFound();
            }
            ViewData["RecordhouseID"] = new SelectList(_context.Set<Recordhouse>(), "ID", "RecordhouseName");
            return Page();
        }
    }
}
