using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDApp.Data
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required(ErrorMessage = "Position Name is required")]
        public string PositionName { get; set; }
    }
}
