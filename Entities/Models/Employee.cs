using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "EmployeeName is Required.")]
        [MaxLength(60, ErrorMessage = "Max. Length is 60")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Required(ErrorMessage ="Age is Requird")]
        public int Age { get; set; }    

        [Required(ErrorMessage =" This field is required")]
        [MaxLength(60, ErrorMessage ="Max. Length is 60.")]
        public string Position { get; set; }   
        
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
