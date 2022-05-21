using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace TestDemo.Models
{
    [Table("TBL_TRN_REGISTRATION", Schema = "dbo")]
    public class TBL_TRN_REGISTRATION
    {
        public int USERID { get; set; }
        public string USERNAME { get; set; }
        [Required]
        public string PASSWORD { get; set; }
        public string CONFIRMPASS { get; set; }
        public string EMAIL { get; set; }
        public string SEXID { get; set; }
        public string MARITALID { get; set; }
    }
}
