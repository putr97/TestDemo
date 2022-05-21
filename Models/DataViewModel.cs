using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Models
{
    [Table("Crud_Data", Schema = "dbo")]
    public class CrudModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        public DateTime? InsertDate { get; set; }

        public string FatherName { get; set; }
    }
}
