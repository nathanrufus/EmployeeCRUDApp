using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUDApp.Data
{
    public class Program
    {
        [Key]
        public int ProgramID { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string ProgramName { get; set; }

        [Required]
        [StringLength(100)]
        public string DiplomaName { get; set; }

        [Required]
        [StringLength(10)]
        public string SchoolCode { get; set; } // Foreign Key for School

        [Required]
        public decimal Tuition { get; set; } // Currency/Money field

        [Required]
        public decimal InternationalTuition { get; set; } // Currency/Money field
    }
}
