using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record EmployeeDTO
    {
        public int Id { get; set; }
        [MaxLength(25), Required] public string? FirstName { get; set; }
        [MaxLength(25), Required] public string? LastName { get; set; }
        [Required] public decimal Salary { get; set; }
        [Required] public bool IsUnionMember { get; set; }
        public int DepartmentId { get; set; }
    }
}
