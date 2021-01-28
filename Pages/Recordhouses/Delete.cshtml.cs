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
    public class DeleteModel : PageModel
    {
        private readonly Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext _context;

        public DeleteModel(Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recordhouse Recordhouse { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recordhouse = await _context.Recordhouse.FirstOrDefaultAsync(m => m.ID == id);

            if (Recordhouse == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recordhouse = await _context.Recordhouse.FindAsync(id);

            if (Recordhouse != null)
            {
                _context.Recordhouse.Remove(Recordhouse);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
