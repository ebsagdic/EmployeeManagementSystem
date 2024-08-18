using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }

}
