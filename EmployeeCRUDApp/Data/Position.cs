using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUDApp.Data
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; } // Primary Key

        [Required]
        [StringLength(50)]
        public string Description { get; set; } // Position Description

        [ForeignKey("ReportsTo")]
        public int? ReportsTo { get; set; } // Self-referencing Foreign Key
        public Position ReportsToPosition { get; set; } // Navigation for hierarchy
    }
}
