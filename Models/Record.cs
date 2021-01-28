using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Barbu_Nicoleta_ProiectRecords.Models
{
    public class Record
    {
        public int ID { get; set; }
               
        [Display(Name = "Cover")]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Record Title")] 
        public string Title { get; set; }
        
        [Required]
        public string Artist { get; set; }
        
        [Required]
        [Range(0.0, 999.99)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Range(1950, 2021)]
        [Display(Name = "Year")]
        public int PublishingYear { get; set; }

        public int RecordhouseID { get; set; }
        public Recordhouse Recordhouse { get; set; }

        [Display(Name = "Musical Genre")] 
        public int GenreID { get; set; }

        public Genre Genre { get; set; }

    }
}
