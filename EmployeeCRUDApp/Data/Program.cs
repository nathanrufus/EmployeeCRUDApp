using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDApp.Data
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }

        [Required(ErrorMessage = "Program Name is required")]
        public string ProgramName { get; set; }
    }
}
