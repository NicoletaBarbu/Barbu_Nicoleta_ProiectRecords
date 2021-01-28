using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbu_Nicoleta_ProiectRecords.Models
{
    public class RecordGenre
    {
        public int ID { get; set; }
        public int RecordID { get; set; }
        public Record Record { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
