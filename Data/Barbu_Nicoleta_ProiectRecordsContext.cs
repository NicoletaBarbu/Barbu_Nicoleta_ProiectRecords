using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_ProiectRecords.Models;

namespace Barbu_Nicoleta_ProiectRecords.Data
{
    public class Barbu_Nicoleta_ProiectRecordsContext : DbContext
    {
        public Barbu_Nicoleta_ProiectRecordsContext (DbContextOptions<Barbu_Nicoleta_ProiectRecordsContext> options)
            : base(options)
        {
        }

        public DbSet<Barbu_Nicoleta_ProiectRecords.Models.Record> Record { get; set; }

        public DbSet<Barbu_Nicoleta_ProiectRecords.Models.Recordhouse> Recordhouse { get; set; }

        public DbSet<Barbu_Nicoleta_ProiectRecords.Models.Genre> Genre { get; set; }
    }
}
