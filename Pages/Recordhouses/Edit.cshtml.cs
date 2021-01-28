using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_ProiectRecords.Data;
using Barbu_Nicoleta_ProiectRecords.Models;

namespace Barbu_Nicoleta_ProiectRecords.Pages.Recordhouses
{
    public class EditModel : PageModel
    {
        private readonly Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext _context;

        public EditModel(Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Recordhouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordhouseExists(Recordhouse.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecordhouseExists(int id)
        {
            return _context.Recordhouse.Any(e => e.ID == id);
        }
    }
}
