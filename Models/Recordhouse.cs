using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barbu_Nicoleta_ProiectRecords.Models
{
    public class Recordhouse
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Record House")] 
        public string RecordhouseName { get; set; }

        [RegularExpression("^[0-9a-zA-Z]+([0-9a-zA-Z]*[-._+])*[0-9a-zA-Z]+@[0-9a-zA-Z]+([-.][0-9a-zA-Z]+)*([0-9a-zA-Z]*[.])[a-zA-Z]{2,6}$", ErrorMessage = "Incorrect Email Format!"), Required, StringLength(100, MinimumLength = 3)]
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Record> Records { get; set; }
    }
}
