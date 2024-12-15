using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUDApp.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; } // Primary Key

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateHired { get; set; }

        public DateTime? ReleaseDate { get; set; } // Nullable for optional release.

        [ForeignKey("Position")]
        public int PositionID { get; set; } // Foreign Key
        public Position Position { get; set; }

        [ForeignKey("Program")]
        public int ProgramID { get; set; } // Foreign Key
        public Program Program { get; set; }

        [StringLength(30)]
        public string LoginID { get; set; } // Additional field
    }
}
