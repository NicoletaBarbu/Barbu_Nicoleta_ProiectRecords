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

namespace Barbu_Nicoleta_ProiectRecords.Pages.Records
{
    public class EditModel : PageModel
    {
        private readonly Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext _context;

        public EditModel(Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            ViewData["GenreID"] = new SelectList(_context.Set<Genre>(), "ID", "GenreID");
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

            _context.Attach(Record).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordExists(Record.ID))
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

        private bool RecordExists(int id)
        {
            return _context.Record.Any(e => e.ID == id);
        }
    }
}
