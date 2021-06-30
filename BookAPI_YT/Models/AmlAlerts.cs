using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookAPI_YT.Models
{
   
    [Table("Client")]

    public class AmlAlerts
    {
     [Key]
        public int Client { get; set; }
        public string Occupation { get; set; }
        /*
        public string RuleNumber { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public string NumTrans { get; set; }
        
        public string AmtTrans { get; set; }
        public string Detail { get; set; }
        public string RevSuburb { get; set; }
        public string PrevSuburb { get; set; }
        public string Description { get; set; }*/

    }
}
