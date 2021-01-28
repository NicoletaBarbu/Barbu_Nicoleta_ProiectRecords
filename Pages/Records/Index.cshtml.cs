using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_ProiectRecords.Data;
using Barbu_Nicoleta_ProiectRecords.Models;

namespace Barbu_Nicoleta_ProiectRecords.Pages.Records
{
    public class IndexModel : PageModel
    {
        private readonly Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext _context;

        public IndexModel(Barbu_Nicoleta_ProiectRecords.Data.Barbu_Nicoleta_ProiectRecordsContext context)
        {
            _context = context;
        }

        public IList<Record> Record { get;set; }

        public async Task OnGetAsync()
        {
            Record = await _context.Record.ToListAsync();
            IList<Recordhouse> recordhouses = await _context.Recordhouse.ToListAsync();
            IList<Genre> genres = await _context.Genre.ToListAsync();
            Record.ToList().ForEach(record =>
            {
                record.Recordhouse = recordhouses.Single(p => p.ID == record.RecordhouseID);
                record.Genre = genres.Single(p => p.ID == record.GenreID);
            });
        }
    }
}
